using Entities;
using Inco_webAPI.V2.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog;
using NLog.Extensions.Logging;
using NLog.Web;
using Schools;

var builder = WebApplication.CreateBuilder(args);

var provider = builder.Services.BuildServiceProvider();

var configuration = provider.GetService<IConfiguration>();


LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
"/nlog.config"));

// Configure services
// config


builder.Services.ConfigureLoggerService();

builder.Services.AddDbContext<RepositoryContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
     optionsBuilder => optionsBuilder.MigrationsAssembly("Inco-webAPI.V2"))
            );
builder.Services.AddControllers();

builder.Services.ConfigureRepositoryManager();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

var envi = ((IApplicationBuilder)app).ApplicationServices.GetRequiredService<IOptions<IWebHostEnvironment>>();

var logger = app.Services.GetRequiredService<ILoggerManager>();

var env = app.Environment;


if (env.IsDevelopment())
    {
     app.UseDeveloperExceptionPage();
    }

    else {
         
        app.UseHsts();

         }


// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseCors("CorsPolicy");

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();

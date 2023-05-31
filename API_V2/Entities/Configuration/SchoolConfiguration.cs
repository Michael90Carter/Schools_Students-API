using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasData(
                new School {

                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Name = "St Michael Secondary School",
                    Address = "583 Nakawa, MD 21207",
                    Country = "UGANDA"
                },new School
                {
                     Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                     Name = "St Charles Lwanga Secondary School",
                     Address = "312 Bukerere Sonde, BF 923",
                     Country = "UGANDA"
                }
            );

        }

       
    }
}

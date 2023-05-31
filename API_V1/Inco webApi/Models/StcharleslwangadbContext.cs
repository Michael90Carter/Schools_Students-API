using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Inco_webApi.Models;

public partial class StcharleslwangadbContext : DbContext
{
    public StcharleslwangadbContext()
    {
    }

    public StcharleslwangadbContext(DbContextOptions<StcharleslwangadbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Studentdetail> Studentdetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Studentdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Studentd__3214EC07C352B717");

            entity.Property(e => e.Country)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Dob).HasColumnType("date");
            entity.Property(e => e.Doj).HasColumnType("date");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

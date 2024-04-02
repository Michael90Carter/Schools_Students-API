using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Inco_webApi.Models;

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

   /*public virtual DbSet<Schoolsdetails> Schoolsdetails { get; set; }*/

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


        modelBuilder.Entity<Schoolsdetails>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Schoolsd__3214EC07C352B717");

            entity.Property(e => e.SchoolName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Address)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.Property(e => e.Description)

                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SchoolName)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Inco_webApi.Models.Schoolsdetails>? Schoolsdetails { get; set; }

    public DbSet<Inco_webApi.Models.Studentdetail>? StudentdetailS { get; set; }


}

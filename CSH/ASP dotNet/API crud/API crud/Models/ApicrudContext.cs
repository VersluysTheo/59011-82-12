using System;
using System.Collections.Generic;
using API_crud.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace API_crud.Models;

public partial class ApicrudContext : DbContext
{
    public ApicrudContext()
    {
    }

    public ApicrudContext(DbContextOptions<ApicrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("Name=Default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.GradeId).HasName("PRIMARY");

            entity.ToTable("grade");

            entity.Property(e => e.GradeName).HasMaxLength(50);
            entity.Property(e => e.Section).HasMaxLength(50);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("student");

            entity.HasIndex(e => e.CurrentGradeId, "CurrentGradeId");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.CurrentGrade).WithMany(p => p.Students)
                .HasForeignKey(d => d.CurrentGradeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

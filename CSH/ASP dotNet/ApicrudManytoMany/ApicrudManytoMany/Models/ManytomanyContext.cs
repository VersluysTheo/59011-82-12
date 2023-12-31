﻿using System;
using System.Collections.Generic;
using ApicrudManytoMany.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ApicrudManytoMany.Data;

public partial class ManytomanyContext : DbContext
{
    public ManytomanyContext()
    {
    }

    public ManytomanyContext(DbContextOptions<ManytomanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Enfant> Enfants { get; set; }

    public virtual DbSet<Parent> Parents { get; set; }

    public virtual DbSet<ParentEnfant> ParentEnfants { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("Name=Default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enfant>(entity =>
        {
            entity.HasKey(e => e.IdEnfant).HasName("PRIMARY");

            entity.ToTable("enfant");

            entity.Property(e => e.IdEnfant).HasColumnName("Id_Enfant");
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.Prenom).HasMaxLength(50);
        });

        modelBuilder.Entity<Parent>(entity =>
        {
            entity.HasKey(e => e.IdParent).HasName("PRIMARY");

            entity.ToTable("parent");

            entity.Property(e => e.IdParent).HasColumnName("Id_Parent");
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.Prenom).HasMaxLength(50);
        });

        modelBuilder.Entity<ParentEnfant>(entity =>
        {
            entity.HasKey(e => e.IdParentEnfant).HasName("PRIMARY");

            entity.ToTable("parent_enfant");

            entity.HasIndex(e => e.IdEnfant, "Id_Enfant");

            entity.HasIndex(e => e.IdParent, "Id_Parent");

            entity.Property(e => e.IdParentEnfant).HasColumnName("id_parent_enfant");
            entity.Property(e => e.IdEnfant).HasColumnName("Id_Enfant");
            entity.Property(e => e.IdParent).HasColumnName("Id_Parent");

            entity.HasOne(d => d.Enfant).WithMany(p => p.ParentEnfants)
                .HasForeignKey(d => d.IdEnfant)
                .HasConstraintName("parent_enfant_ibfk_2");

            entity.HasOne(d => d.Parent).WithMany(p => p.ParentEnfants)
                .HasForeignKey(d => d.IdParent)
                .HasConstraintName("parent_enfant_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace api.Data.Models;

public partial class PersonnesDbContext : DbContext
{
    public PersonnesDbContext()
    {
    }

    public PersonnesDbContext(DbContextOptions<PersonnesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Personne> Personnes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseMySQL("Server=localhost;Database=personne;user=root;password=");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Personne>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("personnes");

            entity.HasIndex(e => e.Prenom, "prenom_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(50)
                .HasColumnName("adresse");
            entity.Property(e => e.CodePostal).HasColumnName("codePostal");
            entity.Property(e => e.Nom)
                .HasMaxLength(45)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(20)
                .HasColumnName("prenom");
            entity.Property(e => e.Ville)
                .HasMaxLength(20)
                .HasColumnName("ville");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
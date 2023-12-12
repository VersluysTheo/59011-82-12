using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestionDonnee.Models.Data;

public partial class ArticlesDbContext : DbContext
{
    public ArticlesDbContext()
    {
    }

    public ArticlesDbContext(DbContextOptions<ArticlesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Typesproduit> Typesproduits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=gestionstocks;user=root;password=");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.IdArticles).HasName("PRIMARY");

            entity.ToTable("articles");

            entity.HasIndex(e => e.IdCategories, "Id_Categories");

            entity.Property(e => e.IdArticles).HasColumnName("Id_Articles");
            entity.Property(e => e.IdCategories).HasColumnName("Id_Categories");
            entity.Property(e => e.LibelleArticle).HasMaxLength(50);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategories).HasName("PRIMARY");

            entity.ToTable("categories");

            entity.HasIndex(e => e.IdTypesProduits, "Id_TypesProduits");

            entity.Property(e => e.IdCategories).HasColumnName("Id_Categories");
            entity.Property(e => e.IdTypesProduits).HasColumnName("Id_TypesProduits");
            entity.Property(e => e.LibelleCategorie).HasMaxLength(50);
        });

        modelBuilder.Entity<Typesproduit>(entity =>
        {
            entity.HasKey(e => e.IdTypesProduits).HasName("PRIMARY");

            entity.ToTable("typesproduits");

            entity.Property(e => e.IdTypesProduits).HasColumnName("Id_TypesProduits");
            entity.Property(e => e.LibelleTypeProduit).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using CleDouble.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace CleDouble.Models
{
    public partial class CleDoubleContext : DbContext
    {
        public CleDoubleContext()
        {

        }
        public CleDoubleContext(DbContextOptions<CleDoubleContext> options) : base(options){

        }
        public virtual DbSet<Enfant> Enfants { get; set; }

        public virtual DbSet<Parent> Parents { get; set; }

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

                entity.HasMany(d => d.ListeEnfants).WithMany(p => p.ListeParents)
                    .UsingEntity<Dictionary<string, object>>(
                        "ParentEnfant",
                        r => r.HasOne<Enfant>().WithMany()
                            .HasForeignKey("IdEnfant")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("parent_enfant_ibfk_2"),
                        l => l.HasOne<Parent>().WithMany()
                            .HasForeignKey("IdParent")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("parent_enfant_ibfk_1"),
                        j =>
                        {
                            j.HasKey("IdParent", "IdEnfant").HasName("PRIMARY");
                            j.ToTable("parent_enfant");
                            j.HasIndex(new[] { "IdEnfant" }, "parent_enfant_ibfk_2");
                            j.IndexerProperty<int>("IdParent").HasColumnName("Id_Parent");
                            j.IndexerProperty<int>("IdEnfant").HasColumnName("Id_Enfant");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using Microsoft.EntityFrameworkCore;
using modeltobase.Models.Data;

namespace modeltobase.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Personnes> Personnes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Personnes>(e => e.Property(o =>
           o.Age).HasColumnType("int(1)").HasConversion<short>());
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace api.Data.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Personne> Personnes { get; set; }
    }
}

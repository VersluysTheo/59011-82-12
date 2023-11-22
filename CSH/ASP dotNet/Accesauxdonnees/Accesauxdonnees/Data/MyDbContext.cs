using Microsoft.EntityFrameworkCore;


namespace Accesauxdonnees.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
              
        }
    }
}

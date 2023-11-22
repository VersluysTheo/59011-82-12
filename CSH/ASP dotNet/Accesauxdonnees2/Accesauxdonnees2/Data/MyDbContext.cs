using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Accesauxdonnees2.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }
}

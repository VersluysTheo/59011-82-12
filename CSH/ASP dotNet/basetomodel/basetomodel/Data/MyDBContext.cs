using Microsoft.EntityFrameworkCore;

namespace basetomodel.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
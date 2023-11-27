using MySql.EntityFrameworkCore.Infrastructure;

namespace API_crud.Models.Services
{
    public class StudentsServices
    {
        private readonly MyDbContext _context;
        public StudentsServices(ApicrudContext context)
        {
            _context = context;
        }
    }
}

using crudapirelationnn.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace crudapirelationnn.Models.Services
{
    public class ParentService
    {
        private readonly CrudapirelationnnDbContext _context;

        public ParentService(CrudapirelationnnDbContext context)
        {
            _context = context;
        }

        public void AddParent(Parent p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Parents.Add(p);
            _context.SaveChanges();
        }

        public void DeleteParent(Parent p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Parents.Remove(p);
            _context.SaveChanges();
        }

        public IEnumerable<Parent> GetAllParents()
        {
            return _context.Parents.Include("SonEnfant").ToList();
        }

        public Parent GetParentById(int id)
        {
            return _context.Parents.Include("SonEnfant").FirstOrDefault(p => p.IdParent == id)!;
        }

        public void UpdateParent(Parent p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.SaveChanges();
        }
    }
}
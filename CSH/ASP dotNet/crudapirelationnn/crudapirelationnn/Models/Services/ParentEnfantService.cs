using crudapirelationnn.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace crudapirelationnn.Models.Services
{
    public class ParentEnfantService
    {
        private readonly CrudapirelationnnDbContext _context;

        public ParentEnfantService(CrudapirelationnnDbContext context)
        {
            _context = context;
        }

        public void AddParentEnfant(ParentEnfant p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.ParentEnfants.Add(p);
            _context.SaveChanges();
        }

        public void DeleteParentEnfant(ParentEnfant p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.ParentEnfants.Remove(p);
            _context.SaveChanges();
        }

        public IEnumerable<ParentEnfant> GetAllParentEnfants()
        {
            return _context.ParentEnfants.Include("SonEnfant").ToList();
        }

        public ParentEnfant GetParentEnfantById(int id)
        {
            return _context.ParentEnfants.Include("SonEnfant").FirstOrDefault(p => p.IdParentEnfant == id)!;
        }

        public void UpdateParentEnfant(ParentEnfant p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.SaveChanges();
        }
    }
}

using crudapirelationnn.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace crudapirelationnn.Models.Services
{
    public class EnfantService
    {
        private readonly CrudapirelationnnDbContext _context;

        public EnfantService(CrudapirelationnnDbContext context)
        {
            _context = context;
        }

        public void AddEnfant(Enfant e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            _context.Enfants.Add(e);
            _context.SaveChanges();
        }

        public void DeleteEnfant(Enfant e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            _context.Enfants.Remove(e);
            _context.SaveChanges();
        }

        public IEnumerable<Enfant> GetAllEnfants()
        {
            return _context.Enfants.Include("SonParent.Parent").ToList();
        }

        public Enfant GetEnfantById(int id)
        {
            return _context.Enfants.Include("SonParent").FirstOrDefault(e => e.IdEnfant == id)!;
        }

        public void UpdateEnfant(Enfant e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            _context.SaveChanges();
        }
    }
}
using CleDouble.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace CleDouble.Models.Services
{
    public class EnfantsServices
    {
        private readonly CleDoubleContext _context;
        public EnfantsServices(CleDoubleContext context)
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
            //si l'objet personne est null, on renvoi une exception
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            // on met à jour le context
            _context.Enfants.Remove(e);
            _context.SaveChanges();
        }
        public IEnumerable<Enfant> GetAllEnfants()
        {
            return _context.Enfants.Include("ListeParents.Parent").ToList();
        }
        public Enfant? GetEnfantById(int id)
        {
            return _context.Enfants.Include("ListeParents").FirstOrDefault(p => p.IdEnfant == id);
        }
        public void UpdateEnfant(Enfant e)
        {
            _context.Enfants.Update(e);
            _context.SaveChanges();
        }
    }
}

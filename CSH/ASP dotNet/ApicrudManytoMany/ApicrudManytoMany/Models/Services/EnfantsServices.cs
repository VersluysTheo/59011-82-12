using ApicrudManytoMany.Data;
using ApicrudManytoMany.Data.Models;

namespace ApicrudManytoMany.Models.Services
{
    public class EnfantsServices
    {
        private readonly ManytomanyContext _context;
        public EnfantsServices(ManytomanyContext context)
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
            return _context.Enfants.ToList();
        }
        public Enfant? GetEnfantById(int id)
        {
            return _context.Enfants.FirstOrDefault(p => p.IdEnfant == id);
        }
        public void UpdateEnfant(Enfant e)
        {
            _context.Enfants.Update(e);
            _context.SaveChanges();
        }

    }
}

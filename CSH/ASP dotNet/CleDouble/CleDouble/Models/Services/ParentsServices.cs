using CleDouble.Models.Data;
using CleDouble.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CleDouble.Models.Services
{
    public class ParentsServices
    {
        private readonly CleDoubleContext _context;
        public ParentsServices(CleDoubleContext context)
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
            //si l'objet personne est null, on renvoi une exception
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            // on met à jour le context
            _context.Parents.Remove(p);
            _context.SaveChanges();
        }
        public IEnumerable<Parent> GetAllParents()
        {
            return _context.Parents.Include("ListeEnfants").ToList();
        }
        public Parent? GetParentById(int id)
        {
            return _context.Parents.Include("ListeEnfants").FirstOrDefault(p => p.IdParent == id);
        }
        public void UpdateParent(Parent p)
        {
            _context.Parents.Update(p);
            _context.SaveChanges();
        }
    }
}

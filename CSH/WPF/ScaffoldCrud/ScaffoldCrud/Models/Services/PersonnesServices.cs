using ScaffoldCrud.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaffoldCrud.Models.Services
{
    public class PersonnesServices
    {
        private readonly PersonnesDbContext _context;
        public PersonnesServices(PersonnesDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Personne> GetAllPersonnes()
        {
            return _context.Personnes.ToList();
        }
        public Personne? GetPersonneById(uint id)
        {
            return _context.Personnes.FirstOrDefault(p => p.Id == id);
        }
        public void AddPersonnes(Personne perso)
        {
            if (perso == null) throw new ArgumentNullException(nameof(perso));

            _context.Personnes.Add(perso);
            _context.SaveChanges();
        }
        public void DeletePersonne(Personne perso)
        {
            //si l'objet personne est null, on renvoi une exception
            if (perso == null) throw new ArgumentNullException(nameof(perso));

            // on met à jour le context
            _context.Personnes.Remove(perso);
            _context.SaveChanges();
        }
        public void UpdatePersonne(Personne perso)
        {
            _context.Personnes.Update(perso);

            _context.SaveChanges();
        }
    }
}

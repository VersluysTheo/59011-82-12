using api.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace api.Data.Services
{
    public class PersonnesServices
    {
        private readonly MyDbContext _context;
        public PersonnesServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddPersonnes(Personne p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Personnes.Add(p);
            _context.SaveChanges();
        }

        public void DeletePersonne(Personne p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Personnes.Remove(p);
            _context.SaveChanges();
        }

        public IEnumerable<Personne> GetAllPersonnes()
        {
            return _context.Personnes.ToList();
        }
        public Personne GetPersonneById(int id)
        {
            return _context.Personnes.FirstOrDefault(p => p.Id == id);
        }
        public void UpdatePersonne(Personne p)
        {
            _context.Personnes.Update(p);
            _context.SaveChanges();
        }
    }
}
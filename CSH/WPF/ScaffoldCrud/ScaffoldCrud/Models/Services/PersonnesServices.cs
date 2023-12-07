﻿using ScaffoldCrud.Models.Data;
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
        public Personne? GetPersonneById(int id)
        {
            return _context.Personnes.FirstOrDefault(p => p.Id == id);
        }
        public void AddPersonnes(Personne p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));

            _context.Personnes.Add(p);
            _context.SaveChanges();
        }
        public void DeletePersonne(Personne p)
        {
            //si l'objet personne est null, on renvoi une exception
            if (p == null) throw new ArgumentNullException(nameof(p));

            // on met à jour le context
            _context.Personnes.Remove(p);
            _context.SaveChanges();
        }
        public void UpdatePersonne(Personne p)
        {
            _context.SaveChanges();
        }
    }
}

﻿using ApicrudManytoMany.Data;
using ApicrudManytoMany.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ApicrudManytoMany.Models.Services
{
    public class ParentsEnfantsServices
    {
        private readonly ManytomanyContext _context;
        public ParentsEnfantsServices(ManytomanyContext context)
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
            return _context.ParentEnfants.Include("ParentEnfants.Enfant").ToList();
        }

        public ParentEnfant GetParentEnfantById(int id)
        {
            return _context.ParentEnfants.Include("ParentEnfants.Enfant").FirstOrDefault(e => e.IdEnfant == id)!;
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

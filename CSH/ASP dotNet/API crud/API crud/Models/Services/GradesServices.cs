using API_crud.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace API_crud.Models.Services
{
    public class GradesServices
    {
        private readonly ApicrudContext _context;
        public GradesServices(ApicrudContext context)
        {
            _context = context;
        }

        public void AddGrade(Grade g)
        {
            if (g == null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            _context.Grades.Add(g);
            _context.SaveChanges();
        }

        public void DeleteGrade(Grade g)
        {
            if (g == null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            _context.Grades.Remove(g);
            _context.SaveChanges();
        }

        public IEnumerable<Grade> GetAllGrades()
        {
            return _context.Grades.ToList();
        }

        public Grade? GetGradeById(int id)
        {
            return _context.Grades.FirstOrDefault(g => g.GradeId == id);
        }

        public void UpdateGrade(Grade g)
        {
            _context.Grades.Update(g);
            _context.SaveChanges();
        }

    }
}

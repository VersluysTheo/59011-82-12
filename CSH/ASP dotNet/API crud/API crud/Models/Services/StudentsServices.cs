using API_crud.Models.Data;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Infrastructure;

namespace API_crud.Models.Services
{
    public class StudentsServices
    {
        private readonly ApicrudContext _context;
        public StudentsServices(ApicrudContext context)
        {
            _context = context;
        }
        public void AddStudent(Student s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _context.Students.Add(s);
            _context.SaveChanges();
        }
        public void DeleteStudent(Student s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _context.Students.Remove(s);
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateStudent(Student s)
        {
            _context.Students.Update(s);
            _context.SaveChanges();
        }

    }
}

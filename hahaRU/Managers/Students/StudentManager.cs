using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Students
{
    public class StudentManager : IStudentManager
    {
        private ExampleContext _context;

        //public StudentManager()
        //{
        //    _context = new ExampleContext();
        //}

        public StudentManager(ExampleContext context)
        {
            _context = context;
        }

        public void Delete(Guid id)
        {
            var student = _context.Students.FirstOrDefault(st => st.Id == id);
            if (student != null)
                _context.Students.Remove(student);
        }

        public ICollection<Student> GetAll()
        {
            return _context.Students;
        }

        public ICollection<Student> GetStudentsByGroup(Guid groupId)
        {
            return _context.Students.Where(st => st.Group.Id == groupId).ToList();
        }
    }
}

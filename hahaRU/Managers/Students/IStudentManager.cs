using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Students
{
    public interface IStudentManager
    {
        ICollection<Student> GetAll();
        ICollection<Student> GetStudentsByGroup(Guid groupId);
        void Delete(Guid id);
    }
}

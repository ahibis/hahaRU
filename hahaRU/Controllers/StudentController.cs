using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Managers.Students;
using WebApplication1.Storage;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private IStudentManager _manager;

        public StudentController(IStudentManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var students = _manager.GetAll();
            return View(students);
        }

        [HttpPost]
        public IActionResult DeleteStudent(Guid studentId)
        {
            _manager.Delete(studentId);
            return RedirectToAction(nameof(Index));
        }
    }
}

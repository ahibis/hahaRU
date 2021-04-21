using hahaRU.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Controllers
{
    public class RegistrationController : Controller
    {
        private IAuthManager _manager;

        public RegistrationController(IAuthManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Registration(AuthDate date)
        {
            return  _manager.Registarion(date, HttpContext);
            //return RedirectToAction(nameof(Index));
        }
        
    }
}

using hahaRU.Managers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Controllers
{
    public class AuthController : Controller
    {
        private IAuthManager _manager;

        public AuthController(IAuthManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Login(AuthDate date)
        {
            return _manager.Login(date, HttpContext);
            //return RedirectToAction(nameof(Index));
        }
    }
}

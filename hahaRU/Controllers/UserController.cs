using hahaRU.Managers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Controllers
{
    public class UserController : Controller
    {
        private IApiManager _manager;

        public UserController(IApiManager manager)
        {
            _manager = manager;//manager
        }
        [Route("User/{id:int}")]
        public IActionResult Index(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.id = 0;
            return View();
        }
    }
}

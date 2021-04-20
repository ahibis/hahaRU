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
        private IUserManager _manager;

        public UserController(IUserManager manager)
        {
            _manager = manager;//manager
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

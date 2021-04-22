using hahaRU.Managers;
using hahaRU.Storage.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Controllers
{
    public class apiController : Controller
    {
        IUserManager _manager;

        public apiController(IUserManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        public string getUser(int id)
        {
            //return "{}";
            return _manager.getUser(id);
        }
        [HttpPost]
        public string getMy()
        {
            return _manager.getUser(HttpContext);
        }
        public string updateUser(User user)
        {
            return _manager.updateUser(user, HttpContext);
        }
    }
    
}

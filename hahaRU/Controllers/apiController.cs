using hahaRU.Managers;
using hahaRU.Storage.Entity;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hahaRU.Models;

namespace hahaRU.Controllers
{
    public class apiController : Controller
    {
        IApiManager _manager;

        public apiController(IApiManager manager)
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
        [HttpPost]
        public string updateUser(User user)
        {
            return _manager.updateUser(user, HttpContext);
        }
        [HttpPost]
        public JsonResult sendPost(Post post)
        {
            return Json(_manager.sendPost(post,HttpContext));
        }
        [HttpPost]
        public string getPostImg(IFormFile uploadImage)
        {
            return "ok";
        }
        [HttpPost]
        public JsonResult getPosts(getPostReq data)
        {
            return Json(_manager.getPosts(data));
        }
    }
    
}

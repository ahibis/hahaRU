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
            return Json(_manager.sendPost(post, HttpContext));
        }
        [HttpPost]
        public string getPostImg(IFormFile uploadImage)
        {
            return "ok";
        }
        [HttpPost]
        public JsonResult getPosts(getPostReq data)
        {
            return Json(_manager.getPosts(data, HttpContext));
        }
        [HttpPost]
        public JsonResult changeLiked(int postId)
        {
            return Json(_manager.changeLiked(postId, HttpContext));
        }
        [HttpPost]
        public JsonResult changeDisLiked(int postId)
        {
            return Json(_manager.changeDisLiked(postId, HttpContext));
        }
        [HttpPost]
        public JsonResult changeContentLiked(int postId,string type)
        {
            return Json(_manager.changeContentLiked(postId, type, HttpContext));
        }
        [HttpPost]
        public JsonResult changeContentDisLiked(int postId, string type)
        {
            return Json(_manager.changeContentDisLiked(postId, type, HttpContext));
        }
        [HttpPost]
        public JsonResult getRundomMemText()
        {
            return Json(_manager.getRundomMemText());
        }
        [HttpPost]
        public JsonResult getRundomMemImg()
        {
            return Json(_manager.getRundomMemImg());
        }
        [HttpPost]
        public JsonResult getRundomAnecdot()
        {
            return Json(_manager.getRundomAnecdot());
        }
        [HttpPost]
        public JsonResult getRundomVideo()
        {
            return Json(_manager.getRundomVideo());
        }
        [HttpPost]
        public JsonResult saveMem()
        {
            return Json(_manager.getRundomVideo());
        }
        [HttpPost]
        public JsonResult getContents(getPostReq data)
        {
            return Json(_manager.getContents(data, HttpContext));
        }
        
    }
    
}

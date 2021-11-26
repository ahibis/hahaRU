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
using Microsoft.AspNetCore.Hosting;

namespace hahaRU.Controllers
{
    public class apiController : Controller
    {
        IApiManager _manager;
        IWebHostEnvironment _appEnvironment;
        public apiController(IApiManager manager, IWebHostEnvironment appEnvironment)
        {
            _manager = manager;
            _appEnvironment = appEnvironment;
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
        public string getPostImg(IFormFile uploadImage)
        {
            return "ok";
        }
        [HttpPost]
        public JsonResult saveAva(IFormFile uploadImage)
        {
            if (Request.Form == null) return Json(new object());
            var Files = Request.Form.Files;
            return Json(_manager.saveAva(Files, _appEnvironment.WebRootPath, HttpContext));
        }
        [HttpPost]
        public JsonResult saveMem(string imgBase64)
        {
            return Json(_manager.saveMem(imgBase64, _appEnvironment.WebRootPath));
        }
        [HttpPost]
        public JsonResult saveMemPic(IList<IFormFile> files)
        {
            if (Request.Form==null) return Json(new object());
            var Files = Request.Form.Files;
            return Json(_manager.saveMemPic(Files, _appEnvironment.WebRootPath));
        }
        [HttpPost]
        public JsonResult getContents(getPostReq data)
        {
            return Json(_manager.getContents(data, HttpContext));
        }
        
    }
    
}

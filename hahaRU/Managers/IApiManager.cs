using hahaRU.Models;
using hahaRU.Storage.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Managers
{
    public interface IApiManager
    {
        string getUser(int id);
        string getUser(HttpContext httpContext);
        string updateUser(User user, HttpContext httpContext);
        object sendPost(Post post, HttpContext httpContext);
        object getPosts(getPostReq data, HttpContext httpContext);
        object checkLiked(int postId, HttpContext httpContext);
        object checkDisLiked(int postId, HttpContext httpContext);
        object changeLiked(int postId, HttpContext httpContext);
        object changeDisLiked(int postId, HttpContext httpContext);
    }
}

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
        object getPosts(getPostReq data);
    }
}

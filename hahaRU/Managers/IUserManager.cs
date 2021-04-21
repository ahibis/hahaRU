using hahaRU.Storage.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Managers
{
    public interface IUserManager
    {
        string getUser(int id);
        string getUser(HttpContext httpContext);
        string updateUser(User user, HttpContext httpContext);
    }
}

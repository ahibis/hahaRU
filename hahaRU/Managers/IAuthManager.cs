using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Managers
{
    public interface IAuthManager
    {
        public string Login(AuthDate date, HttpContext httpContext);
        public string Registarion(AuthDate date, HttpContext httpContext);
    }
}

using hahaRU.Lib;
using hahaRU.Storage;
using hahaRU.Storage.Entity;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace hahaRU.Managers
{
   
    public class AuthDate
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Password2 { get; set; }
    }
    public class AuthManager:IAuthManager
    {

        private Context _context;

        public AuthManager(Context context)
        {
            _context = context;
        }
        public string Login(AuthDate data, HttpContext httpContext)
        {
            if (data.Name == null) return "Введите login";
            if (data.Password == null) return "Введите password";
            List<User> users=_context.Users.Where(e => e.Login==data.Name).ToList();
            if(users.Count==0) return "Нет пользователя с таким логином";
            User user = users[0];
            if(!Auth.VerifyHashedPassword(user.Password, data.Password)) return "Пароль не верен";
            httpContext.Session.SetInt32("id", user.Id);
            return "ok";
        }

        public string Registarion(AuthDate data, HttpContext httpContext)
        {
            if (data.Name == null) return "Введите login";
            if (data.Password == null) return "Введите пароль";
            if (data.Password2 == null) return "Повторите пароль";
            if (data.Email == null) return "Введите email";
            List<User> users = _context.Users.Where(e => e.Login == data.Name).ToList();
            if (users.Count > 0) return "Пользователь с таким именем уже существует";
            users = _context.Users.Where(e => e.Email == data.Email).ToList();
            if (users.Count > 0) return "Пользователь с такой почтой уже существует";
            if(data.Password!=data.Password2) return "Пароли не совпадают";
            string password = Auth.HashPassword(data.Password);
            User user = new User
            {
                Login = data.Name,
                Password = password,
                Email = data.Email,
                Status = "привет, я Фиксик",
                AvatarSrc = "/img/logo.png",
                FavoriteJoke = "",
                VkLink = "",
                Telegram="",
                InstaLink="",
                Date= "2021-04-15"
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            httpContext.Session.SetInt32("id", user.Id);
            return "ok";
        }
    }

}

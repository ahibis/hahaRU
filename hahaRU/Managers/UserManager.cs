using hahaRU.Storage;
using hahaRU.Storage.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace hahaRU.Managers
{
    public class UserManager: IUserManager
    {
        private Context _context;

        public UserManager(Context context)
        {
            _context = context;

        }



        public string getUser(int id)
        {
            var users = _context.Users.Where(e => e.Id == id).ToList();
            if (users.Count == 0) return "{}";
            users[0].Password = null;
            return JsonSerializer.Serialize(users[0]);
        }

        public string getUser(HttpContext httpContext)
        {
            int? id = httpContext.Session.GetInt32("id");
            if (id == null) return "{}";
            var users = _context.Users.Where(e => e.Id == id).ToList();
            if (users.Count == 0) return "{}";
            users[0].Password = null;
            return JsonSerializer.Serialize(users[0]);
        }

        public string updateUser(User user, HttpContext httpContext)
        {
            if (user.Id==0) return "Id is not find";
            int? id = httpContext.Session.GetInt32("id");
            if(id==null) return "Your doesn't auth";
            if(id!=user.Id) return "нельзя изменять чужой аккаунт";
            User userNew = _context.Users
                .Where(c => c.Id == id)
                .First();
            if (userNew == null) return "how";
            if (user.AvatarSrc != null) userNew.AvatarSrc = user.AvatarSrc;
            if (user.Date != null) userNew.Date = user.Date;
            if (user.Status != null) userNew.Status = user.Status;
            if (user.FavoriteJoke != null) userNew.FavoriteJoke = user.FavoriteJoke;
            if (user.VkLink != null) userNew.VkLink = user.VkLink;
            if (user.Telegram != null) userNew.Telegram = user.Telegram;
            if (user.InstaLink != null) userNew.InstaLink = user.InstaLink;
            _context.SaveChanges();
            return "ok";
        }
    }
}

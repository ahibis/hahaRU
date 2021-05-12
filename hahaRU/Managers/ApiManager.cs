using hahaRU.Lib;
using hahaRU.Models;
using hahaRU.Storage;
using hahaRU.Storage.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace hahaRU.Managers
{
    public class ApiManager: IApiManager
    {
        private Context _context;

        public ApiManager(Context context)
        {
            _context = context;

        }

        public object changeDisLiked(int postId, HttpContext httpContext)
        {
            int? id = httpContext.Session.GetInt32("id");
            if (id == null) return new JsonStatus() { status = "error", text = "вы не зарегестрированы" };
            List<Post> posts = _context.Posts.Where(post => post.Id == postId).ToList();
            if (posts.Count == 0) return new JsonStatus() { status = "error", text = "post не существует" };
            Post post = posts[0];
            IdList likes = new IdList(post.Dislikes);
            if (likes.hasId((int)id))
            {
                likes.removeId((int)id);
                post.Dislikes = likes.toString();
                post.DislikesCount--;
            }
            else
            {
                likes.AddId((int)id);
                post.Dislikes = likes.toString();
                post.DislikesCount++;
            }
            _context.SaveChanges();
            return new JsonStatus() { status = "ok", 
                text = "все окей",
                value = new PostData()
                {
                    IsDisLiked = likes.hasId((int)id) ? 1 : 0,
                    DislikesCount = post.DislikesCount,
                    Id = post.Id
                }
            };
        }

        public object changeLiked(int postId, HttpContext httpContext)
        {
            int? id = httpContext.Session.GetInt32("id");
            if (id == null) return new JsonStatus() { status = "error", text = "вы не зарегестрированы" };
            List<Post> posts = _context.Posts.Where(post => post.Id == postId).ToList();
            if(posts.Count==0) return new JsonStatus() { status = "error", text = "post не существует" };
            Post post = posts[0];
            IdList likes = new IdList(post.Likes);
            if(likes.hasId((int)id))
            {
                likes.removeId((int)id);
                post.Likes = likes.toString();
                post.LikesCount--;
            }
            else
            {
                likes.AddId((int)id);
                post.Likes = likes.toString();
                post.LikesCount++;
            }
            _context.SaveChanges();
            return new JsonStatus() { 
                status = "ok", 
                text = "все окей", 
                value = new PostData() {
                    IsLiked= likes.hasId((int)id)?1:0,
                    LikesCount= post.LikesCount,
                    Id=post.Id
                } };
        }

        public object checkDisLiked(int postId, HttpContext httpContext)
        {
            return new object();
        }

        public object checkLiked(int postId, HttpContext httpContext)
        {
            return new object();
        }

        public object getPosts(getPostReq data, HttpContext httpContext)
        {
            int count= data.Count ?? 20;
            int offset = data.Offset ?? 0;
            int? id = httpContext.Session.GetInt32("id");
            id = (id==null)?0:id;
            List<Post> posts;
            if (data.UserId == null)
                posts= _context.Posts.OrderByDescending(x => x.Likes).Skip(offset).Take(count).ToList();
            else
                posts = _context.Posts.Where(e => e.UserId == data.UserId).OrderByDescending(x => x.Id).Skip(offset).Take(count).ToList();

            List<PostData> Posts = new List<PostData>();
            foreach(Post post in posts)
            {
                Posts.Add(new PostData()
                {
                    Id = post.Id,
                    Text = post.Text,
                    Date = post.Date,
                    UserId = post.UserId,
                    ImgSrc = post.ImgSrc,
                    IsLiked = (new IdList(post.Likes)).hasId((int)id) ? 1: 0,
                    IsDisLiked = (new IdList(post.Dislikes)).hasId((int)id) ? 1 : 0,
                    LikesCount=post.LikesCount,
                    DislikesCount=post.DislikesCount
                });
            }
            return Posts;
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

        public object sendPost(Post post, HttpContext httpContext)
        {
            int? id = httpContext.Session.GetInt32("id");
            if (id == null) return new JsonStatus() { status = "error", text = "Вы не авторизовались" };
            if (post.Text == "") return new JsonStatus() { status = "error", text = "Пост не может быть без текста" };
            if (post.Text == null) return new JsonStatus() { status = "error", text = "текст не найден" };
            Post post1 = new Post()
            {
                Text = post.Text,
                UserId = (int)id,
                Date = post.Date
            };
            _context.Posts.Add(post1);
            _context.SaveChanges();
            return new JsonStatus() { status="ok",text="ok"};
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

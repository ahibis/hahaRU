using hahaRU.Storage.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Storage
{
    public class Context
    {
        /*public Context(DbContextOptions<Context> options) : base(options)
        {

        }*/
        public Context()
        {
            Users = new List<User>();
            Posts = new List<Post>();
            Users.Add(new User());

        }
        public List<User> Users { get; set; }
        public List<Post> Posts { get; set; }
    }
}

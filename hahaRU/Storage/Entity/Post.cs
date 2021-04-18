using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Storage.Entity
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }

    }
}

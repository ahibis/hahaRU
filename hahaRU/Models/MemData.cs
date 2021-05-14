using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Models
{
    public class MemData
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public int UserId { get; set; }
        public string ImgSrc { get; set; }
        public int IsLiked { get; set; }
        public int IsDisLiked { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
    }
}

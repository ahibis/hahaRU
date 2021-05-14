using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Storage
{
    interface IContent
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Text { get; set; }
        public string VideoSrc { get; set; }
        public string ImgSrc { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
    }
}

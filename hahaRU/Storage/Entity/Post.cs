using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Storage.Entity
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [DefaultValue("2021-04-15")]
        public string Date { get; set; }
        [Required]
        public int UserId { get; set; }
        [DefaultValue("")]
        public string ImgSrc { get; set; }
        [DefaultValue("")]
        public string Likes { get; set; }
        [DefaultValue("")]
        public string Dislikes { get; set; }
        [DefaultValue(0)]
        public int LikesCount { get; set; }
        [DefaultValue(0)]
        public int DislikesCount{ get; set; }
    }
}

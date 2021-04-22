using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Storage.Entity
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        public string Password { get; set; }
        public string AvatarSrc { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string FavoriteJoke { get; set; }
        public string VkLink { get; set; }
        public string Telegram { get; set; }
        public string InstaLink { get; set; }
    }
}

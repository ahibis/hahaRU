using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Storage.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public int Name { get; set; }
        public int SecondName { get; set; }
        public string AvatarSrc { get; set; }

        public string Status { get; set; }
        public string FavoriteJoke { get; set; }
        public string VkLink { get; set; }
        public string Telegram { get; set; }
        public string InstaLink { get; set; }
    }
}

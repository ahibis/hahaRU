using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Models
{
    public class getPostReq
    {
        public int? Count { get; set; }
        public int? Offset { get; set; }
        public int? Sort { get; set; }
        public int? UserId { get; set; }
        public string type { get; set; }
    }
}

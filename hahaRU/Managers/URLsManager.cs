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
    public class URLsManager: IURLsManager
    {
        private Context _context;

        public URLsManager(Context context)
        {
            _context = context;

        }

        public int Id()
        {
            return 1;
        }

        public string Url()
        {
            string i = "LP5k6pO37kw";
            return i;
        }
    }
}

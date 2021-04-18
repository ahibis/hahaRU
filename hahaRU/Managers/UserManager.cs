using hahaRU.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Managers
{
    public class UserManager: IUserManager
    {
        private Context _context;

        public UserManager(Context context)
        {
            _context = context;
        }
    }
}

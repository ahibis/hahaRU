using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Lib
{
    public class Likes
    {
        string _likes;

        public Likes(string likes)
        {
            _likes = likes;
        }
        public void AddId(int Id)
        {
            int f1 = 0;
            int f2=_likes.Length-1;
            int s;
            int ord;
            while (true)
            {
                s = (f1 + f2) / 2;
                
                ord = (int)_likes[s];
                if (ord == Id) return;
                if (ord > Id)
                {
                    f2 = s;
                }
                if (ord < Id)
                {
                    f1 = s;
                }
                if (f2==f1+1) break;
            }
            //_likes.Insert()
        }
        public void removeId(int Id)
        {

        }
    }
}

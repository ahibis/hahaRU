using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Managers
{
    public interface IGeneratorManager
    {
        public string anecdotGen();
        public string GetURL();
        void addFunnyWord(string word);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU
{
    public class wordGen
    {
        public string word;
        public wordGen()
        {
            word = getWord();
        }
        public string getWord()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 399);
            string s, s3;
            string[] bonus = { "Похороны", "Абоба" };
            if (i == 0)
                return bonus[rnd.Next(0, 2)];
            string[] s1 = { "Д", "Б", "Х", "П" };
            s = s1[rnd.Next(0, 4)];
            string[] s2 = { "аб", "об", "уб", "ыб", "еб", "иб" };
            s += s2[rnd.Next(0, 6)];
            string[] A = { s, "Пип", "Зелеб", "Еб", "Ебол", "Хеб", "Поп" };
            s3 = A[rnd.Next(0, 7)];
            string[] B = { "y", "ы", "e", "o" };
            s3 += B[rnd.Next(0, 4)];
            string[] C = { "лда", "га", "бa", "нгa" };
            s3 += C[rnd.Next(0, 4)];
            return s3;
        }
    }
}

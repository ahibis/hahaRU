using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU
{
    public class AHAHAHAH
    {
        public string word;
        public AHAHAHAH()
        {
            word = getWord();
        }
        public string getWord()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 99);
            if (i == 0)
            {
                return "Абоба";
            }
            else if (i == 1)
            {
                return "Похороны";
            }
            string s, s3;
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

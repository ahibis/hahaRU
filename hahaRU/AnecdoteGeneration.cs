﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU
{
    public class anecdotGen
    {
        public string word;
        public anecdotGen()
        {
            word = getWord();
        }
        public string getWord()
        {
            Random rnd = new Random();
            string s;
            string[] A = { "Вегетарианцы не стареют. Они увядают.", "- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.", "Ищете женщину? Лучше ищите деньги! Женщина сама вас найдет.", "От импотенции еще ни кто не умирал, правда ни кто и не рождался.", "Заходит как-то в бар глухонемой и говорит: . . . . . ." };
            s = A[rnd.Next(0, 5)];
            return s;
        }
    }
}
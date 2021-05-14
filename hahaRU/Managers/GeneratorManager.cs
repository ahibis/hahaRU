using hahaRU.Storage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace hahaRU.Managers
{
    public class GeneratorManager:IGeneratorManager
    {
        private Context _context;

        public GeneratorManager(Context context)
        {
            _context = context;
            url = GetURL();
        }
        public string anecdotGen()
        {
            Random rnd = new Random();
            string s;
            _context.AnecdotTexts.Count();
            //_context.AnecdotTexts.ToList();

            string[] A = { "Вегетарианцы не стареют. Они увядают.", "- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.", "Ищете женщину? Лучше ищите деньги! Женщина сама вас найдет.", "От импотенции еще ни кто не умирал, правда ни кто и не рождался.", "Заходит как-то в бар глухонемой и говорит: . . . . . ." };
            s = A[rnd.Next(0, 5)];
            return s;
        }
        private static Random random = new Random();
        public string url;

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string GetURL()
        {
            try
            {
                var count = 1; //50 max
                var API_KEY = "AIzaSyBVJ5iH6EhlQ7g_3XQlO4US_ytkbam1kOU";
                var q = RandomString(4);
                // var url = "https://www.googleapis.com/youtube/v3/search?key=" + API_KEY + "&maxResults=" + count + "&part=snippet&type=video&q=" + q;

                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString(url);
                    dynamic jsonObject = JsonConvert.DeserializeObject(json);
                    foreach (var line in jsonObject["items"])
                    {
                        return line["id"]["videoId"];
                        //Console.WriteLine(line["id"]["videoId"]);
                        /*store your id*/
                    }
                    q = "LP5k6pO37kw";
                    return q;
                }
            }
            catch
            {
                var q = "LP5k6pO37kw";
                return q;
            }
        }
    }
}

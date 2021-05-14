using hahaRU.Storage;
using hahaRU.Storage.Entity;
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
            int i1 = _context.AnecdotTexts.Count();
            int i2 = _context.AnecdotEnds.Count();
            //_context.AnecdotTexts.ToList();
            int rng1 = rnd.Next(1, i1+1);
            int rng2 = rnd.Next(1, i2+1);
            string s1 = _context.AnecdotTexts.Single(x => x.Id == rng1).Text;
            string s2 = _context.AnecdotEnds.Single(x => x.Id == rng2).Text;
            string s3 = s1 + " " + s2;

            //string[] A = { "Вегетарианцы не стареют. Они увядают.", "- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.- Мама, а правда, что я получился нечаянно? - Сынок, буду откровенна - не очень-то ты и получился.", "Ищете женщину? Лучше ищите деньги! Женщина сама вас найдет.", "От импотенции еще ни кто не умирал, правда ни кто и не рождался.", "Заходит как-то в бар глухонемой и говорит: . . . . . ." };
            //s = A[rnd.Next(0, 5)];
            return s3;
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
            //if (_context.VideoSrcs.Count()!=0) //удаление потом допишем
            //{
            //    string url = _context.VideoSrcs.Single(x => x.Id == 1).Src;
            //    var urltoDelete = _context.VideoSrcs.Single(x => x.Id == 1);
            //    _context.VideoSrcs.Remove(urltoDelete);
            //    _context.SaveChanges();

            //    return url;
            //}

            try
            {
                var count = 100; //100 max
                var API_KEY = "AIzaSyBVJ5iH6EhlQ7g_3XQlO4US_ytkbam1kOU";
                var q = RandomString(4);
                var url = "https://www.googleapis.com/youtube/v3/search?key=" + API_KEY + "&maxResults=" + count + "&part=snippet&type=video&q=" + q;

                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString(url);
                    dynamic jsonObject = JsonConvert.DeserializeObject(json);
                    foreach (var line in jsonObject["items"])
                    {
                        var newurl = new VideoSrc() { Src = line["id"]["videoId"] };
                        _context.Add(newurl);
                        _context.SaveChanges();
                        //return line["id"]["videoId"];
                    }
                    Random rnd = new Random();
                    int i = _context.VideoSrcs.Count();
                    int rng = rnd.Next(1, i + 1);
                    q = _context.VideoSrcs.Single(x => x.Id == rng).Src;
                    return q;
                }
            }
            catch
            {
                Random rnd = new Random();
                int i = _context.VideoSrcs.Count();
                int rng = rnd.Next(1, i + 1);
                string q = _context.VideoSrcs.Single(x => x.Id == rng).Src;
                return q;
            }
        }
    }
}

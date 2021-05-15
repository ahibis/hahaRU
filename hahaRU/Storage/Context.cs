using hahaRU.Storage.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Storage
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
        }

        public DbSet<User> Users { get; set; }//Юзеры
        public DbSet<Post> Posts { get; set; }//Посты
        public DbSet<Anecdot> Anecdots { get; set; }//Сгенерированные анекдоты
        public DbSet<FunnyWord> FunnyWords { get; set; }//Сгенерированные Слова
        public DbSet<Mem> Mems { get; set; }//Сгенерированные мемы
        public DbSet<Video> Videos { get; set; }//Сгенерированные видео
        public DbSet<AnecdotTexts> AnecdotTexts { get; set; }//1 часть анекдота
        public DbSet<AnecdotEnd> AnecdotEnds { get; set; }//2 часть анекдота
        public DbSet<memPictures> memPictures { get; set; }//рандомная картинка
        public DbSet<memText>   memTexts { get; set; }//рандомный текст
        public DbSet<VideoSrc> VideoSrcs { get; set; }//url видео
        public DbSet<Permissions> Permissions { get; set; }//парметры пользователей
        public DbSet<Config> Configs { get; set; }
    }
}

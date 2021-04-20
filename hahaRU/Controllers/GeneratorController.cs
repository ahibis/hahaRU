using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Controllers
{
    public class GeneratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Jokes()
        {
            anecdotGen a = new anecdotGen();
            ViewBag.word = a.word;
            return View();
        }
        public IActionResult Word()
        {
            wordGen a = new wordGen();
            ViewBag.word = a.word;
            return View();
        }
    }
}

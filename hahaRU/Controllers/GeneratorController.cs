using hahaRU.Managers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hahaRU.Controllers
{
    public class GeneratorController : Controller
    {
        private IGeneratorManager _manager;

        public GeneratorController(IGeneratorManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Jokes()
        {
            ViewBag.word = _manager.anecdotGen();
            return View();
        }
        public IActionResult Word()
        {
            wordGen a = new wordGen();
            ViewBag.word = a.word;
            return View();
        }
        public IActionResult YT()
        {
            rngYouTube a = new rngYouTube();
            ViewBag.word = _manager.GetURL();
            return View();
        }
    }
}

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
            return View();
        }
        public IActionResult Word()
        {
            AHAHAHAH a = new AHAHAHAH();
            ViewBag.word = a.word;
            return View();
        }
    }
}

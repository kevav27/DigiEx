using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Pacientes.cshtml");
        }

        public IActionResult Historia()
        {
            return View();
        }

        public IActionResult Pacientes()
        {
            return View();
        }
        public IActionResult Estudio()
        {
            return View();
        }

        public IActionResult Diagnos()
        {
            return View();
        }

        public IActionResult Engreso()
        {
            return View();
        }

        public IActionResult Tratam ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

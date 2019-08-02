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
<<<<<<< HEAD
            return View("Views/Home/LogIn.cshtml");
=======
            //return View("~/Views/Home/Pacientes.cshtml");
>>>>>>> ac0a9ba7ee151292d42a0e9f23070d00147aed17
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
    }
}

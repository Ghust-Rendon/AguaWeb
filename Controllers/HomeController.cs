using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
            int Fernanda;
            int Gus = 12;
            int GusxFernanda;

            DateTime Hoy = DateTime.Today;
            TimeSpan Resta =ProximoCumple - Hoy;
            Fernanda = Resta.Days;
            GusxFernanda = minutos * Gus * Resta.Days; 
    


            ViewBag.Dias = Fernanda;
            ViewBag.Botellas = GusxFernanda;
                /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 
            return View();
        }

    }
}

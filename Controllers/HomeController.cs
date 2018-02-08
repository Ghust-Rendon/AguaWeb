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
            int Ducha; int Litro = 12; int DXL;
            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding
            DateTime Hoy = DateTime.Today;
            TimeSpan Resta =ProximoCumple - Hoy;
            Ducha = Resta.Days;
            DXL = minutos * litro * Resta.Days; 
            ViewBag.Dias = Ducha;
            ViewBag.Botellas = DXL;
                 
            return View();
        }

    }
}

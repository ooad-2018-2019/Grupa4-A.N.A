﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class VozilaPrijavljenController : Controller
    {
        public IActionResult VozilaPrijavljen()
        {
            return View();
        }
        public IActionResult OdjavaOnClick()
        {
            return View("../Prijava/Prijava");
        }
        public IActionResult PretragaOnClick()
        {
            return View("../Pretraga/Pretraga");
        }
        public IActionResult KontakOnClick()
        {
            return View("../KontaktPrijavljen/KontaktPrijavljen");
        }
        public IActionResult UsloviOnClick()
        {
            return View("../UsloviPrijavljen/UsloviPrijavljen");
        }
        public IActionResult PocetnaOnClick()
        {
            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
        }
        public IActionResult RezervisiOnClick()
        {
            return View("../Rezervacija/Rezervacija");
        }
    }
}

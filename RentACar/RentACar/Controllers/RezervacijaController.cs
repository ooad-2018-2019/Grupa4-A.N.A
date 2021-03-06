﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class RezervacijaController : Controller
    {
        public IActionResult Rezervacija()
        {
            return View();
        }

        public IActionResult RezervisiOnClick()
        {
            return View("../Pocetna/Pocetna");
        }
        [HttpPost]
        public IActionResult Validacija(string lokacijaPreuzimanja, string lokacijaVracanja, string datumOD, string datumDO, string imeIPrezime, string datumRodjenja, string brojTelefona)
        {
            if (lokacijaVracanja != null && lokacijaPreuzimanja != null && datumDO != null && datumOD != null && imeIPrezime != null && datumRodjenja != null && brojTelefona != null)
            {
                return View("../NotifikacijaULogujSe/NotifikacijaULogujSe");
            }
            else
            {
                return View("../NotifikacijaRezervacije/NotifikacijaRezervacije");
            }
            //return View("../Registracija/Registracija");
        }
    }
}

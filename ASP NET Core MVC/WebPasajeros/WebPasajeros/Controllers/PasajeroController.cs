using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPasajeros.Data;
using WebPasajeros.Models;

namespace WebPasajeros.Controllers
{
    public class PasajeroController : Controller
    {
        private readonly PasajeroContext  _context;
        public PasajeroController(PasajeroContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Pasajero> pasajeros = _context.Pasajeros.ToList();

            return View("Index", pasajeros);
        }
        public IActionResult Create()
        {
           Pasajero pasajero = new Pasajero();
           return View("Create", pasajero);
        }
        [HttpPost]
        public IActionResult Create(Pasajero pasajero)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", pasajero);
            }
            else
            {
                _context.Pasajeros.Add(pasajero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        [HttpGet("/pasajero/ListaPorNacimiento/{nacimiento}")]
        public IActionResult FiltrarPorFechaNacimiento (DateTime nacimiento)
        {
            List<Pasajero> listAll = _context.Pasajeros.ToList();
            List<Pasajero> list = new List<Pasajero>();

            foreach (Pasajero pasajero in listAll)
            {
                if (pasajero.FechaNacimiento == nacimiento)
                {
                    list.Add(pasajero);
                }
            }
            return View("Index", list);
        }
        [HttpGet("/pasajero/ListaPorCiudad/{city}")]
        // GET: /person/ListaPorCiudad/ciudad
        public IActionResult ListaPorCiudad(string city)
        {
            List<Pasajero> lista = (from p in _context.Pasajeros
                                  where p.Ciudad == city
                                  select p).ToList();
            return View("Index", lista);
        }

    }
}


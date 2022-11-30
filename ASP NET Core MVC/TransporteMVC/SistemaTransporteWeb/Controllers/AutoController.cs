using SistemaTransporteWeb.Data;
using SistemaTransporteWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SistemaTransporteWeb.Controllers
{
    public class AutoController : Controller
    {
        private TransporteContext context = new TransporteContext();

        // GET: Auto
        public ActionResult Index()
        {
            List<Auto> lista = context.Autos.ToList();
            return View("Index", lista);
        }


        //GET : Auto/Create
        public ActionResult Create()
        {
            Auto auto = new Auto();

            return View(auto);
        }

        //POST : /Opera/Create
        [HttpPost]
        public ActionResult Create(Auto auto)
        {
            if (ModelState.IsValid)
            {
                context.Autos.Add(auto);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(auto);
            }
        }

        public ActionResult Details(int id)
        {
            Auto auto = context.Autos.Find(id);

            if (auto == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(auto);
            }
        }

        // GET: /Opera/Delete/id 
        [HttpGet]
        public ActionResult Delete(int id)
        {

            Auto auto = context.Autos.Find(id);

            if (auto == null)
            {
                return HttpNotFound();

            }

            return View("Delete", auto);

        }

        // POST: /Opera/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Auto auto = context.Autos.Find(id);
            if (auto != null)
            {
                context.Autos.Remove(auto);
                context.SaveChanges();
            }

            return RedirectToAction("Index");

        }


    }
}
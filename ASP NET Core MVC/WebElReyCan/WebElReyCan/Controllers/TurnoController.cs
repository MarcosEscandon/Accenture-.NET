using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Controllers
{
    public class TurnoController : Controller
    {

        private TurnoDBContext context = new TurnoDBContext();
        // GET: Turno
        public ActionResult Index()
        {
            List<Turno> list = context.Turnos.ToList();

            return View("Index",list);
        }

        // GET: Turno
        public ActionResult IndexToday()
        {
            /* List<Turno> list = (from a in context.Turnos
                                 where a.FechaIngreso.Date ==  DateTime.Now.Date 
                                 select a).ToList(); 
             LINQ no soporta Date en datetime, por ende no lo podemos usar asi
             */
            List<Turno> listAll = context.Turnos.ToList();
            List<Turno> list = new List<Turno>();

            foreach (Turno turno in listAll)
            {
                if (turno.FechaIngreso.Date == DateTime.Now.Date)
                {
                    list.Add(turno);
                }
            }

            return View("Index", list);
        }

        //GET: Turno/Create
        [HttpGet]
        public ActionResult Create()
        {
            Turno turno = new Turno();
            return View(turno);
        }

        //POST: Turno/Create
        [HttpPost]
        public ActionResult Create(Turno turno)
        {
            if (ModelState.IsValid)
            {
                context.Turnos.Add(turno);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", turno);
            }
        }

        //GET: /Turno/Delete/id
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Turno turno = context.Turnos.Find(id);

            if (turno == null) return HttpNotFound();
            return View("Delete", turno);
        }

        //GET: /Turno/Delete/id
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Turno turno = context.Turnos.Find(id);
            if (turno != null)
            {
                context.Turnos.Remove(turno);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Turno aula = context.Turnos.Find(id);

            if (aula == null) return HttpNotFound();
            return View("Edit", aula);
        }

        //POST: Turno/Edit
        [HttpPost]
        public ActionResult Edit(Turno turno)
        {
            if (ModelState.IsValid)
            {
                context.Entry(turno).State = EntityState.Modified;
                context.SaveChanges();
                return View("index");
            }
            return View("Edit");

        }
    }
}
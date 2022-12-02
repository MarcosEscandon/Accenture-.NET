using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        //Instancia
        private AulaDBContext context = new AulaDBContext();

        //***MUESTRA LISTA DE TODAS LAS AULAS***
        // GET: Aula
        public ActionResult Index()
        {
            List<Aula> lista = context.Aulas.ToList();
            return View("Index", lista);
        }


        //***CREA UN AULA***
        //GET: Aula/Create
        public ActionResult Create()
        {
            Aula aula = new Aula();
            return View("Register", aula);
        }

        [HttpPost]
        //POST: Aula/Create
        public ActionResult Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");

        }

        //***BUSCA AULA POR ID***
        //GET: Aula/id
        public ActionResult Detail(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                HttpNotFound();
            }
            return View("Detail", aula);

        }

        //***EDITA UN AULA***
        //GET:Aula/Edit/id
        public ActionResult Edit(int id)
        {

            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                HttpNotFound();

            }
            return View("Edit", aula);

        }
        //POST : Aula/Edit/id
        [HttpPost]
        public ActionResult EditConfirmed(int id)
        {
            Aula aula = context.Aulas.Find(id);

            context.Entry(aula).State = EntityState.Modified;
            context.SaveChanges();
            return View("Modificar", aula);

        }

        //***BUSCA AULA POR ESTADO*** 
        public ActionResult ListarPorEstado(string estado)
        {
            List<Aula> aulaEstado = (from e in context.Aulas where estado == e.Estado select e).ToList();
            return View("Index", aulaEstado);

        }

        //***BUSCA AULA POR NUMERO***
        public ActionResult TraerPorNumero(int num)
        {    
            dynamic aulaNum = (from a in context.Aulas where num == a.Numero select a).ToList();
            return View("Detail", aulaNum);
        }

    }
}
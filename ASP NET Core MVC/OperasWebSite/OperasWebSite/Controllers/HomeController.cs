using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperasWebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToString(); // Saludo con la fecha
            return View();
        }

        //filtros de acción en verdad no van en HomeController/
        //Antes de invocar el acción
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // base.OnActionExecuting(filterContext);
            Debug.WriteLine("Antes de invocar el acción - OnActionExecuting");
        }

        //Despúes de invocar el acción
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Despúes de invocar el acción - OnActionExecuted");
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System.Linq;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly EmpleadoContext _context;
        public EmpleadoController(EmpleadoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("Index", _context.Empleados.ToList());
        }

        public IActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View("Create", empleado);
        }

        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", empleado);
            }
            else
            {
                _context.Empleados.Add(empleado);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [ActionName("ListarTitulo")]
        public IActionResult ListarTitulo(string titulo)
        {
            return View("Index", (from p in _context.Empleados where p.Titulo == titulo select p).ToList());
        }

        [HttpGet]
        [ActionName("Detail")]
        public IActionResult Detail(int id)
        {
            Empleado empleado = _context.Empleados.Find(id);

            if (empleado == null)
            {
                return NotFound();
            }

            return View("Detail", empleado);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            Empleado empleado = _context.Empleados.Find(id);

            if (empleado == null)
            {
                return NotFound();

            }

            return View("Delete", empleado);

        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = _context.Empleados.Find(id);

            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", _context.Empleados.ToList());
        }

    }
}

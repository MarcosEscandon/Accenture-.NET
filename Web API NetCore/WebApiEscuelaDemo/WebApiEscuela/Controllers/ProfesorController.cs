using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebApiEscuela.Data;
using WebApiEscuela.Models;

namespace WebApiEscuela.Controllers
{
    // GET /api/Profesor
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        public DBEscuelaAPIContext Context { get; set; }
        public ProfesorController(DBEscuelaAPIContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Profesor> Get()
        {
            //EF 
            List<Profesor> profesores = Context.Profesores.ToList();
            return profesores;
        }

        [HttpGet("{id}")]
        public Profesor Get(int id)
        {
            //EF
            Profesor profesor = Context.Profesores.Find(id);
            return profesor;
        }

        [HttpPost]
        public ActionResult Post(Profesor profesor)
        {
            //EF -- memoria
            Context.Profesores.Add(profesor);

            //EF -- guarda en DB
            Context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Profesor profesor)
        {
            if (id != profesor.Id)
            {
                return BadRequest();
            }

            //EF para modificar la DB
            Context.Entry(profesor).State = EntityState.Modified;
            Context.SaveChanges();

            return Ok();

        }

        [HttpDelete("{id}")]
        public ActionResult<Profesor> Delete(int id)
        {
            //EF
            var profesor = Context.Profesores.Find(id);
            if(profesor == null)
            {
                return NotFound();
            }

            //EF
            Context.Profesores.Remove(profesor);
            Context.SaveChanges();

            return profesor;
        }
    }
}

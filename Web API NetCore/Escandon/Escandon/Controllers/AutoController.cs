using Escandon.Data;
using Escandon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Escandon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        public AutoContext Context { get; set; }    //Generar propiedad con nuestra clase de DATA

        public AutoController(AutoContext context)   //Generar constructor Con nuesta clase de DATA
        {
            this.Context = context;
        }


        [HttpGet]
        public List<Auto> Get()
        {
            //EF
            List<Auto> autos = Context.Autos.ToList(); //trae a los profesores a la list profesores

            return autos; // retornamos la lista 
        }

        //api/auto/modelo
        [HttpGet("modelo/{modelo}")]
        public Auto Get(string modelo)
        {
            var auto = (from a in Context.Autos
                        where a.Modelo == modelo
                        select a).SingleOrDefault();

            return auto;
        }



        [HttpPost]

        public ActionResult Post(Auto auto)
        {
            //USANDO EF-- memoria
            Context.Autos.Add(auto);

            //EF- Guardamos en la base
            Context.SaveChanges();

            return Ok();
        }

        [HttpGet("{id}")]

        public Auto Get(int id)
        {
            //EF
            Auto auto = Context.Autos.Find(id);

            return auto;
        }



        [HttpPut("{id}")]
        public ActionResult Put(int id, Auto auto)
        {
            if (id != auto.Id)
            {
                return BadRequest();
            }

            //EF para modificar

            Context.Entry(auto).State = EntityState.Modified;
            Context.SaveChanges();

            return NoContent(); // 204
        }



        [HttpDelete("{id}")]
        public ActionResult<Auto> Delete(int id)
        {
            //EF
            var auto = Context.Autos.Find(id);

            if (auto == null)
            {
                return NotFound();
            }

            //EF
            Context.Autos.Remove(auto);
            Context.SaveChanges();

            return auto;
        }



        [HttpGet("{Marca}/{Modelo}")]
        public IEnumerable<Auto> Get(string marca, string modelo)
        {
            var autos = (from a in Context.Autos
                         where a.Marca == marca && a.Modelo == modelo
                         select a).ToList();

            return (IEnumerable<Auto>)autos;
        }



        [HttpGet("color/{Color}")]
        public IEnumerable<Auto> GetbyColor(string color)
        {


            var auto = (from a in Context.Autos
                        where a.Color == color
                        select a).ToList();

            return (IEnumerable<Auto>)auto;
        }
    }
}

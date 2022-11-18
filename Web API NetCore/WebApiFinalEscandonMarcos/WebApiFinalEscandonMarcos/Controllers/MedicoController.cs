using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;              
using WebApiFinalEscandonMarcos.Data; 
using WebApiFinalEscandonMarcos.Models; 

namespace WebApiFinalEscandonMarcos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        public HospitalContext Context { get; set; }    //Generar propiedad con nuestra clase de DATA

        public MedicoController(HospitalContext context)   //Generar constructor Con nuesta clase de DATA
        {
            this.Context = context;
        }


        [HttpGet]
        public List<Doctor> Get()
        {
            //EF
            List<Doctor> doctores = Context.Doctores.ToList(); //trae a todos

            return doctores; // retornamos la lista 
        }



        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            //EF
            Doctor doctor = Context.Doctores.Find(id);

            return doctor;
        }


        [HttpPost]
        public ActionResult Post(Doctor doctor)
        {
            //USANDO EF-- memoria
            Context.Doctores.Add(doctor);

            //EF- Guardamos en la base
            Context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Doctor> Delete(int id)
        {
            //EF
            var doctor = Context.Doctores.Find(id);

            if (doctor == null)
            {
                return NotFound();
            }

            //EF
            Context.Doctores.Remove(doctor);
            Context.SaveChanges();

            return doctor;
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Doctor doctor)
        {
            if (id != doctor.Doctor_No)
            {
                return BadRequest();
            }

            //EF para modificar

            Context.Entry(doctor).State = EntityState.Modified;
            Context.SaveChanges();

            return NoContent(); //NOCONTEXT ES EL 204
        }




        [HttpGet("especialidad/{Especialidad}")]
        public IEnumerable<Doctor> GetbyEspecialidad(string especialidad)
        {


            var doctor = (from d in Context.Doctores
                          where d.Especialidad == especialidad
                          select d).ToList();

            return (IEnumerable<Doctor>)doctor;
        }

    }
}

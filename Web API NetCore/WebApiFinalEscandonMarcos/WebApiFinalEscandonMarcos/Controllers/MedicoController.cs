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
        public HospitalContext Context { get; set; }    

        public MedicoController(HospitalContext context)   
        {
            this.Context = context;
        }

        // api/medico
        [HttpGet]
        public List<Doctor> Get()
        {
            //EF
            List<Doctor> doctores = Context.Doctores.ToList(); 

            return doctores;  
        }


        // api/medico/1
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            //EF
            Doctor doctor = Context.Doctores.Find(id);

            return doctor;
        }

        // api/medico/1
        [HttpPost]
        public ActionResult Post(Doctor doctor)
        {
            //USANDO EF en memoria
            Context.Doctores.Add(doctor);

            //EF- Guardamos en la base
            Context.SaveChanges();

            return Ok();
        }

        // api/medico/1
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

        // api/medico/1
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

            return NoContent(); // 204
        }



        // api/medico/especialidad/general
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using WebApiFinalEscandonMarcos.Data;
using WebApiFinalEscandonMarcos.Models;

namespace WebApiFinalEscandonMarcos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        public HospitalContext Context { get; set; }    

        public HospitalController(HospitalContext context)   
        {
            this.Context = context;
        }

        // api/hospital
        [HttpGet]
        public List<Hospital> Get()
        {
            //EF
            List<Hospital> hospitales = Context.hospitales.ToList();

            return hospitales; 
        }

        // api/hospital/1
        [HttpGet("{Num_Cama}")]
        public IEnumerable<Hospital> Get(int num_cama)
        {

            var hospital = (from h in Context.hospitales
                            where h.Num_Cama > num_cama
                            select h).ToList();

            return (IEnumerable<Hospital>)hospital;

        }
    }
}

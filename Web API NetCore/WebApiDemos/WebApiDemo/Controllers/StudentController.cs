using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students()
        {
            List<Student> studentsLocal = new List<Student>()
            {
                new Student(){Id=1 , LastName="Doe" , Name="Jhon"},
                new Student(){Id=2 , LastName="Musk" , Name="Jane"},
                new Student(){Id=3 , LastName="Zuck" , Name="Mark"},
            };

            return studentsLocal;
        }

        // GET: /api/student/
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students();
        }

        // GET: /api/student/id
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            Student student = students().Find(x => x.Id == id);
            return student;
        }
    }

}

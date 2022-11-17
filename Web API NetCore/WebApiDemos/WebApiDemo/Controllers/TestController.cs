using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/<Test>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Test/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value" + id.ToString();
        }

        // POST api/<Test>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Test>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Test>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

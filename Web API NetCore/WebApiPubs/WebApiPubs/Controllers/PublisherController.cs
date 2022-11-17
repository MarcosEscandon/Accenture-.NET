using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using WebApiPubs.Models;
using System.Linq;

namespace WebApiPubs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly PubsContext _context;
        public PublisherController(PubsContext context)
        {
            _context = context;
        }

        // GET /api/Publisher
        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            // LinqtoEntities Todos los publishers
            List<Publisher> publishers =(from p in _context.Publishers select p).ToList();

            return publishers;
        }

        //GET /api/publisher/id
        [HttpGet("{id}")]
        public Publisher Get(string id)
        {
            var publishers=(from p in _context.Publishers where p.PubId == id select p).SingleOrDefault();

            return publishers;
        }

        // GET /api/publisher/city/state
        [HttpGet("{city}/{state}")]
        public IEnumerable<Publisher> Get(string city, string state)
        {
            // Linq para buscar cities y states
            var publishers=(from  p in _context.Publishers where p.City==city && p.State==state select p).ToList();

            return publishers;
        }

        // GET /api/publishers/city/state/country
        [HttpGet("{city}/{state}/{country}")]
        public  dynamic Get(string city, string state, string country)
        {
            dynamic publishers=(from p in _context.Publishers where p.City == city && p.State==state && p.Country==country select new {p.PubName, p.Country});

            return publishers;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPasajeros.Models;

namespace WebPasajeros.Data
{
    public class PasajeroContext:DbContext
    {
        public PasajeroContext(DbContextOptions<PasajeroContext> option) : base(option) { }
        public DbSet<Pasajero> Pasajeros { get; set; }
    }
}

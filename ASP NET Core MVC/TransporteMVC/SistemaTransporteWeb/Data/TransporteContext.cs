using SistemaTransporteWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaTransporteWeb.Data
{
    public class TransporteContext : DbContext
    {
        public TransporteContext() : base("keyTransporteDB") { }

        public DbSet<Auto> Autos { get; set; }
    }
}
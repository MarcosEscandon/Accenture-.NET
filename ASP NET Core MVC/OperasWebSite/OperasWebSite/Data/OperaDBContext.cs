using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OperasWebSite.Models;
namespace OperasWebSite.Data
{
    public class OperaDBContext : DbContext
    {
        public OperaDBContext() : base("keyOperaDB") { }

        public DbSet<Opera> Operas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Data
{
    public class AulaDBContext: DbContext
    {
        public AulaDBContext() : base("keyAulaDB") { }
        public DbSet<Aula> Aulas { set; get; }
    }
}
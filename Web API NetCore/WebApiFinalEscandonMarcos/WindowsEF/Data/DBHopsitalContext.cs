using Microsoft.EntityFrameworkCore;
using WebApiFinalEscandonMarcos.Models;

namespace WebApiFinalEscandonMarcos.Data
{
    public class DBHopsitalContext:DbContext
    {
        public DBHopsitalContext(DbContextOptions<DBHopsitalContext> option) : base(option) { }
        
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Medico> Medicos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using WebApiFinalEscandonMarcos.Models;

namespace WebApiFinalEscandonMarcos.Data
{
    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> option) : base(option) { }
        
        public DbSet<Hospital> hospitales { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
    }
}

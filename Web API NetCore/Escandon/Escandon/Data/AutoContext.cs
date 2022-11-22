using Escandon.Models;
using Microsoft.EntityFrameworkCore;

namespace Escandon.Data
{
    public class AutoContext : DbContext
    {  
        public AutoContext(DbContextOptions<AutoContext> options) : base(options) { }

        public DbSet<Auto> Autos { get; set; }
        
    }
}

using Microsoft.EntityFrameworkCore;
using WebApiEscuela.Models;

namespace WebApiEscuela.Data
{
    public class DBEscuelaAPIContext:DbContext
    {
        // CORE siempre se declara el contructor asi
        public DBEscuelaAPIContext(DbContextOptions<DBEscuelaAPIContext>options):base(options)
        {

        }

        //DBSET
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Especialidad> Especialidads { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
    }
}

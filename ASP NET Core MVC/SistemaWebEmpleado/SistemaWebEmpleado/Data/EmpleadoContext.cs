using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;
using System;

namespace SistemaWebEmpleado.Data
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext(DbContextOptions<EmpleadoContext> options)
            : base(options)
        { }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().HasData(
               new Empleado
               {
                   Id = 1,
                   Nombre = "Tara",
                   Apellido = "Brewer",
                   DNI = 12345678,
                   Legajo = "AA12345",
                   Titulo = "IT"
               },
               new Empleado
               {
                   Id = 2,
                   Nombre = "Andrew",
                   Apellido = "Tippett",
                   DNI = 87654321,
                   Legajo = "AA54321",
                   Titulo = "DEVOPS"
               });
        }
    }
}



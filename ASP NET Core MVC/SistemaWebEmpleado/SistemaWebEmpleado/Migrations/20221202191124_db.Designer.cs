﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaWebEmpleado.Data;

namespace SistemaWebEmpleado.Migrations
{
    [DbContext(typeof(EmpleadoContext))]
    [Migration("20221202191124_db")]
    partial class db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaWebEmpleado.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<string>("Legajo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Brewer",
                            DNI = 12345678,
                            Legajo = "AA12345",
                            Nombre = "Tara",
                            Titulo = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Tippett",
                            DNI = 87654321,
                            Legajo = "AA54321",
                            Nombre = "Andrew",
                            Titulo = "DEVOPS"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

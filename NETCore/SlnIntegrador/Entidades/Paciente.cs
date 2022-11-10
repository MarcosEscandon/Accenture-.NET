using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email, string nroHistoriaClinica, DateTime fechaDeNacimiento) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
            FechaDeNacimiento = fechaDeNacimiento;
        }

        public string NroHistoriaClinica { get; set; }

        public DateTime FechaDeNacimiento { get; set; }

        public int Edad
        {
            get { return UtilidadFechas.CalcularEdad(FechaDeNacimiento); }

        }
    }
}

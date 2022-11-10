using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Esta es una clase estática para almacenar todos los métodos auxiliares.
    /// </summary>
    public static class UtilidadFechas
    {
        public static int CalcularEdad(DateTime fechaDeNacimiento)
        {
            int edad = DateTime.Today.Year - fechaDeNacimiento.Year;
            return edad;
        }
    }
}

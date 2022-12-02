using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaWebEmpleado.Validations
{
    public class CheckLegajo : ValidationAttribute
    {
        public CheckLegajo()
        {
            ErrorMessage = "El legajo debe comenzar con AA y luego 5 números.";
        }

        public override bool IsValid(object value)
        {
            string legajo = Convert.ToString(value);

            // Trim
            legajo.Replace(" ", "");

            // Conditions
            if (legajo.Substring(0, 2) == "AA" && int.TryParse(legajo.Replace("AA", ""), out int numLegajo) && legajo.Replace("AA", "").Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

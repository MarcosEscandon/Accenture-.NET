using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaTransporteWeb.Validations
{
    public class CheckValidationYear : ValidationAttribute
    {
        public CheckValidationYear()
        {
            ErrorMessage = "El año minimo es 1998 (inclusive) !";
        }

        public override bool IsValid(object value)
        {
            int year = (int)value;

            if (year >= 1998)
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
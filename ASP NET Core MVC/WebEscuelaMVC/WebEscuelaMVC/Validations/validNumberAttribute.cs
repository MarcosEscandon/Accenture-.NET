using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEscuelaMVC.Validations
{
    public class validNumberAttribute:ValidationAttribute
    {
        public validNumberAttribute()
        {
            ErrorMessage = "El número debe ser mayor a 100";
        }
        public override bool IsValid(object value)
        {
            int num = (int)value; 
            if (num < 100)
            {
                return false;
            }
                return true;
        }
    }
}
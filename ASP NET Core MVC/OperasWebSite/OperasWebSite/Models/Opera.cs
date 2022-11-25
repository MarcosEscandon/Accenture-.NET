using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OperasWebSite.Validations;

namespace OperasWebSite.Models
{
    public class Opera
    {
        public int OperaId { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")] // Mensaje personalizado
        [StringLength(50)]
        public string OperaName { get; set; }

        [Required]
        public string Compositor { get; set; }

        [CheckValidYear]
        public int Year { get; set; }
    }
}
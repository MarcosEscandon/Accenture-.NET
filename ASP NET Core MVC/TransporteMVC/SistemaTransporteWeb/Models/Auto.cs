using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SistemaTransporteWeb.Validations;

namespace SistemaTransporteWeb.Models
{
    [Table("Auto")]
    public class Auto
    {
        public int AutoId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Marca { get; set; }

        [CheckValidationYear]
        public int Anio { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Color { get; set; }
    }
}
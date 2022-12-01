using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebElReyCan.Validations;
namespace WebElReyCan.Models
{
    [Table("Turno")]
    public class Turno
    {
        [Key]
        public int TurnoId { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [Column(TypeName ="datetime")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage ="Campo obligatorio")]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Raza { get; set; }

        [Column(TypeName = "int")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string NombreDueño { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [CheckValidationCellphone]
        public string Celular { get; set; }
    }
}
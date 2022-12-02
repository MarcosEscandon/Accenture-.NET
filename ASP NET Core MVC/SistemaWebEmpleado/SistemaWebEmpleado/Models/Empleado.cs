using SistemaWebEmpleado.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebEmpleado.Models
{
    [Table("Empleados")]
    public class Empleado
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        
        public int DNI { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [CheckLegajo]
        // El legajo siempre comienza con dos letras “AA” y 5 números. Por ejemplo AA12345.
        public string Legajo { get; set; }

        [Required]
        [DisplayName("Título")]
        [Column(TypeName = "varchar(50)")]
        public string Titulo { get; set; }
    }
}

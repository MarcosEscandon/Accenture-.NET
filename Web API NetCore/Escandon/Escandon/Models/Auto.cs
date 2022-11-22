using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escandon.Models
{
    [Table("Vehiculo")]
    public class Auto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]

        public string Marca { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]

        public string Modelo { get; set; }
        [Column(TypeName = "varchar(50)")]

        public string Color { get; set; }
        [Column(TypeName = "varchar(50)")]

        public decimal Precio { get; set; }
    }
}

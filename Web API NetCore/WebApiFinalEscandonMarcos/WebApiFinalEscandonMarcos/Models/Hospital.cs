using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiFinalEscandonMarcos.Models
{
    [Table("Hospital")]
    public class Hospital
    {
        [Key]
        public int Hospital_Cod { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Nombre { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Direccion { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Telefono { get; set; }

        public int? Num_Cama { get; set; }

        public List<Doctor> Doctores { get; set; }
    }
}

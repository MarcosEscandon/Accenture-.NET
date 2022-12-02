using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebPasajeros.Models
{
    public class Pasajero
    {
       
        public int PasajeroId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Ciudad { get; set; }

    }
}


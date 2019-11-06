using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PAPP4.Models
{
    public class Contacto
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public DateTime FechaNac { get; set; }
        [Required]
        public string Observacion { get; set; }
    }
}
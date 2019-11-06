using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PAPP4.Models
{
    public class Usuario
    {
        

        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nombre de usuario")]
        public string User { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }



        [Required(ErrorMessage = "El correo es necesario")]
        [Display(Name = "Correo")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        public virtual ICollection<Libro> Libro { get; set; }
    }
}
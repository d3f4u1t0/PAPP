using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PAPP4.Models
{
    public class Libro { 
       

        public int pag, arbol = 0;
        [Key]
        public int ID { get; set; }
        
        public int IDusuario { get; set; }
        [Required]
        public string NombreLibro { get; set; }

        [Required]
        public string Editorial { get; set; }

        [Required]
        public int NumeroPaginas { get; set; }

        [Required]
        public bool estado { get; set; }

        [Required]
        public int PaginaActual
        {
            get
            {
                return pag;
            }
            set
            {
                pag = value;
            }
        }

        public int Arboles
        {
            get
            {
                arbol = 0;
                for (int i = 0; i < pag; i = i + 100)
                {
                    arbol += 1;
                }
                return arbol;
            }
            set
            {
                arbol = value;
            }
        }

        public virtual Usuario Usuario { get; set; }
    }
}
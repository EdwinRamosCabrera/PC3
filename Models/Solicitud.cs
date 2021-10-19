using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PC3.Models
{
    public class Solicitud
    {
        public int Id {get; set;}
        
        [Required]
        public string NombrePro { get; set; }

        public string Imagen {get; set;}
        
        public string Descripcion {get; set;}
        
        public string Lugar {get; set;}

        [Required]
        public string NombreCom { get; set; }

        public string Celular { get; set; }

        public Double Precio {get; set;}

        public Categoria Categoria {get; set;}

       public DateTime Fecha {get; set;}

        public int? CategoriaId {get; set;}

             public Solicitud()
        {
           Fecha = DateTime.Now;
        }
    }
}
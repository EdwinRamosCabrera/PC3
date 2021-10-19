using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PC3.Models
{
    public class RegistroContext : DbContext
    {
        public RegistroContext(DbContextOptions<RegistroContext> dco) : base(dco){   //Constructor configurable - recibe un objeto configurador y en base a este trabaje / base busca dentro del constructor padre y se lo pasa. 

        }
        public DbSet<Solicitud> SolicitudesCompra { get; set; }  //Aqui tienen que estar la entidades no todas pero si las que requieran en respaldo en la BD

        public DbSet<Categoria> Categorias { get; set; }
    }
}
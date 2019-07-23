using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Articulos> articulos { get; set; }
        public DbSet<EntradaArticulos> entrada { get; set; }

        public DbSet<Ventas> Ventas { get; set; }

        public DbSet<VentasDetalles> VentasDetalles { get; set; }
        public Contexto(): base("ConStr")
        {
            
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class EntradaArticulos
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ArticulosId { get; set; }
        public decimal Cantidad { get; set; }

        public EntradaArticulos()
        {
            EntradaId = 0;
            Fecha = DateTime.Now;
            ArticulosId = 0;
            this.Cantidad = 0;
        }
    }
}

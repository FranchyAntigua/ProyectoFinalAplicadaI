using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 public   class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set; }
        public decimal Inventario { get; set; }


        public Articulos()
        {
            this.ArticuloId = 0;
            this.Nombre = string.Empty;
            this.Descripcion = string.Empty;
            this.Costo = 0;
            this.Ganancia = 0;
            this.Inventario = 0;
            this.Precio = 0;

        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}


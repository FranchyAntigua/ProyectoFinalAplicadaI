using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 public   class Articulo
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public string Medida { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set; }
        public decimal Inventario { get; set; }
        public DateTime Fecha { get; set; }


        public Articulo()
        {
            this.ArticuloId = 0;
            this.Descripcion = string.Empty;
            this.Medida = string.Empty;
            this.Costo = 0;
            this.Ganancia = 0;
            this.Inventario = 0;
            this.Precio = 0;
            this.Fecha = DateTime.Now;

        }
        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}


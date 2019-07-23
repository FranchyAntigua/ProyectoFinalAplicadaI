using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VentasDetalles
    {
        [Key]
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        [ForeignKey("VentaId")]
        public virtual Ventas Venta { get; set; }

        [ForeignKey("ArticuloId")]
        public virtual Articulo Articulo { get; set; }

        public VentasDetalles()
        {
            Id = 0;
            VentaId = 0;
            ArticuloId = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
        }

        public VentasDetalles(int id, int ventaId, int articuloId, string descripcion, int cantidad, decimal precio, decimal importe)
        {
            this.Id = id;
            this.VentaId = ventaId;
            this.ArticuloId = articuloId;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Importe = importe;
        }
    }
}

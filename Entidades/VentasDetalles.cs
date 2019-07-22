using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }


        public VentasDetalles()
        {

        }


        public VentasDetalles(int id, int ventaId, int articuloId, int cantidad, decimal importe)
        {
            this.Id = id;
            this.VentaId = ventaId;
            this.ArticuloId = articuloId;
            this.Cantidad = cantidad;
            this.Importe = importe;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public decimal Itbis { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public virtual List<VentasDetalles> Detalle { get; set; }

        public Ventas()
        {
            this.Detalle = new List<VentasDetalles>();
        }

        public void AgregarDetalle(int Id, int VentaId, int ArticuloId, string Descripcion, int Cantidad, decimal Precio, decimal Importe)
        {
            this.Detalle.Add(new VentasDetalles(Id, VentaId, ArticuloId, Descripcion, Cantidad, Precio, Importe));
        }

        public override string ToString()
        {
            return VentaId.ToString();
        }
    }
}

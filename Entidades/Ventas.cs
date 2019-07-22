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
        public decimal Total { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Clientes Clientes { get; set; }

        public virtual List<VentasDetalles> Detalles { get; set; }

        public Ventas()
        {
            this.Detalles = new List<VentasDetalles>();
        }


    }
}

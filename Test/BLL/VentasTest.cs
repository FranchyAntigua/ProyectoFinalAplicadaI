using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace Test.BLL
{
    [TestClass()]
   public class VentasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioVentas repositorio = new RepositorioVentas();
            bool estado = false;
            Ventas v = new Ventas();
            v.VentaId = 1;
            v.ClienteId = 1;
            v.Itbis = 18;
            v.SubTotal = 200;
            v.Total = 300;
            v.Fecha = DateTime.Now;
            
            v.Detalle.Add(new VentasDetalles(0, 1, 2, "Iphone 8", 50, 200, 700));

            //estado = repositorio.Guardar(v);
            Assert.AreEqual(true, estado);
        }
    }

}

using BLL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BLL
{
    [TestClass]
    public class ArticulosTest
    {
        [TestMethod]
        public void GuardarTest()
        {
            Articulo a = new Articulo();
            a.ArticuloId = 1;
            a.Descripcion = "Iphone";
            a.Costo = 1;
            a.Precio = 1;
            a.Ganancia = 1;
            a.Inventario = 1;
            a.Fecha = DateTime.Now;

            ArticulosBLL<Articulo> articulo = new ArticulosBLL<Articulo>();
            bool estado = false;
            estado = ArticulosBLL.Guardar(a);
            Assert.AreEqual(true, estado);
        }
    }

    internal class ArticulosBLL<T>
    {
    }
}

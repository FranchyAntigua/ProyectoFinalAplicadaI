using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using BLL;

namespace Test.BLL
{
    [TestClass]
    public class ArticuloTest
    {
        [TestMethod]
        public void GuardarTest()
        {
            Articulo a = new Articulo();
            a.ArticuloId= 1;
            a.Descripcion = "Iphone";
            a.Costo = 500;
            a.Precio = 1000;
            a.Ganancia =1000;
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

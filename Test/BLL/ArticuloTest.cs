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
     public class ArticuloTest
    {
        [TestMethod]

        public void GuardarTest()
        {
            Articulo a = new Articulo();
            a.ArticuloId = 1;
            a.Descripcion = "iphone 8";
            a.Medida = "Unidad";
            a.Costo = 10;
            a.Precio = 20;
            a.Ganancia = 10;
            a.Itbis = 18;
            a.Inventario = 1;
            a.Fecha = DateTime.Now;

            ArticulosBLL<Articulo> articulos = new ArticulosBLL<Articulo>();
            bool estado = false;
            estado = ArticulosBLL.Guardar(a);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            ArticulosBLL<Articulo> articulos = new ArticulosBLL<Articulo>();
            bool estado = false;
            Articulo a = ArticulosBLL.Buscar(1);
            a.Descripcion = "airpods";
            estado = ArticulosBLL.Modificar(a);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            ArticulosBLL<Articulo> articulos = new ArticulosBLL<Articulo>();
            Articulo a = ArticulosBLL.Buscar(1);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void GetListTest()
        {
            ArticulosBLL<Articulo> articulos = new ArticulosBLL<Articulo>();
            List<Articulo> lista = new List<Articulo>();
            lista = ArticulosBLL.GetList(c => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            ArticulosBLL<Articulo> articulos = new ArticulosBLL<Articulo>();
            bool estado = false;
            estado = ArticulosBLL.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }

    internal class ArticulosBLL<T>
    {
    }
}

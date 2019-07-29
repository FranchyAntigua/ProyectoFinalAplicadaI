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
    public class EntradaArticulosTest
    {
        [TestMethod]

        public void GuardarTest()
        {
            EntradaArticulos ea = new EntradaArticulos();
            ea.EntradaId = 1;
            ea.ArticuloId = 1;
            ea.Cantidad = 10;
            ea.Fecha = DateTime.Now;

            EntradaArticulosBLL<EntradaArticulos> entradaArticulos = new EntradaArticulosBLL<EntradaArticulos>();
            bool estado = false;
            estado = EntradaArticulosBLL.Guardar(ea);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            EntradaArticulosBLL<EntradaArticulos> entradaArticulos = new EntradaArticulosBLL<EntradaArticulos>();
            bool estado = false;
            EntradaArticulos ea = EntradaArticulosBLL.Buscar(1);
            ea.Cantidad = 12;
            estado = EntradaArticulosBLL.Modificar(ea);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            EntradaArticulosBLL<EntradaArticulos> entradaArticulos = new EntradaArticulosBLL<EntradaArticulos>();
            EntradaArticulos ea = EntradaArticulosBLL.Buscar(1);
            Assert.IsNotNull(ea);
        }

        [TestMethod()]
        public void GetListTest()
        {
            EntradaArticulosBLL<EntradaArticulos> entradaArticulos = new EntradaArticulosBLL<EntradaArticulos>();
            List<EntradaArticulos> lista = new List<EntradaArticulos>();
            lista = EntradaArticulosBLL.GetList(c => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            EntradaArticulosBLL<EntradaArticulos> entradaArticulos = new EntradaArticulosBLL<EntradaArticulos>();
            bool estado = false;
            estado = EntradaArticulosBLL.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
    internal class EntradaArticulosBLL<T>
    {
    }
}

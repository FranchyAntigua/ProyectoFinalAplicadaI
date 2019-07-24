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
      public  class EntradaArticulosTest
    {
        [TestMethod]
        public void GuardarTest()
        {
            EntradaArticulos e = new EntradaArticulos();
            e.EntradaId = 1;
            e.ArticuloId = 1;
            e.Cantidad = 12;
            e.Fecha = DateTime.Now;

            EntradaArticulosBLL<EntradaArticulos> entrada = new EntradaArticulosBLL<EntradaArticulos>();
            bool estado = false;
            estado = EntradaArticulosBLL.Guardar(e);
            Assert.AreEqual(true, estado);
        }
    }
    internal class EntradaArticulosBLL<T>
    {
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using BLL;

namespace Test.BLL
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void GuardarTest()
        {
            Clientes c = new Clientes();
            c.ClienteId = 1;
            c.Nombres = "juan";
            c.Cedula = "40225295571";
            c.Direccion = "Tenares";
            c.Email= "juan@gmail.com";
            c.Celular = "8493561290";
            c.Telefono = "8095878345";
            c.Fecha = DateTime.Now;

            ClientesBLL<Clientes> clientes = new ClientesBLL<Clientes>();
            bool estado = false;
            estado = ClientesBLL.Guardar(c);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            ClientesBLL<Clientes> clientes = new ClientesBLL<Clientes>();
            bool estado = false;
            Clientes c = ClientesBLL.Buscar(1);
            c.Nombres = "pedro";
            estado = ClientesBLL.Modificar(c);
            Assert.AreEqual(true, estado);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            ClientesBLL<Clientes> clientes = new ClientesBLL<Clientes>();
            Clientes c = ClientesBLL.Buscar(1);
            Assert.IsNotNull(c);
        }
        [TestMethod()]
        public void GetListTest()
        {
            ClientesBLL<Clientes> clientes = new ClientesBLL<Clientes>();
            List<Clientes> lista = new List<Clientes>();
            lista = ClientesBLL.GetList(c => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            ClientesBLL<Clientes> clientes = new ClientesBLL<Clientes>();
            bool estado = false;
            estado = ClientesBLL.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }

    internal class ClientesBLL<T>
    {
    }
}

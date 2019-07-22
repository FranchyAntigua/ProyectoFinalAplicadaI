using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using Entidades;

namespace Test.BLL
{
    [TestClass]
    public class UsuariosTest
    {
        [TestMethod()]
        
            public void GuardarTest()
            {
                Usuarios u = new Usuarios();
                u.UsuarioId = 1;
                u.Nombre = "juan";
                u.Email = "juan@gmail.com";
                u.NivelUsuario = 1;
                u.Usuario = "Ju";
                u.Contrasena = "1234";
                u.Confirmar = "1234";
                u.FechaIngreso = DateTime.Now;

                UsuariosBLL<Usuarios> usuarios = new UsuariosBLL<Usuarios>();
                bool estado = false;
                estado = UsuariosBLL.Guardar(u);
                Assert.AreEqual(true, estado);
            }

        [TestMethod()]
        public void ModificarTest()
        {
            UsuariosBLL<Usuarios> usuarios = new UsuariosBLL<Usuarios>();
            bool estado = false;
            Usuarios u = UsuariosBLL.Buscar(1);
            u.Nombre = "pedro";
            estado = UsuariosBLL.Editar(u);
            Assert.AreEqual(true, estado);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            UsuariosBLL<Usuarios> usuarios = new UsuariosBLL<Usuarios>();
            Usuarios u = UsuariosBLL.Buscar(1);
            Assert.IsNotNull(u);
        }
        [TestMethod()]
        public void GetListTest()
        {
            UsuariosBLL<Usuarios> usuarios = new UsuariosBLL<Usuarios>();
            List<Usuarios> lista = new List<Usuarios>();
            lista = UsuariosBLL.GetList(c => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            UsuariosBLL<Usuarios> usuarios = new UsuariosBLL<Usuarios>();
            bool estado = false;
            estado = UsuariosBLL.Eliminar(1);
            Assert.AreEqual(true, estado);
        }
    }
    internal class UsuariosBLL<T>
    {
    }
}

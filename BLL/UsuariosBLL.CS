using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool estado = false;
            Contexto context = new Contexto();
            try
            {


                context.Usuarios.Add(usuario);
                context.SaveChanges();
                estado = true;



            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static bool Editar(Usuarios usuario)
        {
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(usuario).State = EntityState.Modified;

                estado = contexto.SaveChanges() > 0;

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return estado;
        }

        public static bool Eliminar(int id)
        {
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                Usuarios usuario = contexto.Usuarios.Find(id);

                contexto.Usuarios.Remove(usuario);

                if (contexto.SaveChanges() > 0)
                {
                    estado = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }
        public static Usuarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuarios usuarios = new Usuarios();
            try
            {
                usuarios = contexto.Usuarios.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return usuarios;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {
            List<Usuarios> usuario = new List<Usuarios>();
            Contexto contexto = new Contexto();

            try
            {
                usuario = contexto.Usuarios.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return usuario;
        }

        public static List<Usuarios> GetListUsuario(string aux)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Contexto db = new Contexto();
            lista = db.Usuarios.Where(p => p.Usuario == aux).ToList();
            return lista;
        }

        public static List<Usuarios> GetContrasena(string aux)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Contexto db = new Contexto();
            lista = db.Usuarios.Where(p => p.Contrasena == aux).ToList();
            return lista;
        }
    }
}

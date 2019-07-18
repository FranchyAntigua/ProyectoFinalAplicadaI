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
  public  class ClientesBLL
    {
        public static bool Guardar(Clientes clientes)
        {
            bool estado = false;
            try
            {
                Contexto context = new Contexto();
                context.clientes.Add(clientes);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }
        public static bool Modificar(Clientes clientes)
        {
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(clientes).State = EntityState.Modified;
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

        public static bool Eliminar(int id)
        {
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                Clientes clientes = contexto.clientes.Find(id);

                contexto.clientes.Remove(clientes);

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
        public static Clientes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Clientes clientes = new Clientes();
            try
            {
                clientes = contexto.clientes.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return clientes;
        }
        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> expression)
        {
            List<Clientes> clientes = new List<Clientes>();
            Contexto contexto = new Contexto();

            try
            {
                clientes = contexto.clientes.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return clientes;
        }
    }
}
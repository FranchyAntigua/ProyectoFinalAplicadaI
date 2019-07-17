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
  public  class EntradaArticulosBLL
    {
        public static bool Guardar(EntradaArticulos entrada)
        {
            bool estado = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.entrada.Add(entrada) != null)
                {
                    Articulos articulos = BLL.ArticulosBLL.Buscar(entrada.ArticulosId);
                    articulos.Inventario += entrada.Cantidad;
                    BLL.ArticulosBLL.Modificar(articulos);

                    contexto.SaveChanges();

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
                EntradaArticulos entrada = contexto.entrada.Find(id);

                if (entrada != null)
                {
                    Articulos articulos = BLL.ArticulosBLL.Buscar(entrada.ArticulosId);
                    articulos.Inventario -= entrada.Cantidad;
                    BLL.ArticulosBLL.Modificar(articulos);

                    contexto.Entry(entrada).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    estado = true;
                    contexto.Dispose();
                }


            }
            catch (Exception)
            {
                throw;
            }

            return estado;
        }



        public static bool Modificar(EntradaArticulos entrada)
        {

            bool estado = false;
            Contexto contexto = new Contexto();

            try
            {
                EntradaArticulos ant = BLL.EntradaArticulosBLL.Buscar(entrada.EntradaId);
                int resta;
                resta = entrada.Cantidad - ant.Cantidad;

                Articulos productos = BLL.ArticulosBLL.Buscar(entrada.ArticulosId);
                productos.Inventario += resta;
                BLL.ArticulosBLL.Modificar(productos);

                contexto.Entry(entrada).State = EntityState.Modified;

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


        public static EntradaArticulos Buscar(int id)
        {

            EntradaArticulos entrada = new EntradaArticulos();
            Contexto contexto = new Contexto();

            try
            {
                entrada = contexto.entrada.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return entrada;

        }


        public static List<EntradaArticulos> GetList(Expression<Func<EntradaArticulos, bool>> expression)
        {
            List<EntradaArticulos> entrada = new List<EntradaArticulos>();
            Contexto contexto = new Contexto();

            try
            {
                entrada = contexto.entrada.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return entrada;
        }
    }
}

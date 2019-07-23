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
  public  class ArticulosBLL
    {
        public static bool Guardar(Articulo articulos)
        {
            bool estado = false;
            try
            {
                Contexto context = new Contexto();
                context.articulos.Add(articulos);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }
        public static bool Modificar(Articulo articulos)
        {
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
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
                Articulo articulos = contexto.articulos.Find(id);

                contexto.articulos.Remove(articulos);

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
        public static Articulo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulo articulos = new Articulo();
            try
            {
                articulos = contexto.articulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return articulos;
        }
        public static List<Articulo> GetList(Expression<Func<Articulo, bool>> expression)
        {
            List<Articulo> articulos = new List<Articulo>();
            Contexto contexto = new Contexto();

            try
            {
                articulos = contexto.articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return articulos;
        }

        public static decimal CalcularCosto(decimal Ganancia, decimal precio)
        {

            Ganancia /= 100;

            return Convert.ToDecimal(precio) * Convert.ToDecimal(Ganancia);

        }

        public static decimal CalcularGanancia(decimal Costo, decimal Precio)
        {
            decimal p = Precio - Costo;

            return (Convert.ToDecimal(p) / Convert.ToDecimal(Costo)) * 100;

        }

        public static decimal CalcularPrecio(decimal Costo, decimal Ganancia)
        {

            Ganancia /= 100;
            Ganancia *= Costo;
            return Convert.ToDecimal(Costo) + Convert.ToDecimal(Ganancia);
        }

    }
}

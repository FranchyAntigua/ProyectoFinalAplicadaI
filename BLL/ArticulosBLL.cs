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
        public static bool Guardar(Articulos articulos)
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
        public static bool Modificar(Articulos articulos)
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
                Articulos articulos = contexto.articulos.Find(id);

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
        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulos = new Articulos();
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
        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> articulos = new List<Articulos>();
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

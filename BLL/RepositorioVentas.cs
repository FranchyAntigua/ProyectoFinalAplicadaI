using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class RepositorioVentas : Repositorio<Ventas>
    {
        public override bool Guardar(Ventas ventas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ventas.Add(ventas) != null)
                    foreach (var item in ventas.Detalle)
                    {
                        contexto.articulos.Find(item.ArticuloId).Inventario -= item.Cantidad;
                    }

                contexto.clientes.Find(ventas.ClienteId).Deuda += ventas.Total;

                contexto.SaveChanges();
                paso = true;

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public override bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Ventas ventas = contexto.Ventas.Find(id);

                foreach (var item in ventas.Detalle)
                {
                    var EliminInventario = contexto.articulos.Find(item.ArticuloId);
                    EliminInventario.Inventario += item.Cantidad;
                }

                contexto.clientes.Find(ventas.ClienteId).Deuda -= ventas.Total;

                contexto.Ventas.Remove(ventas);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public override Ventas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ventas ventas = new Ventas();
            try
            {
                ventas = contexto.Ventas.Find(id);

                if (ventas != null)
                {
                    ventas.Detalle.Count();

                    foreach (var item in ventas.Detalle)
                    {
                        string s = item.Articulo.Descripcion;
                        string ss = item.Venta.VentaId.ToString();
                    }
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return ventas;
        }

        public override bool Modificar(Ventas entity)
        {
            bool result = false;

            try
            {
                Contexto contexto = new Contexto();

                SqlParameter ventaId = new SqlParameter("@VentaId", entity.VentaId);
                string sql = "DELETE FROM VentasDetalles WHERE VentaId=@VentaId;";

                contexto.Database.ExecuteSqlCommand(sql, ventaId);
                contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                foreach (VentasDetalles vd in entity.Detalle)
                {
                    contexto.Entry(vd).State = System.Data.Entity.EntityState.Added;
                }

                result = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public override List<Ventas> GetList(Expression<Func<Ventas, bool>> expression)
        {
            List<Ventas> list = new List<Ventas>();
            Contexto contexto = new Contexto();
            try
            {
                list = contexto.Ventas.Where(expression).ToList();

                foreach (var item in list)
                {
                    item.Detalle.Count();
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

    }
}

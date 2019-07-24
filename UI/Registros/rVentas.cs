using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicadaI.UI.Registros
{
    public partial class rVentas : Form
    {
        Expression<Func<Ventas, bool>> filtral = x => 1 == 1;

        public rVentas()
        {
            InitializeComponent();
            LlenarComboBox();
        }
        private void LlenarComboBox()
        {
            Repositorio<Clientes> Repositorio = new Repositorio<Clientes>();
            Repositorio<Articulo> RepositorioA = new Repositorio<Articulo>();

            ClienteComboBox.DataSource = Repositorio.GetList(c => true);
            ClienteComboBox.ValueMember = "ClienteId";
            ClienteComboBox.DisplayMember = "Nombres";
            ArticuloComboBox.DataSource = RepositorioA.GetList(c => true);
            ArticuloComboBox.ValueMember = "ArticuloId";
            ArticuloComboBox.DisplayMember = "Descripcion";

            CambiarPrecio();
        }

        private void LlenaCampos(Ventas venta)
        {
            VentaIdNumericUpDown.Value = venta.VentaId;
            ClienteComboBox.SelectedValue = venta.ClienteId;
            FechaDateTimePicker.Value = venta.Fecha;
            SubTotalTextBox.Text = venta.SubTotal.ToString();
            ItbisTextBox.Text = venta.Itbis.ToString();
            TotalTextBox.Text = venta.Total.ToString();

            VentasGridView.DataSource = venta.Detalle;

            VentasGridView.Columns["Id"].Visible = false;
            VentasGridView.Columns["VentaId"].Visible = false;
            VentasGridView.Columns["ArticuloId"].Visible = false;
            VentasGridView.Columns["Articulo"].Visible = false;
            VentasGridView.Columns["Venta"].Visible = false;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private decimal ToDecimal(object valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private Ventas LlenaClase()
        {
            Ventas venta = new Ventas();

            venta.VentaId = Convert.ToInt32(VentaIdNumericUpDown.Value);
            venta.ClienteId = Convert.ToInt32(ClienteComboBox.SelectedValue);
            venta.Fecha = FechaDateTimePicker.Value;
            venta.SubTotal = Convert.ToDecimal(SubTotalTextBox.Text);
            venta.Itbis = Convert.ToDecimal(ItbisTextBox.Text);
            venta.Total = Convert.ToDecimal(TotalTextBox.Text);

            foreach (DataGridViewRow item in VentasGridView.Rows)
            {
                venta.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["VentaId"].Value),
                    ToInt(item.Cells["ArticuloId"].Value),
                    (item.Cells["Descripcion"].Value).ToString(),
                    ToInt(item.Cells["Cantidad"].Value),
                    Convert.ToDecimal(item.Cells["Precio"].Value),
                    Convert.ToDecimal(item.Cells["Importe"].Value)
                );
            }

            VentasGridView.Columns["Id"].Visible = false;
            VentasGridView.Columns["VentaId"].Visible = false;
            VentasGridView.Columns["ArticuloId"].Visible = false;
            VentasGridView.Columns["Articulo"].Visible = false;
            VentasGridView.Columns["Venta"].Visible = false;

            return venta;
        }

        private void Precio()
        {
            Repositorio<Articulo> Repositorio = new Repositorio<Articulo>();
            List<Articulo> ListProductos = Repositorio.GetList(c => c.Descripcion == ArticuloComboBox.Text);
            foreach (var item in ListProductos)
            {
                PrecioTextBox.Text = item.Precio.ToString();
            }
        }

        private void LlenarImporte()
        {
            int cantidad = 0;
            decimal precio = 0;
            decimal resultado = 0;
            cantidad = Convert.ToInt32(CantidadTextBox.Text);
            precio = Convert.ToDecimal(PrecioTextBox.Text);
            resultado = cantidad * precio;
            ImporteTextBox.Text = resultado.ToString();
        }

        private void Aumentar()
        {
            List<VentasDetalles> detalle = new List<VentasDetalles>();

            if (VentasGridView.DataSource != null)
            {
                detalle = (List<VentasDetalles>)VentasGridView.DataSource;
            }
            decimal Total = 0;
            decimal Itbis = 0;
            decimal SubTotal = 0;
            foreach (var item in detalle)
            {
                Total += item.Importe;
            }
            Itbis = Total * 0.18m;
            SubTotal = Total - Itbis;
            SubTotalTextBox.Text = SubTotal.ToString();
            ItbisTextBox.Text = Itbis.ToString();
            TotalTextBox.Text = Total.ToString();
        }

        private void Disminuir()
        {
            List<VentasDetalles> detalle = new List<VentasDetalles>();

            if (VentasGridView.DataSource != null)
            {
                detalle = (List<VentasDetalles>)VentasGridView.DataSource;
            }
            decimal Total = 0;
            decimal Itbis = 0;
            decimal SubTotal = 0;
            foreach (var item in detalle)
            {
                Total -= item.Importe;
            }
            Total *= (-1);
            Itbis = Total * 0.18m;
            SubTotal = Total - Itbis;
            SubTotalTextBox.Text = SubTotal.ToString();
            ItbisTextBox.Text = Itbis.ToString();
            TotalTextBox.Text = Total.ToString();
        }

        private void Limpiar()
        {
            VentaIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            ClienteComboBox.SelectedIndex = 0;
            ArticuloComboBox.SelectedIndex = 0;
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
            ImporteTextBox.Clear();
            VentasGridView.DataSource = null;
            SubTotalTextBox.Clear();
            ItbisTextBox.Clear();
            TotalTextBox.Clear();
            MyErrorProvider.Clear();
        }

        private bool Validar()
        {
            bool estado = false;

            if (VentasGridView.RowCount == 0)
            {
                MyErrorProvider.SetError(VentasGridView,
                    "Debe Agregar");
                estado = true;
            }

            return estado;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            List<VentasDetalles> detalle = new List<VentasDetalles>();
            int cantidad = ToInt(CantidadTextBox.Text);

            if (VentasGridView.DataSource != null)
            {
                detalle = (List<VentasDetalles>)VentasGridView.DataSource;
            }
            else if (cantidad == 0)
            {
                MessageBox.Show("Cantidad no puede ser cero!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            detalle.Add(
                new VentasDetalles(
                   id: 0,
                   ventaId: (int)VentaIdNumericUpDown.Value,
                   articuloId: (int)ArticuloComboBox.SelectedValue,
                   descripcion: ArticuloComboBox.Text,
                   cantidad: ToInt(CantidadTextBox.Text),
                   precio: (decimal)Convert.ToDecimal(PrecioTextBox.Text),
                   importe: (decimal)Convert.ToDecimal(ImporteTextBox.Text)
           ));

            VentasGridView.DataSource = null;
            VentasGridView.DataSource = detalle;
            VentasGridView.Columns["Id"].Visible = false;
            VentasGridView.Columns["VentaId"].Visible = false;
            VentasGridView.Columns["ArticuloId"].Visible = false;
            VentasGridView.Columns["Articulo"].Visible = false;
            VentasGridView.Columns["Venta"].Visible = false;
            Aumentar();

        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (VentasGridView.Rows.Count > 0 && VentasGridView.CurrentRow != null)
            {
                List<VentasDetalles> detalle = (List<VentasDetalles>)VentasGridView.DataSource;

                detalle.RemoveAt(VentasGridView.CurrentRow.Index);

                VentasGridView.DataSource = null;
                VentasGridView.DataSource = detalle;
                Disminuir();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Ventas venta;
            bool Paso = false;
            RepositorioVentas repositorio = new RepositorioVentas();
            if (Validar())
            {
                return;
            }

            venta = LlenaClase();

            if (VentaIdNumericUpDown.Value == 0)
            {
                Paso = repositorio.Guardar(venta);
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(VentaIdNumericUpDown.Value);
                RepositorioVentas repository = new RepositorioVentas();
                Ventas ven = repository.Buscar(id);

                if (ven != null)
                {
                    Paso = repository.Modificar(venta);
                    MessageBox.Show("Modificado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Paso)
            {
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VentaIdNumericUpDown.Value);
            RepositorioVentas repository = new RepositorioVentas();
            Ventas ven = repository.Buscar(id);

            if (ven != null)
            {
                if (repository.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ArticuloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarPrecio();
            //if (CantidadTextBox.Text != "0")
            //{
            //    Repositorio<Articulos> RepositorioA = new Repositorio<Articulos>();

            //    int id = ToInt(ArticuloComboBox.SelectedValue);

            //    Articulos articulos = RepositorioA.Buscar(id);

            //    PrecioTextBox.Text = articulos.Precio.ToString();
            //}
        }

        private void FormatoMoneda(object sender, ConvertEventArgs e)
        {
            decimal valor = 0;
            decimal.TryParse(e.Value.ToString(), out valor);
            e.Value = valor.ToString("#,##.00;(#,##.00);0.00");
        }
        private void CambiarPrecio()
        {
            PrecioTextBox.DataBindings.Clear();
            Binding doBinding = new Binding("Text", ArticuloComboBox.DataSource, "Precio");
            doBinding.Format += new ConvertEventHandler(FormatoMoneda);
            PrecioTextBox.DataBindings.Add(doBinding);
        }
        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
        }

        private void CantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            CambiarPrecio();
            int canti = ToInt(CantidadTextBox.Text);
            decimal pre = ToDecimal(PrecioTextBox.Text);
            ImporteTextBox.Text = (canti * pre).ToString();
        }

        private void PrecioTextBox_TextChanged(object sender, EventArgs e)
        {
            //CambiarPrecio();
            int canti = ToInt(CantidadTextBox.Text);
            decimal pre = ToDecimal(PrecioTextBox.Text);
            ImporteTextBox.Text = (canti * pre).ToString();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VentaIdNumericUpDown.Value);
            RepositorioVentas repositorio = new RepositorioVentas();
            Ventas ventas = repositorio.Buscar(id);

            if (ventas != null)
            {
                LlenaCampos(ventas);
            }
            else
                MessageBox.Show("No se encontró!!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

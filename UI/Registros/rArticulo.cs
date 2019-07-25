using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicadaI.UI.Registros
{
    public partial class rArticulo : Form
    {
        public rArticulo()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool estado = false;

            if (IdnumericUpDown.Value < 0)
            {
                MyErrorProvider.SetError(IdnumericUpDown,
                    "No es un id válido");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MyErrorProvider.SetError(DescripciontextBox,
                    "No puede estar vacio");
                estado = true;
            }

            if (MedidaComboBox.SelectedIndex < 0)
            {
                MyErrorProvider.SetError(IdnumericUpDown,
                    "Debe seleccionar una Medida");
                estado = true;
            }

            if (CostonumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(CostonumericUpDown,
                    "No es un Costo válido");
                estado = true;
            }

            if (PrecionumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(PrecionumericUpDown,
                    "No es un Precio válido");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(InventariotextBox.Text))
            {
                MyErrorProvider.SetError(InventariotextBox,
                    "No puede estar vacio");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(GananciaTextBox.Text))
            {
                MyErrorProvider.SetError(GananciaTextBox,
                    "No puede estar vacio");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(ITBIStextBox.Text))
            {
                MyErrorProvider.SetError(ITBIStextBox,
                    "No puede estar vacio");
                estado = true;
            }

            return estado;
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            CostonumericUpDown.Value = 0;
            InventariotextBox.Clear();
            GananciaTextBox.Clear();
            PrecionumericUpDown.Value = 0;
            InventariotextBox.Text = 0.ToString();
            MyErrorProvider.Clear();
        }

        private Articulo Llenaclase()
        {
            Articulo articulos = new Articulo();

            InventariotextBox.Text = 0.ToString();
            articulos.ArticuloId = Convert.ToInt32(IdnumericUpDown.Value);
            articulos.Descripcion = DescripciontextBox.Text;
            articulos.Medida = MedidaComboBox.Text;
            articulos.Costo = Convert.ToDecimal(CostonumericUpDown.Value);
            articulos.Ganancia = Convert.ToDecimal(GananciaTextBox.Text);
            articulos.Precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            articulos.Inventario = Convert.ToInt32(InventariotextBox.Text);
            articulos.Itbis = Convert.ToDecimal(ITBIStextBox.Text);
            return articulos;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Articulo articulos;
            if (Validar())
            {
                MessageBox.Show("Debe Llenar Todos Los Campos");
                return;
            }
            else
            {
                articulos = Llenaclase();
                if (IdnumericUpDown.Value == 0)
                {
                    paso = BLL.ArticulosBLL.Guardar(articulos);
                }
                else
                {
                    var P = BLL.ArticulosBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));
                    if (P != null)
                    {
                        paso = BLL.ArticulosBLL.Modificar(articulos);
                    }
                }


                Limpiar();
                MyErrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!",
                        "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Se Puede Guardar!",
                        "Intente De Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Articulo articulos = BLL.ArticulosBLL.Buscar(id);

            if (articulos != null)
            {
                IdnumericUpDown.Value = articulos.ArticuloId;
                DescripciontextBox.Text = articulos.Descripcion;
                MedidaComboBox.Text = articulos.Medida;
                CostonumericUpDown.Value = articulos.Costo;
                GananciaTextBox.Text = articulos.Ganancia.ToString();
                PrecionumericUpDown.Value = articulos.Precio;
                InventariotextBox.Text = articulos.Inventario.ToString();
            }
            else
            {
                MessageBox.Show("No Se Puede Encontrado!",
                    "Intente De Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MyErrorProvider.Clear();

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.ArticulosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado!",
                    "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Se Puede Eliminar!",
                    "Intente De Nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MyErrorProvider.Clear();

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void CostonumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GanancianumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            //decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            //decimal ganancia = Convert.ToDecimal(GananciaTextBox.Text);


            //if (CostonumericUpDown.Value != 0 && GananciaTextBox.Text != "0")
            //{

            //    PrecionumericUpDown.Value = BLL.ArticulosBLL.CalcularPrecio(costo, ganancia);
            //    return;
            //}
        }

        private void ITBIStextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PrecionumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            decimal ganancia = 0;

            if (PrecionumericUpDown.Value != 0 && CostonumericUpDown.Value != 0 && CostonumericUpDown.Value < PrecionumericUpDown.Value)
            {
                ganancia = precio - costo;
                GananciaTextBox.Text = ganancia.ToString();
                return;

            }
        }

        private void CostonumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}

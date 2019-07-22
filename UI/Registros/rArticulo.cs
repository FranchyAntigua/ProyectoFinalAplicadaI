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

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(IdnumericUpDown, "Debe Llenar El Id");
                errores = true;
            }
            if (error == 2 && string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                MyErrorProvider.SetError(DescripciontextBox, "Debe Llenar La Descripcion");
                errores = true;
            }

            if (error == 2 && PrecionumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(PrecionumericUpDown, "Debe Llenar El Precio");
                errores = true;
            }


            if (error == 2 && string.IsNullOrEmpty(InventariotextBox.Text))
            {
                MyErrorProvider.SetError(InventariotextBox, "Debe Llenar El Inventario");
                errores = true;
            }

            return errores;

        }
        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            CostonumericUpDown.Value = 0;
            InventariotextBox.Clear();
            GanancianumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            InventariotextBox.Text = 0.ToString();


            MyErrorProvider.Clear();
        }

        private Articulos Llenaclase()
        {
            Articulos articulos = new Articulos();

            InventariotextBox.Text = 0.ToString();
            articulos.ArticuloId = Convert.ToInt32(IdnumericUpDown.Value);
            articulos.Descripcion = DescripciontextBox.Text;
            articulos.Costo = Convert.ToDecimal(CostonumericUpDown.Value);
            articulos.Ganancia = Convert.ToDecimal(GanancianumericUpDown.Value);
            articulos.Precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            articulos.Inventario = Convert.ToInt32(InventariotextBox.Text);

            return articulos;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Articulos articulos = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("Debe Llenar Todos Los Campos");
            }
            else
            {
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
            if (validar(1))
            {
                MessageBox.Show(" Debe Llenar Todos Los Campos");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Articulos articulos = BLL.ArticulosBLL.Buscar(id);

                if (articulos != null)
                {
                    IdnumericUpDown.Value = articulos.ArticuloId;
                    DescripciontextBox.Text = articulos.Descripcion;
                    CostonumericUpDown.Value = articulos.Costo;
                    GanancianumericUpDown.Value = articulos.Ganancia;
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
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Debe Llenar Todos Los Campos");
            }
            else
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
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void CostonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GanancianumericUpDown.Value);

            if (PrecionumericUpDown.Value != 0 && CostonumericUpDown.Value != 0)
            {
                GanancianumericUpDown.Value = BLL.ArticulosBLL.CalcularGanancia(costo, precio);
                return;
            }

            if (CostonumericUpDown.Value != 0 && GanancianumericUpDown.Value != 0 && PrecionumericUpDown.Value == 0)
            {

                PrecionumericUpDown.Value = BLL.ArticulosBLL.CalcularPrecio(costo, ganancia);
                return;
            }
        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GanancianumericUpDown.Value);

            if (PrecionumericUpDown.Value != 0 && CostonumericUpDown.Value != 0 && CostonumericUpDown.Value < PrecionumericUpDown.Value)
            {
                GanancianumericUpDown.Value = BLL.ArticulosBLL.CalcularGanancia(costo, precio);
                return;

            }
        }

        private void GanancianumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GanancianumericUpDown.Value);


            if (CostonumericUpDown.Value != 0 && GanancianumericUpDown.Value != 0)
            {

                PrecionumericUpDown.Value = BLL.ArticulosBLL.CalcularPrecio(costo, ganancia);
                return;
            }
        }

        private void ITBIStextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

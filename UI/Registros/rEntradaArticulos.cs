using BLL;
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
    public partial class rEntradaArticulos : Form
    {
        public rEntradaArticulos()
        {
            InitializeComponent();
        }
        private EntradaArticulos LlenaClase()
        {
            EntradaArticulos Entrada = new EntradaArticulos();

            Entrada.EntradaId = Convert.ToInt32(IdNumericUpDown.Value);
            Entrada.Fecha = FechaDateTimePicker.Value;
            Entrada.ArticulosId = Convert.ToInt32(IdNumericUpDown.Value);
            Entrada.Cantidad = Convert.ToDecimal(CantidadNumericUpDown.Value);

            return Entrada;
        }
        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            ArticulosIdNumericUpDown.Value = 0;
            CantidadNumericUpDown.Value = 0;
            MyErrorProvider.Clear();
        }
        private bool Validar()
        {
            bool estado = false;

            if (IdNumericUpDown.Value < 0)
            {
                MyErrorProvider.SetError(IdNumericUpDown,
                    "No es un id válido");
                estado = true;
            }

            if (IdNumericUpDown.Value < 0)
            {
                MyErrorProvider.SetError(IdNumericUpDown,
                    "No puede estar vacio");
                estado = true;
            }

            if (CantidadNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CantidadNumericUpDown,
                    "Debe Llenar La Cantidad");
                estado = true;
            }

            return estado;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdNumericUpDown.Value);
            EntradaArticulos Entrada = EntradaArticulosBLL.Buscar(id);

            if (Entrada != null)
            {
                FechaDateTimePicker.Value = Entrada.Fecha;
                CantidadNumericUpDown.Value = Entrada.Cantidad;
            }
            else
                MessageBox.Show("No se encontró", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool estado = false;
            EntradaArticulos Entrada = new EntradaArticulos();

            if (Validar())
            {
                MessageBox.Show("Llene los campos correctamente", "Falló",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Entrada = LlenaClase();

                if (Convert.ToInt32(IdNumericUpDown.Value) == 0)
                {
                    estado = EntradaArticulosBLL.Guardar(Entrada);
                    MessageBox.Show("Guardado", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {

                    int id = Convert.ToInt32(IdNumericUpDown.Value);
                    EntradaArticulos entradaArticulos = new EntradaArticulos();
                    entradaArticulos = EntradaArticulosBLL.Buscar(id);

                    if (entradaArticulos != null)
                    {
                        estado = EntradaArticulosBLL.Modificar(LlenaClase());
                        MessageBox.Show("Modificado", "Exito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (estado)
                {
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo guardar", "Falló",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IdNumericUpDown.Value);

            EntradaArticulos Entrada = EntradaArticulosBLL.Buscar(id);

            if (Entrada != null)
            {
                if (EntradaArticulosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }

                else
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

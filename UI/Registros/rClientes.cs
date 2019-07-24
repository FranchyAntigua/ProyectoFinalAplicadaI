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
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        private Clientes LlenaClase()
        {
            Clientes cli = new Clientes();

            cli.ClienteId = Convert.ToInt32(IdnumericUpDown.Value);
            cli.Nombres = NombrestextBox.Text;
            cli.Direccion = DirecciontextBox.Text;
            cli.Email = EmailtextBox.Text;
            cli.Cedula = CedulaMaskedTextBox.Text;
            cli.Celular = CelulartextBox.Text;
            cli.Telefono = TelefonoTextBox.Text;
            cli.Deuda = 0;

            return cli;
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombrestextBox.Clear();
            DirecciontextBox.Clear();
            EmailtextBox.Clear();
            CedulaMaskedTextBox.Clear();
            CelulartextBox.Clear();
            TelefonoTextBox.Clear();
            DeudaTextBox.Text = "0";
            MyErrorProvider.Clear();
        }

        private bool Validar()
        {
            bool estado = false;
            MyErrorProvider.Clear();

            if (IdnumericUpDown.Value < 0)
            {
                MyErrorProvider.SetError(IdnumericUpDown,
                    "No es un id válido");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(NombrestextBox.Text))
            {
                MyErrorProvider.SetError(NombrestextBox,
                    "No puede estar vacio");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                MyErrorProvider.SetError(DirecciontextBox,
                    "No es válido");
                estado = true;
            }

            if (CedulaMaskedTextBox.Text.Length != 13)//sino tiene 13 no es valido
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "No es válido");
                estado = true;
            }

            if (CedulaMaskedTextBox.Text.Contains(" "))//no acepta vacio
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "No Puede Contener Espacio");
                estado = true;
            }


            return estado;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Clientes cli = ClientesBLL.Buscar(id);

            if (cli != null)
            {
                NombrestextBox.Text = cli.Nombres;
                DirecciontextBox.Text = cli.Direccion;
                CedulaMaskedTextBox.Text = cli.Cedula;
                EmailtextBox.Text = cli.Email;
                CelulartextBox.Text = cli.Celular;
                TelefonoTextBox.Text = cli.Telefono;
                DeudaTextBox.Text = cli.Deuda.ToString();
                FechadateTimePicker.Value = cli.Fecha;
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
            Clientes cli = new Clientes();

            if (Validar())
            {
                MessageBox.Show("Llene los campos correctamente", "Falló",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cli = LlenaClase();

                if (Convert.ToInt32(IdnumericUpDown.Value) == 0)
                {
                    estado = ClientesBLL.Guardar(cli);
                    MessageBox.Show("Guardado", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {

                    int id = Convert.ToInt32(IdnumericUpDown.Value);
                    Clientes clientes = new Clientes();
                    clientes = ClientesBLL.Buscar(id);

                    if (clientes != null)
                    {
                        estado = ClientesBLL.Modificar(LlenaClase());
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            Clientes cli = ClientesBLL.Buscar(id);

            if (cli != null)
            {
                if (ClientesBLL.Eliminar(id))
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

        private void CedulaMaskedTextBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Cedula Invalida";
                toolTip1.Show("Ingrese la cedual en el formato de 056-8967547-8", CedulaMaskedTextBox, 0, -20, 5000);
            }

        }

        private void CedulaMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide(CedulaMaskedTextBox);
        }

        private void CedulaMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void CelulartextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}







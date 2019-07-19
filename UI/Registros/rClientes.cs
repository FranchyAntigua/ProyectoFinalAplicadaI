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
            cli.Cedula = CedulaTextBox.Text;
            cli.Celular = CelulartextBox.Text;
            cli.Telefono = TelefonoTextBox.Text;

            return cli;
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombrestextBox.Clear();
            DirecciontextBox.Clear();
            EmailtextBox.Clear();
            CedulaTextBox.Clear();
            CelulartextBox.Clear();
            TelefonoTextBox.Clear();
            MyErrorProvider.Clear();
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
                CedulaTextBox.Text = cli.Cedula;
                EmailtextBox.Text = cli.Email;
                CelulartextBox.Text = cli.Celular;
                TelefonoTextBox.Text = cli.Telefono;
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

        }
    }







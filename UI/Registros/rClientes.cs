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

        public Clientes LlenarClase()
        {
            Clientes clientes = new Clientes();

            clientes.ClienteId = Convert.ToInt32(IdnumericUpDown.Value);
            clientes.Nombres = NombrestextBox.Text;
            clientes.Direccion = DirecciontextBox.Text;
            clientes.Email = EmailtextBox.Text;
            clientes.Cedula = CedulaTextBox.Text;
            clientes.Celular = CelulartextBox.Text;
            clientes.Telefono = TelefonoTextBox.Text;

            return clientes;
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombrestextBox.Clear();
            CedulaTextBox.Clear();
            DirecciontextBox.Clear();
            EmailtextBox.Clear();
            CelulartextBox.Clear();
            TelefonoTextBox.Clear();

        }
        public bool Validar(int error)
        {
            bool estado = false;

            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                IdErrorProvider.SetError(IdnumericUpDown, "Debe Ingresar Un Id");
                estado = true;
            }
            if (error == 2 && NombrestextBox.Text == string.Empty)
            {
                OtroErrorProvider.SetError(NombrestextBox, "Debe Ingresar Un Nombre");
                estado = true;
            }
            if (error == 2 && DirecciontextBox.Text == string.Empty)
            {
                OtroErrorProvider.SetError(DirecciontextBox, "Debe Ingresar Una Direccion");
                estado = true;
            }
            return estado;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            Clientes clientes = ClientesBLL.Buscar((int)IdnumericUpDown.Value);

            if (Validar(2))
            {
                if (clientes == null)
                {
                    if (ClientesBLL.Guardar(LlenarClase()))
                        MessageBox.Show("Guardado Con Exito");
                    else
                        MessageBox.Show("El Cliente No Se Guardo");
                }
                else
                {
                    if (ClientesBLL.Modificar(LlenarClase()))
                        MessageBox.Show("Modificado Con Exito");
                    else
                        MessageBox.Show("El Cliente No Se Modifico");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Clientes clientes = BLL.ClientesBLL.Buscar(id);

            if (clientes != null)
            {

                NombrestextBox.Text = clientes.Nombres;
                DirecciontextBox.Text = clientes.Direccion;
                CedulaTextBox.Text = clientes.Cedula;
                EmailtextBox.Text = clientes.Email;
                CelulartextBox.Text = clientes.Celular;
                TelefonoTextBox.Text = clientes.Telefono;
                FechadateTimePicker.Value = clientes.Fecha;


            }
            else
                MessageBox.Show("No se puede encontrar", "Hay Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.ClientesBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se puede eliminar", "Hay Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //LimpiarProvider();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
 }




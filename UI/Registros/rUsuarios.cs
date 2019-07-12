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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();

            int nivelusu = 0;

            usuario.UsuarioId = Convert.ToInt32(IdNumericUpDown.Value);
            usuario.FechaIngreso = FechaIngresoDateTimePicker.Value;
            usuario.Nombre = NombretextBox.Text;

            if (NivelUsuarioComboBox.SelectedIndex == 0)
                nivelusu = 1;
            else
                nivelusu = 2;

            usuario.Usuario = UsuariotextBox.Text;
            usuario.Contraseña = ContraseñatextBox.Text;
            usuario.Confirmar = ConfirmarTextBox.Text;
            

            return usuario;
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            FechaIngresoDateTimePicker.Value = DateTime.Now;
            NombretextBox.Clear();
            UsuariotextBox.Clear();
            ContraseñatextBox.Clear();
            ConfirmarTextBox.Clear();
            NivelUsuarioComboBox.SelectedIndex = 0;
            MyErrorProvider.Clear();
        }

        private bool Validar()
        {
            bool estado = false;

            string s = ContraseñatextBox.Text;
            string ss = ConfirmarTextBox.Text;
            int comparacion = 0;
            comparacion = String.Compare(s, ss);
            if (comparacion != 0)
            {
                MyErrorProvider.SetError(ContraseñatextBox, "No coinciden");
                MyErrorProvider.SetError(ConfirmarTextBox, "No coinciden");
                estado = true;
            }

            if (IdNumericUpDown.Value < 0)
            {
                MyErrorProvider.SetError(IdNumericUpDown,
                    "No es un id válido");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MyErrorProvider.SetError(Nombre,
                    "No puede estar vacio");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                MyErrorProvider.SetError(UsuariotextBox,
                    "No puede estar vacio");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(ContraseñatextBox.Text))
            {
                MyErrorProvider.SetError(ContraseñatextBox,
                    "No puede estar vacio");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(ConfirmarTextBox.Text))
            {
                MyErrorProvider.SetError(ConfirmarTextBox,
                    "No puede estar vacio");
                estado = true;
            }

            return estado;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdNumericUpDown.Value);
            Usuarios usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                FechaIngresoDateTimePicker.Value = usuario.FechaIngreso;
                NombretextBox.Text = usuario.Usuario;
                UsuariotextBox.Text = usuario.Usuario;
                ContraseñatextBox.Text = usuario.Contraseña;
                ConfirmarTextBox.Text = usuario.Contraseña;
                NivelUsuarioComboBox.Text = usuario.NivelUsuario.ToString();
            }
            else
                MessageBox.Show("No se encontró", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            bool estado = false;
            Usuarios usuario = new Usuarios();

            if (Validar())
            {
                MessageBox.Show("Llene los campos correctamente", "Falló",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                usuario = LlenaClase();

                if (Convert.ToInt32(IdNumericUpDown.Value) == 0)
                {
                    estado = UsuariosBLL.Guardar(usuario);
                    MessageBox.Show("Guardado", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {

                    int id = Convert.ToInt32(IdNumericUpDown.Value);
                    Usuarios usu = new Usuarios();
                    usu = UsuariosBLL.Buscar(id);

                    if (usu != null)
                    {
                        estado = UsuariosBLL.Editar(LlenaClase());
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

            Usuarios usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                if (UsuariosBLL.Eliminar(id))
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

        private void NombretexBox(object sender, KeyPressEventArgs e)
        
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se escribir Letras", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se escribir Letras", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    e.Handled = false;
                }
            }
    }
    }

    
    
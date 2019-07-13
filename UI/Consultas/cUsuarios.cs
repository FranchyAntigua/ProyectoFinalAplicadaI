using BLL;
using Entidades;
using ProyectoFinalAplicadaI.UI.Reportes;
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

namespace ProyectoFinalAplicadaI.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        List<Usuarios> listaUsuarios = new List<Usuarios>();
        public cUsuarios()
        {
            InitializeComponent();
            CriterioTextBox.ReadOnly = true;
            FiltroComboBox.SelectedIndex = 0;
        }
         Expression<Func<Usuarios, bool>> filtro = a => true;
        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
           
            int id;
            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.ReadOnly = false;
                if (String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    MyErrorProvider.SetError(CriterioTextBox, "No puede estar vacio");
                    return;
                }
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo.
                        break;
                    case 1://Filtrando por ID 
                        id = Convert.ToInt32(CriterioTextBox.Text);
                        filtro = a => a.UsuarioId == id;
                        break;
                }

            }

            listaUsuarios = UsuariosBLL.GetList(filtro);
            UsuariosConsultaDataGridView.DataSource = listaUsuarios;
        }

        private void ImprimirButton_Click_1(object sender, EventArgs e)
        {
            if (listaUsuarios.Count == 0)
            {
                MessageBox.Show("No Hay Datos", "Reporte Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                rReporteUsuario rReporte = new rReporteUsuario(UsuariosBLL.GetList(filtro));
                rReporte.Visualizar("CrpUsuarios");
            }
        }

        private void FiltroComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.ReadOnly = false;
            }
        }
        private void CriterioTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = true;
                MessageBox.Show("Solo se puede digitar Números", "Falló",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se escribir Letras", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede digitar Números", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     }
   }


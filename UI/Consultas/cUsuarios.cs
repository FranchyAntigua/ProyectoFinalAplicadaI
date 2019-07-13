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
            FiltroComboBox.SelectedIndex = 0;
        }
         Expression<Func<Usuarios, bool>> filtro = a => true;
        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
           
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID 
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = a => a.UsuarioId == id;
                    break;

            }

            listaUsuarios = UsuariosBLL.GetList(filtro);
            UsuariosConsultaDataGridView.DataSource = listaUsuarios;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (listaUsuarios.Count == 0)
            {
                MessageBox.Show("No Hay Datos", "Reporte Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                rReporteUsuario rReporte = new rReporteUsuario(UsuariosBLL.GetList(filtro));
                rReporte.Show();
            }


        }
    }
}

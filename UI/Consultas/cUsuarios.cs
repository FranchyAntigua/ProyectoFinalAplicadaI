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

        public cUsuarios()
        {
            InitializeComponent();
            CriterioTextBox.ReadOnly = true;
            FiltroComboBox.SelectedIndex = 0;
        }

        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);

            return retorno;
        }

        private List<Usuarios> Buscar()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            Expression<Func<Usuarios, bool>> filtro = f => true;
            int id = Convert.ToInt32(FiltroComboBox.SelectedIndex);

            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.ReadOnly = false;
                if (String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    MyErrorProvider.SetError(CriterioTextBox, "No puede estar vacio");

                }

                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo.
                        break;
                    case 1://UsuarioId.
                        id = ToInt(CriterioTextBox.Text);
                        filtro = f => f.UsuarioId == id;
                        break;
                    case 2://FechaIngreso.
                        filtro = f => f.FechaIngreso >= FechaDesdeDateTimePicker.Value.Date && f.FechaIngreso <= FechaHastaDateTimePicker.Value.Date;
                        break;
                    case 3://Usuario.
                        filtro = f => f.Usuario.ToString().Contains(CriterioTextBox.Text);
                        break;
                    case 4://Nombre.
                        filtro = f => f.Nombre.ToString().Contains(CriterioTextBox.Text) && f.FechaIngreso >= FechaDesdeDateTimePicker.Value.Date && f.FechaIngreso <= FechaHastaDateTimePicker.Value.Date;
                        break;
                }

            }

            listaUsuarios = UsuariosBLL.GetList(filtro);

            UsuariosConsultaDataGridView.DataSource = listaUsuarios;
            UsuariosConsultaDataGridView.Columns["Contrasena"].Visible = false;
            UsuariosConsultaDataGridView.Columns["Confirmar"].Visible = false;


            return listaUsuarios;
        }



        private void ButtonBuscar_Click(object sender, EventArgs e)
        {

            if (RangoFechaCheckBox.Checked == true)
                UsuariosConsultaDataGridView.DataSource = BuscarRangoFecha();
            else
                UsuariosConsultaDataGridView.DataSource = Buscar();
        }
        private List<Usuarios> BuscarRangoFecha()
        {
            List<Usuarios> lista = new List<Usuarios>();
            Expression<Func<Usuarios, bool>> filtro = f => true;
            int id = Convert.ToInt32(FiltroComboBox.SelectedIndex);
            if (FiltroComboBox.SelectedIndex != 0 && FiltroComboBox.SelectedIndex != 2)
            {
                CriterioTextBox.ReadOnly = false;
                if (String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    MyErrorProvider.SetError(CriterioTextBox, "No puede estar vacio");
                }
            }
            switch (id)
            {
                case 0://Todo.
                    filtro = f => f.FechaIngreso >= FechaDesdeDateTimePicker.Value.Date && f.FechaIngreso <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 1://UsuarioId.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = f => f.UsuarioId == id && (f.FechaIngreso >= FechaDesdeDateTimePicker.Value.Date && f.FechaIngreso <= FechaHastaDateTimePicker.Value.Date);
                    break;
                case 2://Fecha.
                    filtro = f => f.FechaIngreso >= FechaDesdeDateTimePicker.Value.Date && f.FechaIngreso <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 3://Nombres.
                    filtro = f => f.Nombre.ToString().Contains(CriterioTextBox.Text) && f.FechaIngreso >= FechaDesdeDateTimePicker.Value.Date && f.FechaIngreso <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 4://Usuario.
                    filtro = f => f.Usuario.ToString().Contains(CriterioTextBox.Text) && (f.FechaIngreso >= FechaDesdeDateTimePicker.Value.Date && f.FechaIngreso <= FechaHastaDateTimePicker.Value.Date);
                    break;
            }
            lista = UsuariosBLL.GetList(filtro);
            return lista;
        }

        //private void ImprimirButton_Click_1(object sender, EventArgs e)
        //{
        //    if (listaUsuarios.Count == 0)
        //    {
        //        MessageBox.Show("No Hay Datos", "Reporte Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    else
        //    {
        //        rReporteUsuario rReporte = new rReporteUsuario(UsuariosBLL.GetList(filtro));
        //        rReporte.Visualizar("CrpUsuarios");
        //    }
        //}
        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.ReadOnly = false;
            }
        }


        private void CriterioTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (FiltroComboBox.SelectedIndex == 1)
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

        private void CriterioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CriterioTextBox.Text != "")
            {
                MyErrorProvider.Clear();
            }
        }
    }
}



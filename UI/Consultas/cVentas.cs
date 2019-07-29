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
    public partial class cVentas : Form
    {
        private List<Ventas> lista = new List<Ventas>();
        Expression<Func<Ventas, bool>> filtro = f => true;
        Repositorio repositorio = new Repositorio();
        public cVentas()
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
        private List<Ventas> Buscar()
        {
            List<Ventas> lista = new List<Ventas>();
            Expression<Func<Ventas, bool>> filtro = f => true;
            int id = Convert.ToInt32(FiltroComboBox.SelectedIndex);
            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.ReadOnly = false;
                if (String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    MyErrorProvider.SetError(CriterioTextBox, "No puede estar vacio");
                }
            }

            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Todo.
                    break;
                case 1://VentaId.
                    id = ToInt(CriterioTextBox.Text);
                    filtro = f => f.VentaId == id;
                    break;
                case 2://Fecha.
                    filtro = f => f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha<= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 3://ClienteId.
                    id = ToInt(CriterioTextBox.Text);
                    filtro = f => f.ClienteId == id;
                    break;
            }

            lista = repositorio.GetList(filtro);
            return lista;
        }

        private List<Ventas> BuscarRangoFecha()
        {
            List<Ventas> lista = new List<Ventas>();
            Expression<Func<Ventas, bool>> filtro = f => true;
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
                    filtro = f => f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 1://VentaId.
                    id = utility.ToInt(CriterioTextBox.Text);
                    filtro = f => f.VentaId == id && (f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date);
                    break;
                case 2://Fecha.
                    filtro = f => f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 3://ClienteId.
                    filtro = f => f.ClienteId.ToString().Contains(CriterioTextBox.Text) && f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date;
                    break;
            }
            lista = repositorio.GetList(filtro);
            return lista;
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.ReadOnly = false;
            }
        }

        private void CriterioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CriterioTextBox.Text != "")
            {
                MyErrorProvider.Clear();
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {

            if (lista.Count == 0)
            {
                MessageBox.Show("No Hay Datos", "Reporte Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                rReporteVentas rReporte = new rReporteVentas()
                {

                    listaVentas = lista
                };
                rReporte.Visualizar("CrpVentas");
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {

            if (RangoFechaCheckBox.Checked == true)
            {
                lista = BuscarRangoFecha();
                ConsultaDataGridView.DataSource = lista;
            }
            else
            {
                lista = Buscar();
                ConsultaDataGridView.DataSource = lista;
            }
        }
    }
}
    
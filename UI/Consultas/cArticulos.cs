using BLL;
using Entidades;
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
    public partial class cArticulos : Form
    {
        public cArticulos()
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
        private List<Articulos> Buscar()
        {
            List<Articulos> lista = new List<Articulos>();
            Expression<Func<Articulos, bool>> filtro = f => true;
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
                case 1://ArticulosId.
                    id = ToInt(CriterioTextBox.Text);
                    filtro = f => f.ArticuloId == id;
                    break;
                case 2://Costo.
                    filtro = f => f.Costo.ToString().Contains(CriterioTextBox.Text);
                    break;
                case 3://ArticulosId.
                    filtro = f => f.ArticuloId.ToString().Contains(CriterioTextBox.Text);
                    break;
                case 4://Precio.
                    filtro = f => f.Precio.ToString().Contains(CriterioTextBox.Text);
                    break;
            }

            lista = ArticulosBLL.GetList(filtro);
            return lista;
        }

        private List<Articulos> BuscarRangoFecha()
        {
            List<Articulos> lista = new List<Articulos>();
            Expression<Func<Articulos, bool>> filtro = f => true;
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
                case 1://ArticuloId.
                    id = ToInt(CriterioTextBox.Text);
                    filtro = f => f.ArticuloId == id && (f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date);
                    break;
                case 2://Fecha.
                    filtro = f => f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 3://Costo.
                    filtro = f => f.Costo.ToString().Contains(CriterioTextBox.Text) && f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 4://Precio.
                    filtro = f => f.Precio.ToString().Contains(CriterioTextBox.Text) && (f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date);
                    break;
            }
            lista = ArticulosBLL.GetList(filtro);
            return lista;
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.ReadOnly = false;
            }
        }

        private void CriterioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CriterioTextBox.Text != "")
            {
                MyErrorProvider.Clear();
            }
        }

        private void CriterioTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (RangoFechaCheckBox.Checked == true)
                ConsultaDataGridView.DataSource = BuscarRangoFecha();
            else
                ConsultaDataGridView.DataSource = Buscar();
        }
    }
}

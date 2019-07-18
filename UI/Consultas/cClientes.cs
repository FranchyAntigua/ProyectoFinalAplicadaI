﻿using BLL;
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
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }

        private List<Clientes> Buscar()
        {
            List<Clientes> lista = new List<Clientes>();
            Expression<Func<Clientes, bool>> filtro = f => true;
            int id = Convert.ToInt32(FiltroComboBox.SelectedIndex);
            if (FiltroComboBox.SelectedIndex == 1)
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
                    break;
                case 1://ClienteId.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = f => f.ClienteId == id;
                    break;
                case 2://Fecha.
                    filtro = f => f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 3://Nombres.
                    filtro = f => f.Nombres.ToString().Contains(CriterioTextBox.Text);
                    break;
                case 4://Cedula.
                    filtro = f => f.Cedula.ToString().Contains(CriterioTextBox.Text);
                    break;
            }

            lista = ClientesBLL.GetList(filtro);
            return lista;
        }

        private List<Clientes> BuscarRangoFecha()
        {
            List<Clientes> lista = new List<Clientes>();
            Expression<Func<Clientes, bool>> filtro = f => true;
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
                case 1://ClienteId.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = f => f.ClienteId == id && (f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date);
                    break;
                case 2://Fecha.
                    filtro = f => f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 3://Nombres.
                    filtro = f => f.Nombres.ToString().Contains(CriterioTextBox.Text) && f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date;
                    break;
                case 4://Cedula.
                    filtro = f => f.Cedula.ToString().Contains(CriterioTextBox.Text) && (f.Fecha >= FechaDesdeDateTimePicker.Value.Date && f.Fecha <= FechaHastaDateTimePicker.Value.Date);
                    break;
            }
            lista = ClientesBLL.GetList(filtro);
            return lista;
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (FiltroComboBox.SelectedIndex == 2)
            {
                CriterioTextBox.ReadOnly = true;
            }
            else
            {
                CriterioTextBox.ReadOnly = false;
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (RangoFechaCheckBox.Checked == true)
                ConsultaDataGridView.DataSource = BuscarRangoFecha();
            else
                ConsultaDataGridView.DataSource = Buscar();
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

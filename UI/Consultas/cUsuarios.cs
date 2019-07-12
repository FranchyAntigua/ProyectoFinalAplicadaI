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
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
            CriterioTextBox.ReadOnly = true;
            FiltroComboBox.SelectedIndex = 0;
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtro = a => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID 
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = a => a.UsuarioId == id;
                    break;

            }

            UsuariosConsultaDataGridView.DataSource = UsuariosBLL.GetList(filtro);
        }
    }
    }

using ProyectoFinalAplicadaI.UI.Consultas;
using ProyectoFinalAplicadaI.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAplicadaI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios rus = new rUsuarios()
            {
                MdiParent = this
            };
                
                
                rus.Show();
        }

        private void ConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cUsuarios().ShowDialog();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes rus = new rClientes()
            {
                MdiParent = this
            };

            rus.Show();
        }

        private void ArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos rus = new rArticulos()
            {
                MdiParent = this
            };

            rus.Show();
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cClientes rus = new cClientes()
            {
                MdiParent = this
            };

            rus.Show();
        }

        private void ArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
             cArticulos rus = new cArticulos()
            {
                MdiParent = this
            };

            rus.Show();
        }

        private void EntradaArticulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEntradaArticulos rus = new cEntradaArticulos()
            {
                MdiParent = this
            };

            rus.Show();
        }

        private void EntradaArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEntradaArticulos rus = new rEntradaArticulos()
            {
                MdiParent = this
            };

            rus.Show();
        }
    }
}

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
            new rUsuarios ().ShowDialog();
        }

        private void ConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new cUsuarios().ShowDialog();
        }
    }
}

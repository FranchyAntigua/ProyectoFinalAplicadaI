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

namespace ProyectoFinalAplicadaI.UI.Reportes
{
    public partial class rReporteUsuario : Form
    {
        List<Usuarios> listaUsuarios = new List<Usuarios>();

        public rReporteUsuario(List<Usuarios>  datos)
        {
            this.listaUsuarios = datos;
            InitializeComponent();
           
        }

        private void UsuarioCrystalReportViewer_Load(object sender, EventArgs e)
        {
            CrpUsuarios crpUsuarios = new CrpUsuarios();
            crpUsuarios.SetDataSource(listaUsuarios);

            UsuarioCrystalReportViewer.ReportSource = crpUsuarios;
            UsuarioCrystalReportViewer.Refresh();

        }
    }
}

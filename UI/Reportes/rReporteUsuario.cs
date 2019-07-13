using CrystalDecisions.CrystalReports.Engine;
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
        string rutaReportes = @"C:\Users\user\source\repos\ProyectoFinalAplicadaI\UI\Reportes\";

        public rReporteUsuario(List<Usuarios>  datos)
        {
            this.listaUsuarios = datos;
            InitializeComponent();
           
        }

        private void UsuarioCrystalReportViewer_Load(object sender, EventArgs e)
        {

        }

        public void Visualizar(string reporte)
        {
            ReportDocument report = new ReportDocument();
            report.Load($"{rutaReportes}{reporte}.rpt");

            report.SetDataSource(listaUsuarios);
            UsuarioCrystalReportViewer.ReportSource = report;
            UsuarioCrystalReportViewer.Refresh();

            ShowDialog();
        }
    }
}

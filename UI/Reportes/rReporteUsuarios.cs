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
    public partial class rReporteUsuarios : Form
    {
        public List<Usuarios> listaUsuarios { get; set; }
        string rutaReportes = @"C:\Users\user\source\repos\ProyectoFinalAplicadaI\UI\Reportes\";
        public rReporteUsuarios()
        {
            InitializeComponent();
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

namespace ProyectoFinalAplicadaI.UI.Reportes
{
    partial class rReporteVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VentasCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VentasCrystalReportViewer
            // 
            this.VentasCrystalReportViewer.ActiveViewIndex = -1;
            this.VentasCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VentasCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VentasCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentasCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VentasCrystalReportViewer.Name = "VentasCrystalReportViewer";
            this.VentasCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.VentasCrystalReportViewer.TabIndex = 2;
            // 
            // rReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VentasCrystalReportViewer);
            this.Name = "rReporteVentas";
            this.Text = "rReporteVentas";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VentasCrystalReportViewer;
    }
}
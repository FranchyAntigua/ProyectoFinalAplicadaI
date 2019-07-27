namespace ProyectoFinalAplicadaI.UI.Reportes
{
    partial class rReporteClientes
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
            this.ClienteCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ClienteCrystalReportViewer
            // 
            this.ClienteCrystalReportViewer.ActiveViewIndex = -1;
            this.ClienteCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClienteCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClienteCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClienteCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ClienteCrystalReportViewer.Name = "ClienteCrystalReportViewer";
            this.ClienteCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ClienteCrystalReportViewer.TabIndex = 1;
            this.ClienteCrystalReportViewer.Load += new System.EventHandler(this.ClienteCrystalReportViewer_Load);
            // 
            // rReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClienteCrystalReportViewer);
            this.Name = "rReporteClientes";
            this.Text = "rReporteClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ClienteCrystalReportViewer;
    }
}
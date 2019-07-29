namespace ProyectoFinalAplicadaI.UI.Reportes
{
    partial class rReporteUsuarios
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
            this.UsuarioCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // UsuarioCrystalReportViewer
            // 
            this.UsuarioCrystalReportViewer.ActiveViewIndex = -1;
            this.UsuarioCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuarioCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsuarioCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuarioCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.UsuarioCrystalReportViewer.Name = "UsuarioCrystalReportViewer";
            this.UsuarioCrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.UsuarioCrystalReportViewer.TabIndex = 2;
            // 
            // rReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsuarioCrystalReportViewer);
            this.Name = "rReporteUsuario";
            this.Text = "rReporteUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer UsuarioCrystalReportViewer;
    }
}
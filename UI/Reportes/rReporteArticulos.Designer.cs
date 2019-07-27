namespace ProyectoFinalAplicadaI.UI.Reportes
{
    partial class rReporteArticulos
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
            this.ArticuloCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ArticuloCrystalReportViewer
            // 
            this.ArticuloCrystalReportViewer.ActiveViewIndex = -1;
            this.ArticuloCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArticuloCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ArticuloCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticuloCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ArticuloCrystalReportViewer.Name = "ArticuloCrystalReportViewer";
            this.ArticuloCrystalReportViewer.Size = new System.Drawing.Size(967, 542);
            this.ArticuloCrystalReportViewer.TabIndex = 0;
            // 
            // rReporteArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 542);
            this.Controls.Add(this.ArticuloCrystalReportViewer);
            this.Name = "rReporteArticulos";
            this.Text = "rReporteArticulos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ArticuloCrystalReportViewer;
    }
}
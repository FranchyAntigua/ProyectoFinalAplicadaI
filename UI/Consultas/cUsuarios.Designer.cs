namespace ProyectoFinalAplicadaI.UI.Consultas
{
    partial class cUsuarios
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
            this.UsuariosConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosConsultaDataGridView
            // 
            this.UsuariosConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosConsultaDataGridView.Location = new System.Drawing.Point(12, 34);
            this.UsuariosConsultaDataGridView.Name = "UsuariosConsultaDataGridView";
            this.UsuariosConsultaDataGridView.Size = new System.Drawing.Size(414, 209);
            this.UsuariosConsultaDataGridView.TabIndex = 28;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBuscar.Location = new System.Drawing.Point(432, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(88, 43);
            this.buttonBuscar.TabIndex = 27;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(241, 8);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(114, 20);
            this.CriterioTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Id"});
            this.FiltroComboBox.Location = new System.Drawing.Point(57, 5);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(119, 21);
            this.FiltroComboBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Filtro";
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsuariosConsultaDataGridView);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label1);
            this.Name = "cUsuarios";
            this.Text = "cUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsuariosConsultaDataGridView;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
    }
}
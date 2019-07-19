namespace ProyectoFinalAplicadaI.UI.Consultas
{
    partial class cClientes
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
            this.components = new System.ComponentModel.Container();
            this.RangoFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaHastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaDesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RangoFechaCheckBox
            // 
            this.RangoFechaCheckBox.AutoSize = true;
            this.RangoFechaCheckBox.ForeColor = System.Drawing.Color.Black;
            this.RangoFechaCheckBox.Location = new System.Drawing.Point(500, 58);
            this.RangoFechaCheckBox.Name = "RangoFechaCheckBox";
            this.RangoFechaCheckBox.Size = new System.Drawing.Size(106, 17);
            this.RangoFechaCheckBox.TabIndex = 69;
            this.RangoFechaCheckBox.Text = "Rango de Fecha";
            this.RangoFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FechaHastaDateTimePicker
            // 
            this.FechaHastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaHastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaHastaDateTimePicker.Location = new System.Drawing.Point(500, 32);
            this.FechaHastaDateTimePicker.Name = "FechaHastaDateTimePicker";
            this.FechaHastaDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.FechaHastaDateTimePicker.TabIndex = 68;
            // 
            // FechaDesdeDateTimePicker
            // 
            this.FechaDesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDesdeDateTimePicker.Location = new System.Drawing.Point(500, 10);
            this.FechaDesdeDateTimePicker.Name = "FechaDesdeDateTimePicker";
            this.FechaDesdeDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.FechaDesdeDateTimePicker.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(462, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(462, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Hasta";
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(12, 46);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(447, 209);
            this.ConsultaDataGridView.TabIndex = 63;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(241, 14);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(114, 20);
            this.CriterioTextBox.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id"});
            this.FiltroComboBox.Location = new System.Drawing.Point(53, 13);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(119, 21);
            this.FiltroComboBox.TabIndex = 59;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Filtro";
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImprimirButton.Image = global::ProyectoFinalAplicadaI.Properties.Resources.Printer_32x32;
            this.ImprimirButton.Location = new System.Drawing.Point(465, 218);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(70, 37);
            this.ImprimirButton.TabIndex = 64;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBuscar.Image = global::ProyectoFinalAplicadaI.Properties.Resources.icons8_búsqueda_24;
            this.buttonBuscar.Location = new System.Drawing.Point(371, 5);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(88, 35);
            this.buttonBuscar.TabIndex = 62;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // cClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 260);
            this.Controls.Add(this.RangoFechaCheckBox);
            this.Controls.Add(this.FechaHastaDateTimePicker);
            this.Controls.Add(this.FechaDesdeDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label1);
            this.Name = "cClientes";
            this.Text = "cClientes";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RangoFechaCheckBox;
        private System.Windows.Forms.DateTimePicker FechaHastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaDesdeDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}
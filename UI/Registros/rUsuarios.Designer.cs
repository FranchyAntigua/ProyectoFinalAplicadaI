namespace ProyectoFinalAplicadaI.UI.Registros
{
    partial class rUsuarios
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
            this.NivelUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.FechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmarTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NivelUsuarioComboBox
            // 
            this.NivelUsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NivelUsuarioComboBox.FormattingEnabled = true;
            this.NivelUsuarioComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.NivelUsuarioComboBox.Location = new System.Drawing.Point(88, 154);
            this.NivelUsuarioComboBox.Name = "NivelUsuarioComboBox";
            this.NivelUsuarioComboBox.Size = new System.Drawing.Size(206, 21);
            this.NivelUsuarioComboBox.TabIndex = 100;
            // 
            // FechaIngresoDateTimePicker
            // 
            this.FechaIngresoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresoDateTimePicker.Location = new System.Drawing.Point(90, 302);
            this.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker";
            this.FechaIngresoDateTimePicker.Size = new System.Drawing.Size(204, 20);
            this.FechaIngresoDateTimePicker.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Fecha Ingreso";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(88, 46);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.IdNumericUpDown.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Email";
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(88, 230);
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.Size = new System.Drawing.Size(206, 20);
            this.ContraseñatextBox.TabIndex = 90;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(88, 115);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(206, 20);
            this.EmailtextBox.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 87;
            this.label3.Text = "Nivel \r\nUsuario";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(17, 82);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(50, 13);
            this.Nombre.TabIndex = 86;
            this.Nombre.Text = "Nombre";
            this.Nombre.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "ID";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(88, 191);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(206, 20);
            this.UsuariotextBox.TabIndex = 84;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(88, 79);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(206, 20);
            this.NombretextBox.TabIndex = 83;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretexBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Confirmar ";
            // 
            // ConfirmarTextBox
            // 
            this.ConfirmarTextBox.Location = new System.Drawing.Point(88, 261);
            this.ConfirmarTextBox.Name = "ConfirmarTextBox";
            this.ConfirmarTextBox.Size = new System.Drawing.Size(206, 20);
            this.ConfirmarTextBox.TabIndex = 101;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.Color.White;
            this.Buscarbutton.Image = global::ProyectoFinalAplicadaI.Properties.Resources.icons8_búsqueda_241;
            this.Buscarbutton.Location = new System.Drawing.Point(205, 38);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(89, 32);
            this.Buscarbutton.TabIndex = 143;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.Color.White;
            this.EliminarButton.Image = global::ProyectoFinalAplicadaI.Properties.Resources.icons8_eliminar_26;
            this.EliminarButton.Location = new System.Drawing.Point(226, 338);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(87, 55);
            this.EliminarButton.TabIndex = 142;
            this.EliminarButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::ProyectoFinalAplicadaI.Properties.Resources.New_File_36861_1_;
            this.button2.Location = new System.Drawing.Point(36, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 55);
            this.button2.TabIndex = 141;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::ProyectoFinalAplicadaI.Properties.Resources.icons8_guardar_48;
            this.button3.Location = new System.Drawing.Point(130, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 55);
            this.button3.TabIndex = 140;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 18);
            this.label8.TabIndex = 144;
            this.label8.Text = "Registro De Usuarios";
            this.label8.UseMnemonic = false;
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 405);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmarTextBox);
            this.Controls.Add(this.NivelUsuarioComboBox);
            this.Controls.Add(this.FechaIngresoDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Name = "rUsuarios";
            this.Text = "Registro de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox NivelUsuarioComboBox;
        private System.Windows.Forms.DateTimePicker FechaIngresoDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfirmarTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label label8;
    }
}
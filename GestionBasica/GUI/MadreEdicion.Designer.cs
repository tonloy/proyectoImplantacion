namespace GestionBasica.GUI
{
    partial class MadreEdicion
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskTEdad = new System.Windows.Forms.MaskedTextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.cbxDepartamentos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tdsdxtID = new System.Windows.Forms.Label();
            this.mtxtDUI = new System.Windows.Forms.MaskedTextBox();
            this.txtConocidapor = new System.Windows.Forms.TextBox();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNombreCompleto = new System.Windows.Forms.TextBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 60;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(428, 257);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Nacionalidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Profesion u Oficio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Domicilio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Conocida por:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Nombre Completo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.mskTEdad);
            this.groupBox1.Controls.Add(this.txtProfesion);
            this.groupBox1.Controls.Add(this.cbxDepartamentos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNacionalidad);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.tdsdxtID);
            this.groupBox1.Controls.Add(this.mtxtDUI);
            this.groupBox1.Controls.Add(this.txtConocidapor);
            this.groupBox1.Controls.Add(this.cbxMunicipio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbNombreCompleto);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 220);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Madre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 26);
            this.label12.TabIndex = 87;
            this.label12.Text = "Documento Unico \r\nde Identidad (DUI):";
            // 
            // mskTEdad
            // 
            this.mskTEdad.Location = new System.Drawing.Point(145, 99);
            this.mskTEdad.Mask = "00";
            this.mskTEdad.Name = "mskTEdad";
            this.mskTEdad.Size = new System.Drawing.Size(44, 20);
            this.mskTEdad.TabIndex = 2;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(145, 151);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(157, 20);
            this.txtProfesion.TabIndex = 6;
            this.txtProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesion_KeyPress);
            // 
            // cbxDepartamentos
            // 
            this.cbxDepartamentos.FormattingEnabled = true;
            this.cbxDepartamentos.Location = new System.Drawing.Point(284, 98);
            this.cbxDepartamentos.Name = "cbxDepartamentos";
            this.cbxDepartamentos.Size = new System.Drawing.Size(120, 21);
            this.cbxDepartamentos.TabIndex = 3;
            this.cbxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cbxDepartamentos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Departamento";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(408, 151);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(177, 20);
            this.txtNacionalidad.TabIndex = 7;
            this.txtNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNacionalidad_KeyPress);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(145, 125);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(440, 20);
            this.txtDomicilio.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(145, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(44, 20);
            this.txtID.TabIndex = 63;
            // 
            // tdsdxtID
            // 
            this.tdsdxtID.AutoSize = true;
            this.tdsdxtID.Location = new System.Drawing.Point(111, 22);
            this.tdsdxtID.Name = "tdsdxtID";
            this.tdsdxtID.Size = new System.Drawing.Size(21, 13);
            this.tdsdxtID.TabIndex = 3;
            this.tdsdxtID.Text = "ID:";
            // 
            // mtxtDUI
            // 
            this.mtxtDUI.Location = new System.Drawing.Point(145, 177);
            this.mtxtDUI.Mask = "00000000-0";
            this.mtxtDUI.Name = "mtxtDUI";
            this.mtxtDUI.Size = new System.Drawing.Size(157, 20);
            this.mtxtDUI.TabIndex = 8;
            // 
            // txtConocidapor
            // 
            this.txtConocidapor.Location = new System.Drawing.Point(145, 74);
            this.txtConocidapor.Name = "txtConocidapor";
            this.txtConocidapor.Size = new System.Drawing.Size(440, 20);
            this.txtConocidapor.TabIndex = 1;
            this.txtConocidapor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConocidapor_KeyPress);
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(463, 99);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(122, 21);
            this.cbxMunicipio.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Municipio";
            // 
            // txbNombreCompleto
            // 
            this.txbNombreCompleto.Location = new System.Drawing.Point(145, 48);
            this.txbNombreCompleto.Name = "txbNombreCompleto";
            this.txbNombreCompleto.Size = new System.Drawing.Size(440, 20);
            this.txbNombreCompleto.TabIndex = 0;
            this.txbNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombreCompleto_KeyPress);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // MadreEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 300);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MadreEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edición de Partida de Nacimiento";
            this.Load += new System.EventHandler(this.MadreEdicion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox mskTEdad;
        public System.Windows.Forms.TextBox txtProfesion;
        public System.Windows.Forms.ComboBox cbxDepartamentos;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNacionalidad;
        public System.Windows.Forms.TextBox txtDomicilio;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label tdsdxtID;
        public System.Windows.Forms.MaskedTextBox mtxtDUI;
        public System.Windows.Forms.TextBox txtConocidapor;
        public System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txbNombreCompleto;
        private System.Windows.Forms.ErrorProvider Notificador;

    }
}
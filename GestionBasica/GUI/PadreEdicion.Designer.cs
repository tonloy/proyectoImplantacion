﻿namespace GestionBasica.GUI
{
    partial class PadreEdicion
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
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConocidapor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNombreCompleto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRubrica = new System.Windows.Forms.TextBox();
            this.txtNumPartida = new System.Windows.Forms.MaskedTextBox();
            this.chbxMenor = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxParentesco = new System.Windows.Forms.ComboBox();
            this.cbxPaises = new System.Windows.Forms.ComboBox();
            this.cbxProfesiones = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskTEdad = new System.Windows.Forms.MaskedTextBox();
            this.cbxDepartamentos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tdsdxtID = new System.Windows.Forms.Label();
            this.mtxtDUI = new System.Windows.Forms.MaskedTextBox();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(542, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(440, 466);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Nacionalidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Profesion u Oficio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(145, 125);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(440, 20);
            this.txtDomicilio.TabIndex = 5;
            this.txtDomicilio.Leave += new System.EventHandler(this.txtDomicilio_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Domicilio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Municipio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Edad:";
            // 
            // txtConocidapor
            // 
            this.txtConocidapor.Location = new System.Drawing.Point(145, 74);
            this.txtConocidapor.Name = "txtConocidapor";
            this.txtConocidapor.Size = new System.Drawing.Size(157, 20);
            this.txtConocidapor.TabIndex = 1;
            this.txtConocidapor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConocidapor_KeyPress);
            this.txtConocidapor.Leave += new System.EventHandler(this.txtConocidapor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Conocido por:";
            // 
            // txbNombreCompleto
            // 
            this.txbNombreCompleto.Location = new System.Drawing.Point(145, 48);
            this.txbNombreCompleto.Name = "txbNombreCompleto";
            this.txbNombreCompleto.Size = new System.Drawing.Size(440, 20);
            this.txbNombreCompleto.TabIndex = 0;
            this.txbNombreCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombreCompleto_KeyPress);
            this.txbNombreCompleto.Leave += new System.EventHandler(this.txbNombreCompleto_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Nombre Completo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtRubrica);
            this.groupBox1.Controls.Add(this.txtNumPartida);
            this.groupBox1.Controls.Add(this.chbxMenor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxParentesco);
            this.groupBox1.Controls.Add(this.cbxPaises);
            this.groupBox1.Controls.Add(this.cbxProfesiones);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.mskTEdad);
            this.groupBox1.Controls.Add(this.cbxDepartamentos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.tdsdxtID);
            this.groupBox1.Controls.Add(this.mtxtDUI);
            this.groupBox1.Controls.Add(this.txtConocidapor);
            this.groupBox1.Controls.Add(this.cbxMunicipio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbNombreCompleto);
            this.groupBox1.Location = new System.Drawing.Point(32, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Persona";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 101;
            this.label13.Text = "Rubricas:";
            // 
            // txtRubrica
            // 
            this.txtRubrica.Location = new System.Drawing.Point(145, 294);
            this.txtRubrica.Name = "txtRubrica";
            this.txtRubrica.Size = new System.Drawing.Size(157, 20);
            this.txtRubrica.TabIndex = 100;
            // 
            // txtNumPartida
            // 
            this.txtNumPartida.Enabled = false;
            this.txtNumPartida.Location = new System.Drawing.Point(145, 238);
            this.txtNumPartida.Mask = "0000-000000-000-0";
            this.txtNumPartida.Name = "txtNumPartida";
            this.txtNumPartida.Size = new System.Drawing.Size(157, 20);
            this.txtNumPartida.TabIndex = 99;
            // 
            // chbxMenor
            // 
            this.chbxMenor.AutoSize = true;
            this.chbxMenor.Location = new System.Drawing.Point(475, 21);
            this.chbxMenor.Name = "chbxMenor";
            this.chbxMenor.Size = new System.Drawing.Size(110, 17);
            this.chbxMenor.TabIndex = 98;
            this.chbxMenor.Text = "¿Menor de edad?";
            this.chbxMenor.UseVisualStyleBackColor = true;
            this.chbxMenor.CheckStateChanged += new System.EventHandler(this.chbxMenor_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "NIT:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(145, 328);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(440, 64);
            this.txtObservaciones.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Observaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Parentesco:";
            // 
            // cbxParentesco
            // 
            this.cbxParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParentesco.FormattingEnabled = true;
            this.cbxParentesco.Location = new System.Drawing.Point(145, 265);
            this.cbxParentesco.Name = "cbxParentesco";
            this.cbxParentesco.Size = new System.Drawing.Size(157, 21);
            this.cbxParentesco.TabIndex = 90;
            // 
            // cbxPaises
            // 
            this.cbxPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaises.FormattingEnabled = true;
            this.cbxPaises.Location = new System.Drawing.Point(408, 150);
            this.cbxPaises.Name = "cbxPaises";
            this.cbxPaises.Size = new System.Drawing.Size(177, 21);
            this.cbxPaises.TabIndex = 89;
            // 
            // cbxProfesiones
            // 
            this.cbxProfesiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfesiones.FormattingEnabled = true;
            this.cbxProfesiones.Location = new System.Drawing.Point(145, 150);
            this.cbxProfesiones.Name = "cbxProfesiones";
            this.cbxProfesiones.Size = new System.Drawing.Size(157, 21);
            this.cbxProfesiones.TabIndex = 88;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 206);
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
            // cbxDepartamentos
            // 
            this.cbxDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamentos.FormattingEnabled = true;
            this.cbxDepartamentos.Location = new System.Drawing.Point(278, 98);
            this.cbxDepartamentos.Name = "cbxDepartamentos";
            this.cbxDepartamentos.Size = new System.Drawing.Size(126, 21);
            this.cbxDepartamentos.TabIndex = 3;
            this.cbxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cbxDepartamentos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Departamento";
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
            this.mtxtDUI.Location = new System.Drawing.Point(145, 212);
            this.mtxtDUI.Mask = "00000000-0";
            this.mtxtDUI.Name = "mtxtDUI";
            this.mtxtDUI.Size = new System.Drawing.Size(157, 20);
            this.mtxtDUI.TabIndex = 8;
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(463, 99);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(122, 21);
            this.cbxMunicipio.TabIndex = 4;
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(145, 180);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(157, 20);
            this.dtpFecha.TabIndex = 102;
            this.dtpFecha.Value = new System.DateTime(2017, 9, 22, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 103;
            this.label14.Text = "Fecha de nacimiento:";
            // 
            // PadreEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 512);
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
            this.MaximizeBox = false;
            this.Name = "PadreEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edición de Partida de Nacimiento";
            this.Load += new System.EventHandler(this.PadreEdicion_Load);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tdsdxtID;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.TextBox txtDomicilio;
        public System.Windows.Forms.TextBox txtConocidapor;
        public System.Windows.Forms.TextBox txbNombreCompleto;
        public System.Windows.Forms.MaskedTextBox mtxtDUI;
        public System.Windows.Forms.ComboBox cbxMunicipio;
        public System.Windows.Forms.ComboBox cbxDepartamentos;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.MaskedTextBox mskTEdad;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cbxPaises;
        public System.Windows.Forms.ComboBox cbxProfesiones;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbxParentesco;
        public System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox txtNumPartida;
        public System.Windows.Forms.CheckBox chbxMenor;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtRubrica;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label14;
    }
}
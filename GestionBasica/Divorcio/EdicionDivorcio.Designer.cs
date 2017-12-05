namespace GestionBasica.Divorcio
{
    partial class EdicionDivorcio
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
            this.chbxRespaldo = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbFolio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbIdPartida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumPartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txbNumPartidaMat = new System.Windows.Forms.TextBox();
            this.txbIdMatrimonio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFolioMat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbHombre = new System.Windows.Forms.TextBox();
            this.txbMujer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbFechaMat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFechaSentencia = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEjecutoriada = new System.Windows.Forms.DateTimePicker();
            this.txbRegimen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbNotario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbTutela = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chbxRevisado = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxJuzgados = new System.Windows.Forms.ComboBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // chbxRespaldo
            // 
            this.chbxRespaldo.AutoSize = true;
            this.chbxRespaldo.Location = new System.Drawing.Point(332, 127);
            this.chbxRespaldo.Margin = new System.Windows.Forms.Padding(2);
            this.chbxRespaldo.Name = "chbxRespaldo";
            this.chbxRespaldo.Size = new System.Drawing.Size(107, 17);
            this.chbxRespaldo.TabIndex = 34;
            this.chbxRespaldo.Text = "Respaldo Partida";
            this.chbxRespaldo.UseVisualStyleBackColor = true;
            this.chbxRespaldo.CheckedChanged += new System.EventHandler(this.chbxRespaldo_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionBasica.Properties.Resources.Imagen_no_disponible;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(337, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // txbFolio
            // 
            this.txbFolio.Location = new System.Drawing.Point(74, 66);
            this.txbFolio.Name = "txbFolio";
            this.txbFolio.Size = new System.Drawing.Size(49, 20);
            this.txbFolio.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tomo";
            // 
            // txbIdPartida
            // 
            this.txbIdPartida.Location = new System.Drawing.Point(74, 12);
            this.txbIdPartida.Name = "txbIdPartida";
            this.txbIdPartida.ReadOnly = true;
            this.txbIdPartida.Size = new System.Drawing.Size(49, 20);
            this.txbIdPartida.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID";
            // 
            // txbLibro
            // 
            this.txbLibro.Location = new System.Drawing.Point(74, 39);
            this.txbLibro.Name = "txbLibro";
            this.txbLibro.Size = new System.Drawing.Size(49, 20);
            this.txbLibro.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Libro";
            // 
            // txbNumPartida
            // 
            this.txbNumPartida.Location = new System.Drawing.Point(74, 93);
            this.txbNumPartida.Name = "txbNumPartida";
            this.txbNumPartida.Size = new System.Drawing.Size(49, 20);
            this.txbNumPartida.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "No Partida";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(362, 162);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 35;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txbNumPartidaMat
            // 
            this.txbNumPartidaMat.Location = new System.Drawing.Point(220, 164);
            this.txbNumPartidaMat.Name = "txbNumPartidaMat";
            this.txbNumPartidaMat.ReadOnly = true;
            this.txbNumPartidaMat.Size = new System.Drawing.Size(48, 20);
            this.txbNumPartidaMat.TabIndex = 38;
            // 
            // txbIdMatrimonio
            // 
            this.txbIdMatrimonio.Location = new System.Drawing.Point(161, 164);
            this.txbIdMatrimonio.Name = "txbIdMatrimonio";
            this.txbIdMatrimonio.ReadOnly = true;
            this.txbIdMatrimonio.Size = new System.Drawing.Size(38, 20);
            this.txbIdMatrimonio.TabIndex = 37;
            this.txbIdMatrimonio.TextChanged += new System.EventHandler(this.txbIdMatrimonio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Partida de matrimonio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Folio";
            // 
            // txbFolioMat
            // 
            this.txbFolioMat.Location = new System.Drawing.Point(300, 164);
            this.txbFolioMat.Name = "txbFolioMat";
            this.txbFolioMat.ReadOnly = true;
            this.txbFolioMat.Size = new System.Drawing.Size(59, 20);
            this.txbFolioMat.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Hombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Mujer";
            // 
            // txbHombre
            // 
            this.txbHombre.Location = new System.Drawing.Point(161, 200);
            this.txbHombre.Name = "txbHombre";
            this.txbHombre.ReadOnly = true;
            this.txbHombre.Size = new System.Drawing.Size(276, 20);
            this.txbHombre.TabIndex = 46;
            // 
            // txbMujer
            // 
            this.txbMujer.Location = new System.Drawing.Point(161, 232);
            this.txbMujer.Name = "txbMujer";
            this.txbMujer.ReadOnly = true;
            this.txbMujer.Size = new System.Drawing.Size(276, 20);
            this.txbMujer.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Fecha de matrimonio";
            // 
            // txbFechaMat
            // 
            this.txbFechaMat.Location = new System.Drawing.Point(161, 319);
            this.txbFechaMat.Name = "txbFechaMat";
            this.txbFechaMat.ReadOnly = true;
            this.txbFechaMat.Size = new System.Drawing.Size(129, 20);
            this.txbFechaMat.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Fecha de sentencia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Fecha ejecutoriada";
            // 
            // dtpFechaSentencia
            // 
            this.dtpFechaSentencia.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaSentencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSentencia.Location = new System.Drawing.Point(161, 347);
            this.dtpFechaSentencia.Name = "dtpFechaSentencia";
            this.dtpFechaSentencia.Size = new System.Drawing.Size(129, 20);
            this.dtpFechaSentencia.TabIndex = 53;
            // 
            // dtpFechaEjecutoriada
            // 
            this.dtpFechaEjecutoriada.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaEjecutoriada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEjecutoriada.Location = new System.Drawing.Point(161, 381);
            this.dtpFechaEjecutoriada.Name = "dtpFechaEjecutoriada";
            this.dtpFechaEjecutoriada.Size = new System.Drawing.Size(129, 20);
            this.dtpFechaEjecutoriada.TabIndex = 54;
            // 
            // txbRegimen
            // 
            this.txbRegimen.Location = new System.Drawing.Point(161, 261);
            this.txbRegimen.Name = "txbRegimen";
            this.txbRegimen.ReadOnly = true;
            this.txbRegimen.Size = new System.Drawing.Size(276, 20);
            this.txbRegimen.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Regimén patrimonial";
            // 
            // txbNotario
            // 
            this.txbNotario.Location = new System.Drawing.Point(161, 414);
            this.txbNotario.Name = "txbNotario";
            this.txbNotario.Size = new System.Drawing.Size(276, 20);
            this.txbNotario.TabIndex = 58;
            this.txbNotario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNotario_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 417);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Notario";
            // 
            // txbTutela
            // 
            this.txbTutela.Location = new System.Drawing.Point(161, 448);
            this.txbTutela.Multiline = true;
            this.txbTutela.Name = "txbTutela";
            this.txbTutela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbTutela.Size = new System.Drawing.Size(276, 104);
            this.txbTutela.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 451);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "Tutela de los hijos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(277, 568);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(364, 568);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chbxRevisado
            // 
            this.chbxRevisado.AutoSize = true;
            this.chbxRevisado.Location = new System.Drawing.Point(65, 127);
            this.chbxRevisado.Margin = new System.Windows.Forms.Padding(2);
            this.chbxRevisado.Name = "chbxRevisado";
            this.chbxRevisado.Size = new System.Drawing.Size(71, 17);
            this.chbxRevisado.TabIndex = 63;
            this.chbxRevisado.Text = "Revisado";
            this.chbxRevisado.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(89, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 64;
            this.label17.Text = "Juzgado";
            // 
            // cbxJuzgados
            // 
            this.cbxJuzgados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJuzgados.FormattingEnabled = true;
            this.cbxJuzgados.Location = new System.Drawing.Point(161, 290);
            this.cbxJuzgados.Name = "cbxJuzgados";
            this.cbxJuzgados.Size = new System.Drawing.Size(276, 21);
            this.cbxJuzgados.TabIndex = 65;
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // EdicionDivorcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 609);
            this.Controls.Add(this.cbxJuzgados);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.chbxRevisado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbTutela);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbNotario);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txbRegimen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpFechaEjecutoriada);
            this.Controls.Add(this.dtpFechaSentencia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbFechaMat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbMujer);
            this.Controls.Add(this.txbHombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbFolioMat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txbNumPartidaMat);
            this.Controls.Add(this.txbIdMatrimonio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbxRespaldo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbFolio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbIdPartida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNumPartida);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EdicionDivorcio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Divorcio";
            this.Load += new System.EventHandler(this.EdicionDivorcio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chbxRespaldo;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txbFolio;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txbIdPartida;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txbLibro;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbNumPartida;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSeleccionar;
        public System.Windows.Forms.TextBox txbNumPartidaMat;
        public System.Windows.Forms.TextBox txbIdMatrimonio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txbFolioMat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txbHombre;
        public System.Windows.Forms.TextBox txbMujer;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txbFechaMat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txbRegimen;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txbNotario;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txbTutela;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.CheckBox chbxRevisado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.ComboBox cbxJuzgados;
        public System.Windows.Forms.DateTimePicker dtpFechaSentencia;
        public System.Windows.Forms.DateTimePicker dtpFechaEjecutoriada;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
namespace GestionBasica.GUI.Matrimonio
{
    partial class IngresarPartidaMat
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
            this.cbxRespaldoPda = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbFolio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtInformante2 = new System.Windows.Forms.TextBox();
            this.txtIdInfo2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtInformante1 = new System.Windows.Forms.TextBox();
            this.txt_IdInf1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEsposa = new System.Windows.Forms.TextBox();
            this.txtIdEsposa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEsposo = new System.Windows.Forms.TextBox();
            this.txtID_Esposo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumPartida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.txtApellidoCasada = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxDepartamentos = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.cbxRegimenPatrimonial = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtID_Partida_cod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chbxRevisado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxRespaldoPda
            // 
            this.cbxRespaldoPda.AutoSize = true;
            this.cbxRespaldoPda.Location = new System.Drawing.Point(360, 83);
            this.cbxRespaldoPda.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRespaldoPda.Name = "cbxRespaldoPda";
            this.cbxRespaldoPda.Size = new System.Drawing.Size(107, 17);
            this.cbxRespaldoPda.TabIndex = 48;
            this.cbxRespaldoPda.Text = "Respaldo Partida";
            this.cbxRespaldoPda.UseVisualStyleBackColor = true;
            this.cbxRespaldoPda.CheckedChanged += new System.EventHandler(this.cbxRespaldoPda_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionBasica.Properties.Resources.Imagen_no_disponible;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(379, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // txbFolio
            // 
            this.txbFolio.Location = new System.Drawing.Point(119, 41);
            this.txbFolio.Name = "txbFolio";
            this.txbFolio.Size = new System.Drawing.Size(49, 20);
            this.txbFolio.TabIndex = 26;
            this.txbFolio.TextChanged += new System.EventHandler(this.txbFolio_TextChanged);
            this.txbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFolio_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Folio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(389, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(296, 417);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Seleccionar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtInformante2
            // 
            this.txtInformante2.Location = new System.Drawing.Point(173, 191);
            this.txtInformante2.Name = "txtInformante2";
            this.txtInformante2.ReadOnly = true;
            this.txtInformante2.Size = new System.Drawing.Size(211, 20);
            this.txtInformante2.TabIndex = 45;
            // 
            // txtIdInfo2
            // 
            this.txtIdInfo2.Location = new System.Drawing.Point(137, 191);
            this.txtIdInfo2.Name = "txtIdInfo2";
            this.txtIdInfo2.ReadOnly = true;
            this.txtIdInfo2.Size = new System.Drawing.Size(30, 20);
            this.txtIdInfo2.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Segundo Testigo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Seleccionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtInformante1
            // 
            this.txtInformante1.Location = new System.Drawing.Point(173, 166);
            this.txtInformante1.Name = "txtInformante1";
            this.txtInformante1.ReadOnly = true;
            this.txtInformante1.Size = new System.Drawing.Size(211, 20);
            this.txtInformante1.TabIndex = 42;
            // 
            // txt_IdInf1
            // 
            this.txt_IdInf1.Location = new System.Drawing.Point(137, 166);
            this.txt_IdInf1.Name = "txt_IdInf1";
            this.txt_IdInf1.ReadOnly = true;
            this.txt_IdInf1.Size = new System.Drawing.Size(30, 20);
            this.txt_IdInf1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Primer Testigo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEsposa
            // 
            this.txtEsposa.Location = new System.Drawing.Point(173, 136);
            this.txtEsposa.Name = "txtEsposa";
            this.txtEsposa.ReadOnly = true;
            this.txtEsposa.Size = new System.Drawing.Size(211, 20);
            this.txtEsposa.TabIndex = 39;
            // 
            // txtIdEsposa
            // 
            this.txtIdEsposa.Location = new System.Drawing.Point(137, 136);
            this.txtIdEsposa.Name = "txtIdEsposa";
            this.txtIdEsposa.ReadOnly = true;
            this.txtIdEsposa.Size = new System.Drawing.Size(30, 20);
            this.txtIdEsposa.TabIndex = 38;
            this.txtIdEsposa.TextChanged += new System.EventHandler(this.txtIdEsposa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Esposa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEsposo
            // 
            this.txtEsposo.Location = new System.Drawing.Point(173, 109);
            this.txtEsposo.Name = "txtEsposo";
            this.txtEsposo.ReadOnly = true;
            this.txtEsposo.Size = new System.Drawing.Size(211, 20);
            this.txtEsposo.TabIndex = 34;
            // 
            // txtID_Esposo
            // 
            this.txtID_Esposo.Location = new System.Drawing.Point(136, 109);
            this.txtID_Esposo.Name = "txtID_Esposo";
            this.txtID_Esposo.ReadOnly = true;
            this.txtID_Esposo.Size = new System.Drawing.Size(30, 20);
            this.txtID_Esposo.TabIndex = 32;
            this.txtID_Esposo.TextChanged += new System.EventHandler(this.txtID_Esposo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Esposo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbNumPartida
            // 
            this.txbNumPartida.Location = new System.Drawing.Point(119, 68);
            this.txbNumPartida.Name = "txbNumPartida";
            this.txbNumPartida.Size = new System.Drawing.Size(49, 20);
            this.txbNumPartida.TabIndex = 27;
            this.txbNumPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumPartida_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "No Partida";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(389, 217);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 49;
            this.button7.Text = "Seleccionar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(172, 219);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.Size = new System.Drawing.Size(211, 20);
            this.txtFuncionario.TabIndex = 52;
            this.txtFuncionario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(136, 219);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.ReadOnly = true;
            this.txtIDFuncionario.Size = new System.Drawing.Size(30, 20);
            this.txtIDFuncionario.TabIndex = 51;
            this.txtIDFuncionario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Funcionario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Hora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Regimen Matrimonial";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Apellido Casada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDetalle);
            this.groupBox1.Controls.Add(this.txtApellidoCasada);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbxRegimenPatrimonial);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(29, 253);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(436, 146);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Matrimonio";
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(325, 110);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(98, 23);
            this.btnDetalle.TabIndex = 62;
            this.btnDetalle.Text = "Detalles";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // txtApellidoCasada
            // 
            this.txtApellidoCasada.Location = new System.Drawing.Point(175, 116);
            this.txtApellidoCasada.Name = "txtApellidoCasada";
            this.txtApellidoCasada.Size = new System.Drawing.Size(132, 20);
            this.txtApellidoCasada.TabIndex = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxDepartamentos);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbxMunicipio);
            this.groupBox2.Location = new System.Drawing.Point(23, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(283, 65);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lugar Matrimonio";
            // 
            // cbxDepartamentos
            // 
            this.cbxDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamentos.FormattingEnabled = true;
            this.cbxDepartamentos.Location = new System.Drawing.Point(8, 34);
            this.cbxDepartamentos.Name = "cbxDepartamentos";
            this.cbxDepartamentos.Size = new System.Drawing.Size(126, 21);
            this.cbxDepartamentos.TabIndex = 66;
            this.cbxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cbxDepartamentos_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Departamento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(149, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "Municipio";
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(146, 34);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(122, 21);
            this.cbxMunicipio.TabIndex = 67;
            this.cbxMunicipio.SelectedIndexChanged += new System.EventHandler(this.cbxMunicipio_SelectedIndexChanged);
            // 
            // cbxRegimenPatrimonial
            // 
            this.cbxRegimenPatrimonial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegimenPatrimonial.FormattingEnabled = true;
            this.cbxRegimenPatrimonial.Location = new System.Drawing.Point(23, 114);
            this.cbxRegimenPatrimonial.Name = "cbxRegimenPatrimonial";
            this.cbxRegimenPatrimonial.Size = new System.Drawing.Size(134, 21);
            this.cbxRegimenPatrimonial.TabIndex = 57;
            this.cbxRegimenPatrimonial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(325, 43);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(43, 20);
            this.txtHora.TabIndex = 56;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(325, 81);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(99, 20);
            this.dtpFecha.TabIndex = 55;
            this.dtpFecha.Value = new System.DateTime(2017, 9, 22, 0, 0, 0, 0);
            // 
            // txtID_Partida_cod
            // 
            this.txtID_Partida_cod.Location = new System.Drawing.Point(119, 18);
            this.txtID_Partida_cod.Name = "txtID_Partida_cod";
            this.txtID_Partida_cod.ReadOnly = true;
            this.txtID_Partida_cod.Size = new System.Drawing.Size(49, 20);
            this.txtID_Partida_cod.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "ID Partida";
            // 
            // chbxRevisado
            // 
            this.chbxRevisado.AutoSize = true;
            this.chbxRevisado.Location = new System.Drawing.Point(51, 424);
            this.chbxRevisado.Margin = new System.Windows.Forms.Padding(2);
            this.chbxRevisado.Name = "chbxRevisado";
            this.chbxRevisado.Size = new System.Drawing.Size(71, 17);
            this.chbxRevisado.TabIndex = 61;
            this.chbxRevisado.Text = "Revisado";
            this.chbxRevisado.UseVisualStyleBackColor = true;
            // 
            // IngresarPartidaMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 473);
            this.Controls.Add(this.chbxRevisado);
            this.Controls.Add(this.txtID_Partida_cod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.txtIDFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRespaldoPda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbFolio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtInformante2);
            this.Controls.Add(this.txtIdInfo2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtInformante1);
            this.Controls.Add(this.txt_IdInf1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEsposa);
            this.Controls.Add(this.txtIdEsposa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEsposo);
            this.Controls.Add(this.txtID_Esposo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNumPartida);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IngresarPartidaMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edición de Partida de Matrimonio";
            this.Load += new System.EventHandler(this.IngresarPartidaMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txbFolio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox txtInformante2;
        public System.Windows.Forms.TextBox txtIdInfo2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtInformante1;
        public System.Windows.Forms.TextBox txt_IdInf1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtEsposa;
        public System.Windows.Forms.TextBox txtIdEsposa;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtEsposo;
        public System.Windows.Forms.TextBox txtID_Esposo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbNumPartida;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.TextBox txtFuncionario;
        public System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.ComboBox cbxRegimenPatrimonial;
        public System.Windows.Forms.MaskedTextBox txtHora;
        public System.Windows.Forms.TextBox txtApellidoCasada;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox cbxDepartamentos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox cbxMunicipio;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtID_Partida_cod;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnDetalle;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox cbxRespaldoPda;
        public System.Windows.Forms.CheckBox chbxRevisado;
    }
}
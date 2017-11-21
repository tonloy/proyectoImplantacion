namespace GestionBasica.GUI
{
    partial class PartidaEdicion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumPartida = new System.Windows.Forms.TextBox();
            this.txbLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdInfante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbInfante = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombreMadre = new System.Windows.Forms.TextBox();
            this.txtIdMadre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNombrePadre = new System.Windows.Forms.TextBox();
            this.txtIdPadre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtNombreInformante = new System.Windows.Forms.TextBox();
            this.txtIdInformante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txbIdPartida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbFolio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxRespaldoPda = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Partida";
            // 
            // txbNumPartida
            // 
            this.txbNumPartida.Location = new System.Drawing.Point(83, 107);
            this.txbNumPartida.Name = "txbNumPartida";
            this.txbNumPartida.Size = new System.Drawing.Size(49, 20);
            this.txbNumPartida.TabIndex = 2;
            this.txbNumPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumPartida_KeyPress);
            // 
            // txbLibro
            // 
            this.txbLibro.Location = new System.Drawing.Point(83, 53);
            this.txbLibro.Name = "txbLibro";
            this.txbLibro.Size = new System.Drawing.Size(49, 20);
            this.txbLibro.TabIndex = 0;
            this.txbLibro.TextChanged += new System.EventHandler(this.txbLibro_TextChanged);
            this.txbLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLibro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Libro";
            // 
            // txbIdInfante
            // 
            this.txbIdInfante.Location = new System.Drawing.Point(83, 157);
            this.txbIdInfante.Name = "txbIdInfante";
            this.txbIdInfante.ReadOnly = true;
            this.txbIdInfante.Size = new System.Drawing.Size(30, 20);
            this.txbIdInfante.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Infante";
            // 
            // txbInfante
            // 
            this.txbInfante.Location = new System.Drawing.Point(119, 157);
            this.txbInfante.Name = "txbInfante";
            this.txbInfante.ReadOnly = true;
            this.txbInfante.Size = new System.Drawing.Size(211, 20);
            this.txbInfante.TabIndex = 6;
            this.txbInfante.TextChanged += new System.EventHandler(this.txbInfante_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNombreMadre
            // 
            this.txtNombreMadre.Location = new System.Drawing.Point(119, 196);
            this.txtNombreMadre.Name = "txtNombreMadre";
            this.txtNombreMadre.ReadOnly = true;
            this.txtNombreMadre.Size = new System.Drawing.Size(211, 20);
            this.txtNombreMadre.TabIndex = 10;
            // 
            // txtIdMadre
            // 
            this.txtIdMadre.Location = new System.Drawing.Point(83, 196);
            this.txtIdMadre.Name = "txtIdMadre";
            this.txtIdMadre.ReadOnly = true;
            this.txtIdMadre.Size = new System.Drawing.Size(30, 20);
            this.txtIdMadre.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Madre";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Seleccionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNombrePadre
            // 
            this.txtNombrePadre.Location = new System.Drawing.Point(119, 235);
            this.txtNombrePadre.Name = "txtNombrePadre";
            this.txtNombrePadre.ReadOnly = true;
            this.txtNombrePadre.Size = new System.Drawing.Size(211, 20);
            this.txtNombrePadre.TabIndex = 14;
            // 
            // txtIdPadre
            // 
            this.txtIdPadre.Location = new System.Drawing.Point(83, 235);
            this.txtIdPadre.Name = "txtIdPadre";
            this.txtIdPadre.ReadOnly = true;
            this.txtIdPadre.Size = new System.Drawing.Size(30, 20);
            this.txtIdPadre.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Padre";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(336, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Seleccionar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtNombreInformante
            // 
            this.txtNombreInformante.Location = new System.Drawing.Point(119, 273);
            this.txtNombreInformante.Name = "txtNombreInformante";
            this.txtNombreInformante.ReadOnly = true;
            this.txtNombreInformante.Size = new System.Drawing.Size(211, 20);
            this.txtNombreInformante.TabIndex = 18;
            // 
            // txtIdInformante
            // 
            this.txtIdInformante.Location = new System.Drawing.Point(83, 273);
            this.txtIdInformante.Name = "txtIdInformante";
            this.txtIdInformante.ReadOnly = true;
            this.txtIdInformante.Size = new System.Drawing.Size(30, 20);
            this.txtIdInformante.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Informante";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(219, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(336, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txbIdPartida
            // 
            this.txbIdPartida.Location = new System.Drawing.Point(83, 26);
            this.txbIdPartida.Name = "txbIdPartida";
            this.txbIdPartida.ReadOnly = true;
            this.txbIdPartida.Size = new System.Drawing.Size(49, 20);
            this.txbIdPartida.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID";
            // 
            // txbFolio
            // 
            this.txbFolio.Location = new System.Drawing.Point(83, 80);
            this.txbFolio.Name = "txbFolio";
            this.txbFolio.Size = new System.Drawing.Size(49, 20);
            this.txbFolio.TabIndex = 1;
            this.txbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFolio_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tomo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionBasica.Properties.Resources.Imagen_no_disponible;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(311, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // cbxRespaldoPda
            // 
            this.cbxRespaldoPda.AutoSize = true;
            this.cbxRespaldoPda.Location = new System.Drawing.Point(306, 132);
            this.cbxRespaldoPda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxRespaldoPda.Name = "cbxRespaldoPda";
            this.cbxRespaldoPda.Size = new System.Drawing.Size(107, 17);
            this.cbxRespaldoPda.TabIndex = 24;
            this.cbxRespaldoPda.Text = "Respaldo Partida";
            this.cbxRespaldoPda.UseVisualStyleBackColor = true;
            this.cbxRespaldoPda.CheckedChanged += new System.EventHandler(this.cbxRespaldoPda_CheckedChanged);
            // 
            // PartidaEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 355);
            this.Controls.Add(this.cbxRespaldoPda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbFolio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbIdPartida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtNombreInformante);
            this.Controls.Add(this.txtIdInformante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNombrePadre);
            this.Controls.Add(this.txtIdPadre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNombreMadre);
            this.Controls.Add(this.txtIdMadre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbInfante);
            this.Controls.Add(this.txbIdInfante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNumPartida);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PartidaEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Registro Familiar";
            this.Load += new System.EventHandler(this.PartidaEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.TextBox txbNumPartida;
        public System.Windows.Forms.TextBox txbLibro;
        public System.Windows.Forms.TextBox txbIdInfante;
        public System.Windows.Forms.TextBox txbInfante;
        public System.Windows.Forms.TextBox txtNombreMadre;
        public System.Windows.Forms.TextBox txtIdMadre;
        public System.Windows.Forms.TextBox txtNombrePadre;
        public System.Windows.Forms.TextBox txtIdPadre;
        public System.Windows.Forms.TextBox txtNombreInformante;
        public System.Windows.Forms.TextBox txtIdInformante;
        public System.Windows.Forms.TextBox txbIdPartida;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txbFolio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.CheckBox cbxRespaldoPda;
        public System.Windows.Forms.Button button1;
    }
}
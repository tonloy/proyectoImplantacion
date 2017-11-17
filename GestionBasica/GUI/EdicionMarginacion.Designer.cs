namespace GestionBasica.GUI
{
    partial class EdicionMarginacion
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
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtExplicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtHoraSentencia = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaSentencia = new System.Windows.Forms.DateTimePicker();
            this.txtNumPartida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxJuzgados = new System.Windows.Forms.ComboBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(144, 6);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.ReadOnly = true;
            this.txtIdPartida.Size = new System.Drawing.Size(79, 20);
            this.txtIdPartida.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtExplicacion
            // 
            this.txtExplicacion.Location = new System.Drawing.Point(15, 173);
            this.txtExplicacion.Multiline = true;
            this.txtExplicacion.Name = "txtExplicacion";
            this.txtExplicacion.Size = new System.Drawing.Size(417, 133);
            this.txtExplicacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Explicación";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(357, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora Sentencia";
            // 
            // mtxtHoraSentencia
            // 
            this.mtxtHoraSentencia.Location = new System.Drawing.Point(144, 63);
            this.mtxtHoraSentencia.Mask = "00:00";
            this.mtxtHoraSentencia.Name = "mtxtHoraSentencia";
            this.mtxtHoraSentencia.Size = new System.Drawing.Size(79, 20);
            this.mtxtHoraSentencia.TabIndex = 6;
            this.mtxtHoraSentencia.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Sentencia";
            // 
            // dtpFechaSentencia
            // 
            this.dtpFechaSentencia.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaSentencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSentencia.Location = new System.Drawing.Point(144, 93);
            this.dtpFechaSentencia.Name = "dtpFechaSentencia";
            this.dtpFechaSentencia.Size = new System.Drawing.Size(79, 20);
            this.dtpFechaSentencia.TabIndex = 8;
            // 
            // txtNumPartida
            // 
            this.txtNumPartida.Location = new System.Drawing.Point(144, 34);
            this.txtNumPartida.Name = "txtNumPartida";
            this.txtNumPartida.ReadOnly = true;
            this.txtNumPartida.Size = new System.Drawing.Size(79, 20);
            this.txtNumPartida.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Partida No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Juzgado";
            // 
            // cbxJuzgados
            // 
            this.cbxJuzgados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJuzgados.FormattingEnabled = true;
            this.cbxJuzgados.Location = new System.Drawing.Point(144, 123);
            this.cbxJuzgados.Name = "cbxJuzgados";
            this.cbxJuzgados.Size = new System.Drawing.Size(288, 21);
            this.cbxJuzgados.TabIndex = 12;
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // EdicionMarginacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 351);
            this.Controls.Add(this.cbxJuzgados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumPartida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaSentencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtHoraSentencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtExplicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EdicionMarginacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Justificación de la Marginación";
            this.Load += new System.EventHandler(this.EdicionMarginacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtExplicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtHoraSentencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaSentencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxJuzgados;
        public System.Windows.Forms.TextBox txtIdPartida;
        public System.Windows.Forms.TextBox txtNumPartida;
        private System.Windows.Forms.ErrorProvider Notificador;
    }
}
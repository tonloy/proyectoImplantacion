namespace GestionBasica.GUI
{
    partial class EdicionJuzgado
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
            this.cbxMunicipios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxDepartamentos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombreJuzgado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdCanton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccionJuzgado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMunicipios
            // 
            this.cbxMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMunicipios.FormattingEnabled = true;
            this.cbxMunicipios.Location = new System.Drawing.Point(46, 190);
            this.cbxMunicipios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMunicipios.Name = "cbxMunicipios";
            this.cbxMunicipios.Size = new System.Drawing.Size(367, 28);
            this.cbxMunicipios.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Municipio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 395);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(107, 395);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxDepartamentos
            // 
            this.cbxDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamentos.FormattingEnabled = true;
            this.cbxDepartamentos.Location = new System.Drawing.Point(46, 126);
            this.cbxDepartamentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxDepartamentos.Name = "cbxDepartamentos";
            this.cbxDepartamentos.Size = new System.Drawing.Size(367, 28);
            this.cbxDepartamentos.TabIndex = 15;
            this.cbxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cbxDepartamentos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Departamento";
            // 
            // txbNombreJuzgado
            // 
            this.txbNombreJuzgado.Location = new System.Drawing.Point(46, 256);
            this.txbNombreJuzgado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbNombreJuzgado.Multiline = true;
            this.txbNombreJuzgado.Name = "txbNombreJuzgado";
            this.txbNombreJuzgado.Size = new System.Drawing.Size(367, 32);
            this.txbNombreJuzgado.TabIndex = 17;
            this.txbNombreJuzgado.Leave += new System.EventHandler(this.txbNombreJuzgado_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre del Juzgado";
            // 
            // txbIdCanton
            // 
            this.txbIdCanton.Location = new System.Drawing.Point(46, 62);
            this.txbIdCanton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbIdCanton.Name = "txbIdCanton";
            this.txbIdCanton.ReadOnly = true;
            this.txbIdCanton.Size = new System.Drawing.Size(72, 26);
            this.txbIdCanton.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Juzgado";
            // 
            // txtDireccionJuzgado
            // 
            this.txtDireccionJuzgado.Location = new System.Drawing.Point(46, 331);
            this.txtDireccionJuzgado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccionJuzgado.Multiline = true;
            this.txtDireccionJuzgado.Name = "txtDireccionJuzgado";
            this.txtDireccionJuzgado.Size = new System.Drawing.Size(367, 32);
            this.txtDireccionJuzgado.TabIndex = 25;
            this.txtDireccionJuzgado.Leave += new System.EventHandler(this.txtDireccionJuzgado_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 307);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Dirección del Juzgado";
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // EdicionJuzgado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 482);
            this.Controls.Add(this.txtDireccionJuzgado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxMunicipios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxDepartamentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNombreJuzgado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIdCanton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EdicionJuzgado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion de Juzgado";
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbxMunicipios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.ComboBox cbxDepartamentos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbNombreJuzgado;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbIdCanton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDireccionJuzgado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider Notificador;
    }
}
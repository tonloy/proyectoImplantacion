namespace GestionBasica.GUI
{
    partial class EdicionCanton
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxDepartamentos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCanton = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdCanton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMunicipios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(98, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxDepartamentos
            // 
            this.cbxDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartamentos.FormattingEnabled = true;
            this.cbxDepartamentos.Location = new System.Drawing.Point(15, 66);
            this.cbxDepartamentos.Name = "cbxDepartamentos";
            this.cbxDepartamentos.Size = new System.Drawing.Size(246, 21);
            this.cbxDepartamentos.TabIndex = 0;
            this.cbxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cbxDepartamentos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Departamento";
            // 
            // txbCanton
            // 
            this.txbCanton.Location = new System.Drawing.Point(15, 151);
            this.txbCanton.Multiline = true;
            this.txbCanton.Name = "txbCanton";
            this.txbCanton.Size = new System.Drawing.Size(246, 51);
            this.txbCanton.TabIndex = 2;
            this.txbCanton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCanton_KeyPress);
            this.txbCanton.Leave += new System.EventHandler(this.txbCanton_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre del cantón";
            // 
            // txbIdCanton
            // 
            this.txbIdCanton.Location = new System.Drawing.Point(15, 25);
            this.txbIdCanton.Name = "txbIdCanton";
            this.txbIdCanton.ReadOnly = true;
            this.txbIdCanton.Size = new System.Drawing.Size(49, 20);
            this.txbIdCanton.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Cantón";
            // 
            // cbxMunicipios
            // 
            this.cbxMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMunicipios.FormattingEnabled = true;
            this.cbxMunicipios.Location = new System.Drawing.Point(15, 108);
            this.cbxMunicipios.Name = "cbxMunicipios";
            this.cbxMunicipios.Size = new System.Drawing.Size(246, 21);
            this.cbxMunicipios.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Municipio";
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // EdicionCanton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 240);
            this.Controls.Add(this.cbxMunicipios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxDepartamentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCanton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIdCanton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EdicionCanton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Cantón";
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.ComboBox cbxDepartamentos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbCanton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbIdCanton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxMunicipios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider Notificador;
    }
}
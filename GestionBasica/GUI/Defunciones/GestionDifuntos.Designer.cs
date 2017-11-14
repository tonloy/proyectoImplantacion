namespace GestionBasica.GUI.Defunciones
{
    partial class GestionDifuntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDifuntos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNueva = new System.Windows.Forms.ToolStripButton();
            this.txbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtgPartidas = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConocidoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Género = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revisado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_familiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartidas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificar,
            this.toolStripSeparator1,
            this.btnNueva,
            this.txbFiltrar,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(924, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 22);
            this.btnModificar.Text = "Marginar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNueva
            // 
            this.btnNueva.ForeColor = System.Drawing.Color.White;
            this.btnNueva.Image = ((System.Drawing.Image)(resources.GetObject("btnNueva.Image")));
            this.btnNueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(61, 22);
            this.btnNueva.Text = "Nueva";
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(200, 25);
            this.txbFiltrar.TextChanged += new System.EventHandler(this.txbFiltrar_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // dtgPartidas
            // 
            this.dtgPartidas.AllowUserToAddRows = false;
            this.dtgPartidas.AllowUserToDeleteRows = false;
            this.dtgPartidas.AllowUserToResizeRows = false;
            this.dtgPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.ConocidoPor,
            this.Edad,
            this.Género,
            this.Dui,
            this.Nit,
            this.Domicilio,
            this.Municipio,
            this.Profesión,
            this.Nacionalidad,
            this.Departamento,
            this.Revisado,
            this.Estado_familiar});
            this.dtgPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPartidas.Location = new System.Drawing.Point(0, 25);
            this.dtgPartidas.MultiSelect = false;
            this.dtgPartidas.Name = "dtgPartidas";
            this.dtgPartidas.ReadOnly = true;
            this.dtgPartidas.RowHeadersVisible = false;
            this.dtgPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPartidas.Size = new System.Drawing.Size(924, 538);
            this.dtgPartidas.TabIndex = 7;
            this.dtgPartidas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPartidas_CellContentDoubleClick);
            this.dtgPartidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPartidas_CellDoubleClick);
            this.dtgPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgPartidas_CellFormatting);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroFilas
            // 
            this.lblNumeroFilas.Name = "lblNumeroFilas";
            this.lblNumeroFilas.Size = new System.Drawing.Size(130, 17);
            this.lblNumeroFilas.Text = "0 registros encontrados";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idPadre";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "NombreCompleto";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ConocidoPor
            // 
            this.ConocidoPor.DataPropertyName = "ConocidoPor";
            this.ConocidoPor.HeaderText = "Conocido Por";
            this.ConocidoPor.Name = "ConocidoPor";
            this.ConocidoPor.ReadOnly = true;
            this.ConocidoPor.Width = 150;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 50;
            // 
            // Género
            // 
            this.Género.DataPropertyName = "Sexo";
            this.Género.HeaderText = "Género";
            this.Género.Name = "Género";
            this.Género.ReadOnly = true;
            // 
            // Dui
            // 
            this.Dui.DataPropertyName = "DUI";
            this.Dui.HeaderText = "Dui";
            this.Dui.Name = "Dui";
            this.Dui.ReadOnly = true;
            // 
            // Nit
            // 
            this.Nit.DataPropertyName = "NumPartida";
            this.Nit.HeaderText = "Nit";
            this.Nit.Name = "Nit";
            this.Nit.ReadOnly = true;
            this.Nit.Width = 150;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Visible = false;
            // 
            // Municipio
            // 
            this.Municipio.DataPropertyName = "Municipio";
            this.Municipio.HeaderText = "Municipio";
            this.Municipio.Name = "Municipio";
            this.Municipio.ReadOnly = true;
            this.Municipio.Visible = false;
            // 
            // Profesión
            // 
            this.Profesión.DataPropertyName = "Profesion";
            this.Profesión.HeaderText = "Profesión";
            this.Profesión.Name = "Profesión";
            this.Profesión.ReadOnly = true;
            this.Profesión.Visible = false;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "Nacionalidad";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            this.Nacionalidad.Visible = false;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Visible = false;
            // 
            // Revisado
            // 
            this.Revisado.DataPropertyName = "Revisado";
            this.Revisado.HeaderText = "Revisado";
            this.Revisado.Name = "Revisado";
            this.Revisado.ReadOnly = true;
            this.Revisado.Visible = false;
            // 
            // Estado_familiar
            // 
            this.Estado_familiar.DataPropertyName = "Estado_familiar";
            this.Estado_familiar.HeaderText = "Estado";
            this.Estado_familiar.Name = "Estado_familiar";
            this.Estado_familiar.ReadOnly = true;
            this.Estado_familiar.Visible = false;
            // 
            // GestionDifuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 563);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgPartidas);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GestionDifuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Personas";
            this.Load += new System.EventHandler(this.GestionDifuntos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartidas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNueva;
        private System.Windows.Forms.ToolStripTextBox txbFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dtgPartidas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConocidoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Género;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revisado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_familiar;
    }
}
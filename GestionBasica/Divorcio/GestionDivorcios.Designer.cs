namespace GestionBasica.Divorcio
{
    partial class GestionDivorcios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDivorcios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNueva = new System.Windows.Forms.ToolStripButton();
            this.txbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txbImprimir = new System.Windows.Forms.ToolStripButton();
            this.dtgPartidas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEsposo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEsposa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_sentencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_ejecutoriada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegimenPatrimonial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreNotario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revisado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMatrimonio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEsposo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEsposa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartidas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificar,
            this.toolStripSeparator1,
            this.btnNueva,
            this.txbFiltrar,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.txbImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(888, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 28);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnNueva
            // 
            this.btnNueva.ForeColor = System.Drawing.Color.White;
            this.btnNueva.Image = ((System.Drawing.Image)(resources.GetObject("btnNueva.Image")));
            this.btnNueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(69, 28);
            this.btnNueva.Text = "Nueva";
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(200, 31);
            this.txbFiltrar.ToolTipText = "Digite el nombre de una de las personas";
            this.txbFiltrar.TextChanged += new System.EventHandler(this.txbFiltrar_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 28);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // txbImprimir
            // 
            this.txbImprimir.ForeColor = System.Drawing.Color.White;
            this.txbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("txbImprimir.Image")));
            this.txbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txbImprimir.Name = "txbImprimir";
            this.txbImprimir.Size = new System.Drawing.Size(108, 28);
            this.txbImprimir.Text = "Vista respaldo";
            this.txbImprimir.Click += new System.EventHandler(this.txbImprimir_Click);
            // 
            // dtgPartidas
            // 
            this.dtgPartidas.AllowUserToAddRows = false;
            this.dtgPartidas.AllowUserToDeleteRows = false;
            this.dtgPartidas.AllowUserToResizeRows = false;
            this.dtgPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Libro,
            this.folio,
            this.NumPartida,
            this.NombreEsposo,
            this.NombreEsposa,
            this.FechaMat,
            this.Fecha_sentencia,
            this.Fecha_ejecutoriada,
            this.RegimenPatrimonial,
            this.Imagen,
            this.Tutela,
            this.NombreNotario,
            this.Revisado,
            this.idMatrimonio,
            this.Juzgado,
            this.idEsposo,
            this.idEsposa});
            this.dtgPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPartidas.Location = new System.Drawing.Point(0, 31);
            this.dtgPartidas.MultiSelect = false;
            this.dtgPartidas.Name = "dtgPartidas";
            this.dtgPartidas.ReadOnly = true;
            this.dtgPartidas.RowHeadersVisible = false;
            this.dtgPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPartidas.Size = new System.Drawing.Size(888, 460);
            this.dtgPartidas.TabIndex = 4;
            this.dtgPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgPartidas_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idDivorcio";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "Libro";
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            this.Libro.Visible = false;
            // 
            // folio
            // 
            this.folio.DataPropertyName = "Folio";
            this.folio.HeaderText = "folio";
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            this.folio.Visible = false;
            // 
            // NumPartida
            // 
            this.NumPartida.DataPropertyName = "NumPartida";
            this.NumPartida.HeaderText = "N°";
            this.NumPartida.Name = "NumPartida";
            this.NumPartida.ReadOnly = true;
            this.NumPartida.Width = 50;
            // 
            // NombreEsposo
            // 
            this.NombreEsposo.DataPropertyName = "Hombre";
            this.NombreEsposo.HeaderText = "Hombre";
            this.NombreEsposo.Name = "NombreEsposo";
            this.NombreEsposo.ReadOnly = true;
            this.NombreEsposo.Width = 250;
            // 
            // NombreEsposa
            // 
            this.NombreEsposa.DataPropertyName = "Mujer";
            this.NombreEsposa.HeaderText = "Mujer";
            this.NombreEsposa.Name = "NombreEsposa";
            this.NombreEsposa.ReadOnly = true;
            this.NombreEsposa.Width = 250;
            // 
            // FechaMat
            // 
            this.FechaMat.DataPropertyName = "Fecha_matrimonio";
            this.FechaMat.HeaderText = "Fecha Matrimonio";
            this.FechaMat.Name = "FechaMat";
            this.FechaMat.ReadOnly = true;
            this.FechaMat.Width = 140;
            // 
            // Fecha_sentencia
            // 
            this.Fecha_sentencia.DataPropertyName = "Fecha_sentencia";
            this.Fecha_sentencia.HeaderText = "Fecha Sentencia";
            this.Fecha_sentencia.Name = "Fecha_sentencia";
            this.Fecha_sentencia.ReadOnly = true;
            this.Fecha_sentencia.Width = 130;
            // 
            // Fecha_ejecutoriada
            // 
            this.Fecha_ejecutoriada.DataPropertyName = "Fecha_ejecutoriada";
            this.Fecha_ejecutoriada.HeaderText = "Fecha ejecutoriada";
            this.Fecha_ejecutoriada.Name = "Fecha_ejecutoriada";
            this.Fecha_ejecutoriada.ReadOnly = true;
            this.Fecha_ejecutoriada.Width = 140;
            // 
            // RegimenPatrimonial
            // 
            this.RegimenPatrimonial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegimenPatrimonial.DataPropertyName = "Regimen_patrimonial";
            this.RegimenPatrimonial.HeaderText = "Regimen Patrimonial";
            this.RegimenPatrimonial.Name = "RegimenPatrimonial";
            this.RegimenPatrimonial.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "Imagen";
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            // 
            // Tutela
            // 
            this.Tutela.DataPropertyName = "Tutela";
            this.Tutela.HeaderText = "Tutela";
            this.Tutela.Name = "Tutela";
            this.Tutela.ReadOnly = true;
            this.Tutela.Visible = false;
            // 
            // NombreNotario
            // 
            this.NombreNotario.DataPropertyName = "NombreNotario";
            this.NombreNotario.HeaderText = "Nombre notario";
            this.NombreNotario.Name = "NombreNotario";
            this.NombreNotario.ReadOnly = true;
            this.NombreNotario.Visible = false;
            // 
            // Revisado
            // 
            this.Revisado.DataPropertyName = "Revisado";
            this.Revisado.HeaderText = "Revisado";
            this.Revisado.Name = "Revisado";
            this.Revisado.ReadOnly = true;
            this.Revisado.Visible = false;
            // 
            // idMatrimonio
            // 
            this.idMatrimonio.DataPropertyName = "idMatrimonio";
            this.idMatrimonio.HeaderText = "idMatrimonio";
            this.idMatrimonio.Name = "idMatrimonio";
            this.idMatrimonio.ReadOnly = true;
            this.idMatrimonio.Visible = false;
            // 
            // Juzgado
            // 
            this.Juzgado.DataPropertyName = "Juzgado";
            this.Juzgado.HeaderText = "Juzgado";
            this.Juzgado.Name = "Juzgado";
            this.Juzgado.ReadOnly = true;
            this.Juzgado.Visible = false;
            // 
            // idEsposo
            // 
            this.idEsposo.DataPropertyName = "idEsposo";
            this.idEsposo.HeaderText = "ides";
            this.idEsposo.Name = "idEsposo";
            this.idEsposo.ReadOnly = true;
            this.idEsposo.Visible = false;
            // 
            // idEsposa
            // 
            this.idEsposa.DataPropertyName = "idEsposa";
            this.idEsposa.HeaderText = "idposa";
            this.idEsposa.Name = "idEsposa";
            this.idEsposa.ReadOnly = true;
            this.idEsposa.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroFilas
            // 
            this.lblNumeroFilas.Name = "lblNumeroFilas";
            this.lblNumeroFilas.Size = new System.Drawing.Size(130, 17);
            this.lblNumeroFilas.Text = "0 registros encontrados";
            // 
            // GestionDivorcios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 491);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgPartidas);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GestionDivorcios";
            this.Text = "Gestión de Divorcios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionDivorcios_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton txbImprimir;
        public System.Windows.Forms.DataGridView dtgPartidas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEsposo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEsposa;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_sentencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_ejecutoriada;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegimenPatrimonial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutela;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreNotario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revisado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatrimonio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEsposo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEsposa;
    }
}
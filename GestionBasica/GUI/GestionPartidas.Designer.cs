namespace GestionBasica.GUI
{
    partial class GestionPartidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPartidas));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNueva = new System.Windows.Forms.ToolStripButton();
            this.txbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txbImprimir = new System.Windows.Forms.ToolStripButton();
            this.dtgPartidas = new System.Windows.Forms.DataGridView();
            this.NumPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInfante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInfante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInformante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInformante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdJefeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1056, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroFilas
            // 
            this.lblNumeroFilas.Name = "lblNumeroFilas";
            this.lblNumeroFilas.Size = new System.Drawing.Size(130, 17);
            this.lblNumeroFilas.Text = "0 registros encontrados";
            // 
            // toolStrip1
            // 
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
            this.toolStrip1.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip1.TabIndex = 1;
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
            this.btnModificar.Click += new System.EventHandler(this.txbModificar_Click);
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
            this.btnNueva.Click += new System.EventHandler(this.txbNueva_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txbImprimir
            // 
            this.txbImprimir.ForeColor = System.Drawing.Color.White;
            this.txbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("txbImprimir.Image")));
            this.txbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txbImprimir.Name = "txbImprimir";
            this.txbImprimir.Size = new System.Drawing.Size(87, 22);
            this.txbImprimir.Text = "Vista previa";
            // 
            // dtgPartidas
            // 
            this.dtgPartidas.AllowUserToAddRows = false;
            this.dtgPartidas.AllowUserToDeleteRows = false;
            this.dtgPartidas.AllowUserToResizeRows = false;
            this.dtgPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPartida,
            this.Ruta,
            this.idPartida,
            this.Folio,
            this.Libro,
            this.IdInfante,
            this.NombreInfante,
            this.FechaNac,
            this.IdMadre,
            this.NombreMadre,
            this.IdPadre,
            this.NombrePadre,
            this.IdInformante,
            this.NombreInformante,
            this.IdJefeRegistro});
            this.dtgPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPartidas.Location = new System.Drawing.Point(0, 25);
            this.dtgPartidas.Name = "dtgPartidas";
            this.dtgPartidas.ReadOnly = true;
            this.dtgPartidas.RowHeadersVisible = false;
            this.dtgPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPartidas.Size = new System.Drawing.Size(1056, 491);
            this.dtgPartidas.TabIndex = 2;
            this.dtgPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgPartidas_CellFormatting);
            // 
            // NumPartida
            // 
            this.NumPartida.DataPropertyName = "NumPartida";
            this.NumPartida.HeaderText = "No";
            this.NumPartida.Name = "NumPartida";
            this.NumPartida.ReadOnly = true;
            this.NumPartida.Width = 50;
            // 
            // Ruta
            // 
            this.Ruta.DataPropertyName = "Ruta";
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            this.Ruta.Visible = false;
            // 
            // idPartida
            // 
            this.idPartida.DataPropertyName = "idPartida";
            this.idPartida.HeaderText = "ID";
            this.idPartida.Name = "idPartida";
            this.idPartida.ReadOnly = true;
            this.idPartida.Visible = false;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "Folio";
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Visible = false;
            this.Folio.Width = 50;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "Libro";
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            this.Libro.Visible = false;
            // 
            // IdInfante
            // 
            this.IdInfante.DataPropertyName = "idInfante";
            this.IdInfante.HeaderText = "IdInfante";
            this.IdInfante.Name = "IdInfante";
            this.IdInfante.ReadOnly = true;
            this.IdInfante.Visible = false;
            // 
            // NombreInfante
            // 
            this.NombreInfante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreInfante.DataPropertyName = "infante";
            this.NombreInfante.HeaderText = "Nombre Infante";
            this.NombreInfante.Name = "NombreInfante";
            this.NombreInfante.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.DataPropertyName = "FechaNac";
            this.FechaNac.HeaderText = "Fecha nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            this.FechaNac.Width = 140;
            // 
            // IdMadre
            // 
            this.IdMadre.DataPropertyName = "idMadre";
            this.IdMadre.HeaderText = "IdMadre";
            this.IdMadre.Name = "IdMadre";
            this.IdMadre.ReadOnly = true;
            this.IdMadre.Visible = false;
            // 
            // NombreMadre
            // 
            this.NombreMadre.DataPropertyName = "madre";
            this.NombreMadre.HeaderText = "Nombre Madre";
            this.NombreMadre.Name = "NombreMadre";
            this.NombreMadre.ReadOnly = true;
            this.NombreMadre.Width = 180;
            // 
            // IdPadre
            // 
            this.IdPadre.DataPropertyName = "idPadre";
            this.IdPadre.HeaderText = "IdPadre";
            this.IdPadre.Name = "IdPadre";
            this.IdPadre.ReadOnly = true;
            this.IdPadre.Visible = false;
            // 
            // NombrePadre
            // 
            this.NombrePadre.DataPropertyName = "padre";
            this.NombrePadre.HeaderText = "Nombre Padre";
            this.NombrePadre.Name = "NombrePadre";
            this.NombrePadre.ReadOnly = true;
            this.NombrePadre.Width = 180;
            // 
            // IdInformante
            // 
            this.IdInformante.DataPropertyName = "idInformante";
            this.IdInformante.HeaderText = "IdInformante";
            this.IdInformante.Name = "IdInformante";
            this.IdInformante.ReadOnly = true;
            this.IdInformante.Visible = false;
            // 
            // NombreInformante
            // 
            this.NombreInformante.DataPropertyName = "informante";
            this.NombreInformante.HeaderText = "Nombre Informante";
            this.NombreInformante.Name = "NombreInformante";
            this.NombreInformante.ReadOnly = true;
            this.NombreInformante.Width = 200;
            // 
            // IdJefeRegistro
            // 
            this.IdJefeRegistro.DataPropertyName = "idJefeRegistro";
            this.IdJefeRegistro.HeaderText = "IdJefeRegistro";
            this.IdJefeRegistro.Name = "IdJefeRegistro";
            this.IdJefeRegistro.ReadOnly = true;
            this.IdJefeRegistro.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2017, 9, 18, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // GestionPartidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 538);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtgPartidas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GestionPartidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Partidas de nacimiento";
            this.Load += new System.EventHandler(this.GestionPartidas_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroFilas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNueva;
        private System.Windows.Forms.ToolStripTextBox txbFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dtgPartidas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton txbImprimir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInfante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInfante;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInformante;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInformante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdJefeRegistro;
    }
}
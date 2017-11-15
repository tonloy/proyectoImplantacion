﻿namespace GestionBasica.GUI
{
    partial class GestionaPartidasEscaneadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionaPartidasEscaneadas));
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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtgPartidas = new System.Windows.Forms.DataGridView();
            this.NumPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDifunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugardefallecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFallecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Causa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInformante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTestigo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testigo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTestigo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testigo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJefeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConyuge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conyuge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFallecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1025, 22);
            this.statusStrip1.TabIndex = 3;
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
            this.txbImprimir,
            this.toolStripSeparator3,
            this.btnGenerar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1025, 25);
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
            this.txbImprimir.Size = new System.Drawing.Size(100, 22);
            this.txbImprimir.Text = "Vista respaldo";
            this.txbImprimir.Click += new System.EventHandler(this.txbImprimir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGenerar
            // 
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(108, 22);
            this.btnGenerar.Text = "Generar partida";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2017, 9, 18, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtgPartidas
            // 
            this.dtgPartidas.AllowUserToAddRows = false;
            this.dtgPartidas.AllowUserToDeleteRows = false;
            this.dtgPartidas.AllowUserToResizeRows = false;
            this.dtgPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPartida,
            this.ID,
            this.Imagen,
            this.idDifunto,
            this.Nombre,
            this.Edad,
            this.Lugardefallecimiento,
            this.FechaFallecimiento,
            this.Causa,
            this.Asistencia,
            this.idMadre,
            this.Madre,
            this.idPadre,
            this.Padre,
            this.idInformante,
            this.Informante,
            this.idTestigo1,
            this.Testigo1,
            this.idTestigo2,
            this.Testigo2,
            this.Folio,
            this.Libro,
            this.idJefeRegistro,
            this.idConyuge,
            this.Conyuge,
            this.idProfesional,
            this.Profesional,
            this.HoraFallecimiento});
            this.dtgPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPartidas.Location = new System.Drawing.Point(0, 25);
            this.dtgPartidas.MultiSelect = false;
            this.dtgPartidas.Name = "dtgPartidas";
            this.dtgPartidas.ReadOnly = true;
            this.dtgPartidas.RowHeadersVisible = false;
            this.dtgPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPartidas.Size = new System.Drawing.Size(1025, 510);
            this.dtgPartidas.TabIndex = 6;
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
            // ID
            // 
            this.ID.DataPropertyName = "idpartidas_defuncion";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "Imagen";
            this.Imagen.HeaderText = "Ruta";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            // 
            // idDifunto
            // 
            this.idDifunto.DataPropertyName = "idFallecido";
            this.idDifunto.HeaderText = "idDifunto";
            this.idDifunto.Name = "idDifunto";
            this.idDifunto.ReadOnly = true;
            this.idDifunto.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Fallecido";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 35;
            // 
            // Lugardefallecimiento
            // 
            this.Lugardefallecimiento.DataPropertyName = "Municipio";
            this.Lugardefallecimiento.HeaderText = "Lugar de fallecimiento";
            this.Lugardefallecimiento.Name = "Lugardefallecimiento";
            this.Lugardefallecimiento.ReadOnly = true;
            this.Lugardefallecimiento.Width = 200;
            // 
            // FechaFallecimiento
            // 
            this.FechaFallecimiento.DataPropertyName = "Fecha_fallecimiento";
            this.FechaFallecimiento.HeaderText = "Fecha fallecimiento";
            this.FechaFallecimiento.Name = "FechaFallecimiento";
            this.FechaFallecimiento.ReadOnly = true;
            this.FechaFallecimiento.Width = 200;
            // 
            // Causa
            // 
            this.Causa.DataPropertyName = "Causa";
            this.Causa.HeaderText = "Causa de muerte";
            this.Causa.Name = "Causa";
            this.Causa.ReadOnly = true;
            this.Causa.Width = 225;
            // 
            // Asistencia
            // 
            this.Asistencia.DataPropertyName = "Asistencia_medica";
            this.Asistencia.HeaderText = "asistencia";
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.ReadOnly = true;
            this.Asistencia.Visible = false;
            // 
            // idMadre
            // 
            this.idMadre.DataPropertyName = "idMadre";
            this.idMadre.HeaderText = "idMadre";
            this.idMadre.Name = "idMadre";
            this.idMadre.ReadOnly = true;
            this.idMadre.Visible = false;
            // 
            // Madre
            // 
            this.Madre.DataPropertyName = "Madre";
            this.Madre.HeaderText = "Madre";
            this.Madre.Name = "Madre";
            this.Madre.ReadOnly = true;
            this.Madre.Visible = false;
            // 
            // idPadre
            // 
            this.idPadre.DataPropertyName = "idPadre";
            this.idPadre.HeaderText = "idPadre";
            this.idPadre.Name = "idPadre";
            this.idPadre.ReadOnly = true;
            this.idPadre.Visible = false;
            // 
            // Padre
            // 
            this.Padre.DataPropertyName = "Padre";
            this.Padre.HeaderText = "Padre";
            this.Padre.Name = "Padre";
            this.Padre.ReadOnly = true;
            this.Padre.Visible = false;
            // 
            // idInformante
            // 
            this.idInformante.DataPropertyName = "idInformante";
            this.idInformante.HeaderText = "idInformante";
            this.idInformante.Name = "idInformante";
            this.idInformante.ReadOnly = true;
            this.idInformante.Visible = false;
            // 
            // Informante
            // 
            this.Informante.DataPropertyName = "Informante";
            this.Informante.HeaderText = "Informante";
            this.Informante.Name = "Informante";
            this.Informante.ReadOnly = true;
            this.Informante.Visible = false;
            // 
            // idTestigo1
            // 
            this.idTestigo1.DataPropertyName = "idTestigo1";
            this.idTestigo1.HeaderText = "idTestigo1";
            this.idTestigo1.Name = "idTestigo1";
            this.idTestigo1.ReadOnly = true;
            this.idTestigo1.Visible = false;
            // 
            // Testigo1
            // 
            this.Testigo1.DataPropertyName = "Testigo1";
            this.Testigo1.HeaderText = "Testigo1";
            this.Testigo1.Name = "Testigo1";
            this.Testigo1.ReadOnly = true;
            this.Testigo1.Visible = false;
            // 
            // idTestigo2
            // 
            this.idTestigo2.DataPropertyName = "idTestigo2";
            this.idTestigo2.HeaderText = "idTestigo2";
            this.idTestigo2.Name = "idTestigo2";
            this.idTestigo2.ReadOnly = true;
            this.idTestigo2.Visible = false;
            // 
            // Testigo2
            // 
            this.Testigo2.DataPropertyName = "Testigo2";
            this.Testigo2.HeaderText = "Testigo2";
            this.Testigo2.Name = "Testigo2";
            this.Testigo2.ReadOnly = true;
            this.Testigo2.Visible = false;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "Folio";
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            this.Folio.Visible = false;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "Libro";
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            this.Libro.Visible = false;
            // 
            // idJefeRegistro
            // 
            this.idJefeRegistro.DataPropertyName = "idJefeRegistro";
            this.idJefeRegistro.HeaderText = "idJefeRegistro";
            this.idJefeRegistro.Name = "idJefeRegistro";
            this.idJefeRegistro.ReadOnly = true;
            this.idJefeRegistro.Visible = false;
            // 
            // idConyuge
            // 
            this.idConyuge.DataPropertyName = "idConyuge";
            this.idConyuge.HeaderText = "idConyuge";
            this.idConyuge.Name = "idConyuge";
            this.idConyuge.ReadOnly = true;
            this.idConyuge.Visible = false;
            // 
            // Conyuge
            // 
            this.Conyuge.DataPropertyName = "Conyuge";
            this.Conyuge.HeaderText = "Conyuge";
            this.Conyuge.Name = "Conyuge";
            this.Conyuge.ReadOnly = true;
            this.Conyuge.Visible = false;
            // 
            // idProfesional
            // 
            this.idProfesional.DataPropertyName = "idProfesional";
            this.idProfesional.HeaderText = "idProfesional";
            this.idProfesional.Name = "idProfesional";
            this.idProfesional.ReadOnly = true;
            this.idProfesional.Visible = false;
            // 
            // Profesional
            // 
            this.Profesional.DataPropertyName = "Profesional";
            this.Profesional.HeaderText = "Profesional";
            this.Profesional.Name = "Profesional";
            this.Profesional.ReadOnly = true;
            this.Profesional.Visible = false;
            // 
            // HoraFallecimiento
            // 
            this.HoraFallecimiento.DataPropertyName = "Hora_fallecimiento";
            this.HoraFallecimiento.HeaderText = "HoraFallecimiento";
            this.HoraFallecimiento.Name = "HoraFallecimiento";
            this.HoraFallecimiento.ReadOnly = true;
            this.HoraFallecimiento.Visible = false;
            // 
            // GestionaPartidasEscaneadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 557);
            this.Controls.Add(this.dtgPartidas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GestionaPartidasEscaneadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Partidas de Defunción";
            this.Load += new System.EventHandler(this.GestionaPartidasEscaneadas_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton txbImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dtgPartidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDifunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugardefallecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFallecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Causa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInformante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Informante;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTestigo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Testigo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTestigo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Testigo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJefeRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConyuge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conyuge;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFallecimiento;
    }
}
﻿namespace GestionBasica.GUI.Matrimonio
{
    partial class GestionFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionFuncionarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txbNueva = new System.Windows.Forms.ToolStripButton();
            this.txbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtgFuncionarios = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.IdPadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConocidoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProfesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txbModificar,
            this.toolStripSeparator1,
            this.txbNueva,
            this.txbFiltrar,
            this.toolStripLabel1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(773, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txbModificar
            // 
            this.txbModificar.ForeColor = System.Drawing.Color.White;
            this.txbModificar.Image = ((System.Drawing.Image)(resources.GetObject("txbModificar.Image")));
            this.txbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txbModificar.Name = "txbModificar";
            this.txbModificar.Size = new System.Drawing.Size(86, 28);
            this.txbModificar.Text = "Modificar";
            this.txbModificar.Click += new System.EventHandler(this.txbModificar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // txbNueva
            // 
            this.txbNueva.ForeColor = System.Drawing.Color.White;
            this.txbNueva.Image = ((System.Drawing.Image)(resources.GetObject("txbNueva.Image")));
            this.txbNueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txbNueva.Name = "txbNueva";
            this.txbNueva.Size = new System.Drawing.Size(110, 28);
            this.txbNueva.Text = "Agregar Padre";
            this.txbNueva.Click += new System.EventHandler(this.txbNueva_Click);
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(200, 31);
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
            // dtgFuncionarios
            // 
            this.dtgFuncionarios.AllowUserToAddRows = false;
            this.dtgFuncionarios.AllowUserToDeleteRows = false;
            this.dtgFuncionarios.AllowUserToResizeRows = false;
            this.dtgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPadre,
            this.Parentesco,
            this.Observaciones,
            this.NombreCompleto,
            this.ConocidoPor,
            this.Edad,
            this.Domicilio,
            this.Nacionalidad,
            this.Dui,
            this.NumPartida,
            this.Departamento,
            this.idMunicipio,
            this.Municipio,
            this.IdProfesion,
            this.Profesion,
            this.FechaNac,
            this.Rubrica,
            this.Nit});
            this.dtgFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgFuncionarios.Location = new System.Drawing.Point(0, 31);
            this.dtgFuncionarios.MultiSelect = false;
            this.dtgFuncionarios.Name = "dtgFuncionarios";
            this.dtgFuncionarios.ReadOnly = true;
            this.dtgFuncionarios.RowHeadersVisible = false;
            this.dtgFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFuncionarios.Size = new System.Drawing.Size(773, 413);
            this.dtgFuncionarios.TabIndex = 6;
            this.dtgFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionarios_CellDoubleClick);
            this.dtgFuncionarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgFuncionarios_CellFormatting);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(773, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroFilas
            // 
            this.lblNumeroFilas.Name = "lblNumeroFilas";
            this.lblNumeroFilas.Size = new System.Drawing.Size(130, 17);
            this.lblNumeroFilas.Text = "0 registros encontrados";
            // 
            // IdPadre
            // 
            this.IdPadre.DataPropertyName = "idPadre";
            this.IdPadre.HeaderText = "ID";
            this.IdPadre.Name = "IdPadre";
            this.IdPadre.ReadOnly = true;
            this.IdPadre.Width = 60;
            // 
            // Parentesco
            // 
            this.Parentesco.DataPropertyName = "Parentesco";
            this.Parentesco.HeaderText = "Parentesco";
            this.Parentesco.Name = "Parentesco";
            this.Parentesco.ReadOnly = true;
            this.Parentesco.Visible = false;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Visible = false;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // ConocidoPor
            // 
            this.ConocidoPor.DataPropertyName = "ConocidoPor";
            this.ConocidoPor.HeaderText = "Conocido por";
            this.ConocidoPor.Name = "ConocidoPor";
            this.ConocidoPor.ReadOnly = true;
            this.ConocidoPor.Visible = false;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Visible = false;
            this.Edad.Width = 50;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Visible = false;
            this.Domicilio.Width = 200;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "Nacionalidad";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            this.Nacionalidad.Visible = false;
            // 
            // Dui
            // 
            this.Dui.DataPropertyName = "DUI";
            this.Dui.HeaderText = "DUI";
            this.Dui.Name = "Dui";
            this.Dui.ReadOnly = true;
            this.Dui.Visible = false;
            this.Dui.Width = 85;
            // 
            // NumPartida
            // 
            this.NumPartida.DataPropertyName = "NumPartida";
            this.NumPartida.HeaderText = "N° Partida";
            this.NumPartida.Name = "NumPartida";
            this.NumPartida.ReadOnly = true;
            this.NumPartida.Visible = false;
            this.NumPartida.Width = 85;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Visible = false;
            // 
            // idMunicipio
            // 
            this.idMunicipio.DataPropertyName = "idMunicipio";
            this.idMunicipio.HeaderText = "IdMunicipio";
            this.idMunicipio.Name = "idMunicipio";
            this.idMunicipio.ReadOnly = true;
            this.idMunicipio.Visible = false;
            // 
            // Municipio
            // 
            this.Municipio.DataPropertyName = "Municipio";
            this.Municipio.HeaderText = "Municipio";
            this.Municipio.Name = "Municipio";
            this.Municipio.ReadOnly = true;
            this.Municipio.Visible = false;
            this.Municipio.Width = 125;
            // 
            // IdProfesion
            // 
            this.IdProfesion.DataPropertyName = "idProfesion";
            this.IdProfesion.HeaderText = "IdProfesion";
            this.IdProfesion.Name = "IdProfesion";
            this.IdProfesion.ReadOnly = true;
            this.IdProfesion.Visible = false;
            // 
            // Profesion
            // 
            this.Profesion.DataPropertyName = "Profesion";
            this.Profesion.HeaderText = "Profesión";
            this.Profesion.Name = "Profesion";
            this.Profesion.ReadOnly = true;
            this.Profesion.Width = 300;
            // 
            // FechaNac
            // 
            this.FechaNac.DataPropertyName = "FechaNac";
            this.FechaNac.HeaderText = "FechaNac";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            this.FechaNac.Visible = false;
            // 
            // Rubrica
            // 
            this.Rubrica.DataPropertyName = "Rubrica";
            this.Rubrica.HeaderText = "Rubrica";
            this.Rubrica.Name = "Rubrica";
            this.Rubrica.ReadOnly = true;
            this.Rubrica.Visible = false;
            // 
            // Nit
            // 
            this.Nit.DataPropertyName = "Nit";
            this.Nit.HeaderText = "Nit";
            this.Nit.Name = "Nit";
            this.Nit.ReadOnly = true;
            this.Nit.Visible = false;
            // 
            // GestionFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 444);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgFuncionarios);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Funcionarios";
            this.Load += new System.EventHandler(this.GestionFuncionarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton txbModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton txbNueva;
        private System.Windows.Forms.ToolStripTextBox txbFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dtgFuncionarios;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parentesco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConocidoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProfesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nit;
    }
}
﻿namespace GestionBasica.GUI.Matrimonio
{
    partial class GestionPdasMatrimonio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPdasMatrimonio));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dtgPartidas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEsposo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEsposa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCasada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testigo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testigo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegimenPatrimonial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNumeroFilas = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnNueva = new System.Windows.Forms.ToolStripButton();
            this.txbImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
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
            this.txbImprimir,
            this.toolStripSeparator3,
            this.btnGenerar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1245, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(299, 32);
            this.txbFiltrar.TextChanged += new System.EventHandler(this.txbFiltrar_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 29);
            this.toolStripLabel1.Text = "Buscar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // dtgPartidas
            // 
            this.dtgPartidas.AllowUserToAddRows = false;
            this.dtgPartidas.AllowUserToDeleteRows = false;
            this.dtgPartidas.AllowUserToResizeRows = false;
            this.dtgPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NumPda,
            this.NombreEsposo,
            this.NombreEsposa,
            this.ApellidoCasada,
            this.Testigo1,
            this.Testigo2,
            this.FechaMat,
            this.RegimenPatrimonial});
            this.dtgPartidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPartidas.Location = new System.Drawing.Point(0, 32);
            this.dtgPartidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgPartidas.MultiSelect = false;
            this.dtgPartidas.Name = "dtgPartidas";
            this.dtgPartidas.ReadOnly = true;
            this.dtgPartidas.RowHeadersVisible = false;
            this.dtgPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPartidas.Size = new System.Drawing.Size(1245, 360);
            this.dtgPartidas.TabIndex = 3;
            this.dtgPartidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPartidas_CellContentClick);
            this.dtgPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgPartidas_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idpartida_matrimonio";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NumPda
            // 
            this.NumPda.DataPropertyName = "NumPartida";
            this.NumPda.HeaderText = "N°";
            this.NumPda.Name = "NumPda";
            this.NumPda.ReadOnly = true;
            this.NumPda.Width = 35;
            // 
            // NombreEsposo
            // 
            this.NombreEsposo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreEsposo.DataPropertyName = "Esposo";
            this.NombreEsposo.HeaderText = "Esposo";
            this.NombreEsposo.Name = "NombreEsposo";
            this.NombreEsposo.ReadOnly = true;
            // 
            // NombreEsposa
            // 
            this.NombreEsposa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreEsposa.DataPropertyName = "Esposa";
            this.NombreEsposa.HeaderText = "Esposa";
            this.NombreEsposa.Name = "NombreEsposa";
            this.NombreEsposa.ReadOnly = true;
            // 
            // ApellidoCasada
            // 
            this.ApellidoCasada.DataPropertyName = "ApellidoCasada";
            this.ApellidoCasada.HeaderText = "Apellido Casada";
            this.ApellidoCasada.Name = "ApellidoCasada";
            this.ApellidoCasada.ReadOnly = true;
            this.ApellidoCasada.Width = 135;
            // 
            // Testigo1
            // 
            this.Testigo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Testigo1.DataPropertyName = "Testigo";
            this.Testigo1.HeaderText = "Primer Testigo";
            this.Testigo1.Name = "Testigo1";
            this.Testigo1.ReadOnly = true;
            // 
            // Testigo2
            // 
            this.Testigo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Testigo2.DataPropertyName = "Testigo2";
            this.Testigo2.HeaderText = "Segundo Testigo";
            this.Testigo2.Name = "Testigo2";
            this.Testigo2.ReadOnly = true;
            // 
            // FechaMat
            // 
            this.FechaMat.DataPropertyName = "Fecha_matrimonio";
            this.FechaMat.HeaderText = "Fecha Matrimonio";
            this.FechaMat.Name = "FechaMat";
            this.FechaMat.ReadOnly = true;
            this.FechaMat.Width = 140;
            // 
            // RegimenPatrimonial
            // 
            this.RegimenPatrimonial.DataPropertyName = "Regimen_patrimonial";
            this.RegimenPatrimonial.HeaderText = "Regimen Patrimonial";
            this.RegimenPatrimonial.Name = "RegimenPatrimonial";
            this.RegimenPatrimonial.ReadOnly = true;
            this.RegimenPatrimonial.Width = 140;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumeroFilas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1245, 30);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNumeroFilas
            // 
            this.lblNumeroFilas.Name = "lblNumeroFilas";
            this.lblNumeroFilas.Size = new System.Drawing.Size(200, 25);
            this.lblNumeroFilas.Text = "0 registros encontrados";
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 29);
            this.btnModificar.Text = "Marginar";
            // 
            // btnNueva
            // 
            this.btnNueva.ForeColor = System.Drawing.Color.White;
            this.btnNueva.Image = ((System.Drawing.Image)(resources.GetObject("btnNueva.Image")));
            this.btnNueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(90, 29);
            this.btnNueva.Text = "Nueva";
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // txbImprimir
            // 
            this.txbImprimir.ForeColor = System.Drawing.Color.White;
            this.txbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("txbImprimir.Image")));
            this.txbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txbImprimir.Name = "txbImprimir";
            this.txbImprimir.Size = new System.Drawing.Size(152, 29);
            this.txbImprimir.Text = "Vista respaldo";
            // 
            // btnGenerar
            // 
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(162, 29);
            this.btnGenerar.Text = "Generar partida";
            // 
            // GestionPdasMatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 392);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgPartidas);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GestionPdasMatrimonio";
            this.Text = "GestionPdasMatrimonio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionPdasMatrimonio_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.DataGridView dtgPartidas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNumeroFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPda;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEsposo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEsposa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCasada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Testigo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Testigo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegimenPatrimonial;
    }
}
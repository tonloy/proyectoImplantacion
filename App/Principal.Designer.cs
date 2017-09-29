﻿namespace App
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPartidaDeNacimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidasEscaneadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNombreEmpleado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.conectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.desconectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SegundoPlano = new System.ComponentModel.BackgroundWorker();
            this.tmpConexion = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.buscarPartidaDeNacimientoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEmpleadosToolStripMenuItem,
            this.gestionarUsuariosToolStripMenuItem});
            this.gestionarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gestionarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // gestionarEmpleadosToolStripMenuItem
            // 
            this.gestionarEmpleadosToolStripMenuItem.Name = "gestionarEmpleadosToolStripMenuItem";
            this.gestionarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gestionarEmpleadosToolStripMenuItem.Text = "Empleados";
            this.gestionarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestionarEmpleadosToolStripMenuItem_Click);
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gestionarUsuariosToolStripMenuItem.Text = "Usuarios";
            this.gestionarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuariosToolStripMenuItem_Click);
            // 
            // buscarPartidaDeNacimientoToolStripMenuItem
            // 
            this.buscarPartidaDeNacimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPartidaToolStripMenuItem,
            this.partidasEscaneadasToolStripMenuItem});
            this.buscarPartidaDeNacimientoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buscarPartidaDeNacimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarPartidaDeNacimientoToolStripMenuItem.Name = "buscarPartidaDeNacimientoToolStripMenuItem";
            this.buscarPartidaDeNacimientoToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.buscarPartidaDeNacimientoToolStripMenuItem.Text = "Partidas de nacimiento";
            // 
            // agregarPartidaToolStripMenuItem
            // 
            this.agregarPartidaToolStripMenuItem.Name = "agregarPartidaToolStripMenuItem";
            this.agregarPartidaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarPartidaToolStripMenuItem.Text = "Gestionar partidas";
            this.agregarPartidaToolStripMenuItem.Click += new System.EventHandler(this.agregarPartidaToolStripMenuItem_Click);
            // 
            // partidasEscaneadasToolStripMenuItem
            // 
            this.partidasEscaneadasToolStripMenuItem.Name = "partidasEscaneadasToolStripMenuItem";
            this.partidasEscaneadasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.partidasEscaneadasToolStripMenuItem.Text = "Partidas escaneadas";
            this.partidasEscaneadasToolStripMenuItem.Click += new System.EventHandler(this.partidasEscaneadasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeOperacionesToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeOperacionesToolStripMenuItem
            // 
            this.reporteDeOperacionesToolStripMenuItem.Name = "reporteDeOperacionesToolStripMenuItem";
            this.reporteDeOperacionesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.reporteDeOperacionesToolStripMenuItem.Text = "Reporte de operaciones";
            this.reporteDeOperacionesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeOperacionesToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisosToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.configuraciónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.permisosToolStripMenuItem.Text = "Permisos";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario,
            this.toolStripStatusLabel2,
            this.lblNombreEmpleado,
            this.toolStripStatusLabel3,
            this.conectado,
            this.desconectado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(817, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0, 3, 7, 2);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 17);
            this.lblUsuario.Text = "lblUsuario";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.Image")));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(142, 17);
            this.toolStripStatusLabel2.Text = "Nombre de empleado:";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(0, 3, 7, 2);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(73, 17);
            this.lblNombreEmpleado.Text = "lblEmpleado";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel3.Text = "Estado: ";
            // 
            // conectado
            // 
            this.conectado.Image = ((System.Drawing.Image)(resources.GetObject("conectado.Image")));
            this.conectado.Name = "conectado";
            this.conectado.Size = new System.Drawing.Size(81, 17);
            this.conectado.Text = "Conectado";
            // 
            // desconectado
            // 
            this.desconectado.Image = ((System.Drawing.Image)(resources.GetObject("desconectado.Image")));
            this.desconectado.Name = "desconectado";
            this.desconectado.Size = new System.Drawing.Size(98, 17);
            this.desconectado.Text = "Desconectado";
            this.desconectado.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 508);
            this.panel1.TabIndex = 4;
            // 
            // SegundoPlano
            // 
            this.SegundoPlano.WorkerReportsProgress = true;
            this.SegundoPlano.WorkerSupportsCancellation = true;
            this.SegundoPlano.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SegundoPlano_DoWork);
            this.SegundoPlano.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SegundoPlano_ProgressChanged);
            this.SegundoPlano.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SegundoPlano_RunWorkerCompleted);
            // 
            // tmpConexion
            // 
            this.tmpConexion.Interval = 60000;
            this.tmpConexion.Tick += new System.EventHandler(this.tmpConexion_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Registro Familiar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPartidaDeNacimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem partidasEscaneadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblNombreEmpleado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel conectado;
        private System.Windows.Forms.ToolStripStatusLabel desconectado;
        private System.ComponentModel.BackgroundWorker SegundoPlano;
        private System.Windows.Forms.Timer tmpConexion;
    }
}
namespace App
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
            this.profesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.causasDeMuerteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPartidaDeNacimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidasEscaneadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidasDeMatrimonioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidasDeDivorcioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marginacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidasDeNacimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidasDeDefunciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEstadísticasDeNacimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeDefuncionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNombreEmpleado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.conectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.desconectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.SegundoPlano = new System.ComponentModel.BackgroundWorker();
            this.tmpConexion = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juzgadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.buscarPartidaDeNacimientoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.auditoríaToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1226, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEmpleadosToolStripMenuItem,
            this.gestionarUsuariosToolStripMenuItem,
            this.profesionesToolStripMenuItem,
            this.nacionalidadesToolStripMenuItem,
            this.causasDeMuerteToolStripMenuItem,
            this.cantonesToolStripMenuItem,
            this.tarifasToolStripMenuItem,
            this.juzgadosToolStripMenuItem});
            this.gestionarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gestionarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(117, 34);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // gestionarEmpleadosToolStripMenuItem
            // 
            this.gestionarEmpleadosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.gestionarEmpleadosToolStripMenuItem.Name = "gestionarEmpleadosToolStripMenuItem";
            this.gestionarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.gestionarEmpleadosToolStripMenuItem.Text = "Empleados";
            this.gestionarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestionarEmpleadosToolStripMenuItem_Click);
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.gestionarUsuariosToolStripMenuItem.Text = "Usuarios";
            this.gestionarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuariosToolStripMenuItem_Click);
            // 
            // profesionesToolStripMenuItem
            // 
            this.profesionesToolStripMenuItem.Name = "profesionesToolStripMenuItem";
            this.profesionesToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.profesionesToolStripMenuItem.Text = "Profesiones";
            this.profesionesToolStripMenuItem.Click += new System.EventHandler(this.profesionesToolStripMenuItem_Click);
            // 
            // nacionalidadesToolStripMenuItem
            // 
            this.nacionalidadesToolStripMenuItem.Name = "nacionalidadesToolStripMenuItem";
            this.nacionalidadesToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.nacionalidadesToolStripMenuItem.Text = "Nacionalidades";
            this.nacionalidadesToolStripMenuItem.Click += new System.EventHandler(this.nacionalidadesToolStripMenuItem_Click);
            // 
            // causasDeMuerteToolStripMenuItem
            // 
            this.causasDeMuerteToolStripMenuItem.Name = "causasDeMuerteToolStripMenuItem";
            this.causasDeMuerteToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.causasDeMuerteToolStripMenuItem.Text = "Causas de muerte";
            this.causasDeMuerteToolStripMenuItem.Click += new System.EventHandler(this.causasDeMuerteToolStripMenuItem_Click);
            // 
            // cantonesToolStripMenuItem
            // 
            this.cantonesToolStripMenuItem.Name = "cantonesToolStripMenuItem";
            this.cantonesToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.cantonesToolStripMenuItem.Text = "Cantones";
            this.cantonesToolStripMenuItem.Click += new System.EventHandler(this.cantonesToolStripMenuItem_Click);
            // 
            // tarifasToolStripMenuItem
            // 
            this.tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            this.tarifasToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.tarifasToolStripMenuItem.Text = "Tarifas";
            this.tarifasToolStripMenuItem.Click += new System.EventHandler(this.tarifasToolStripMenuItem_Click);
            // 
            // buscarPartidaDeNacimientoToolStripMenuItem
            // 
            this.buscarPartidaDeNacimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPartidaToolStripMenuItem,
            this.partidasEscaneadasToolStripMenuItem,
            this.partidasDeMatrimonioToolStripMenuItem,
            this.partidasDeDivorcioToolStripMenuItem,
            this.marginacionesToolStripMenuItem});
            this.buscarPartidaDeNacimientoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buscarPartidaDeNacimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarPartidaDeNacimientoToolStripMenuItem.Name = "buscarPartidaDeNacimientoToolStripMenuItem";
            this.buscarPartidaDeNacimientoToolStripMenuItem.Size = new System.Drawing.Size(100, 34);
            this.buscarPartidaDeNacimientoToolStripMenuItem.Text = "Partidas";
            // 
            // agregarPartidaToolStripMenuItem
            // 
            this.agregarPartidaToolStripMenuItem.Name = "agregarPartidaToolStripMenuItem";
            this.agregarPartidaToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.agregarPartidaToolStripMenuItem.Text = "Partidas de nacimiento";
            this.agregarPartidaToolStripMenuItem.Click += new System.EventHandler(this.agregarPartidaToolStripMenuItem_Click);
            // 
            // partidasEscaneadasToolStripMenuItem
            // 
            this.partidasEscaneadasToolStripMenuItem.Name = "partidasEscaneadasToolStripMenuItem";
            this.partidasEscaneadasToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.partidasEscaneadasToolStripMenuItem.Text = "Partidas de defunción";
            this.partidasEscaneadasToolStripMenuItem.Click += new System.EventHandler(this.partidasEscaneadasToolStripMenuItem_Click);
            // 
            // partidasDeMatrimonioToolStripMenuItem
            // 
            this.partidasDeMatrimonioToolStripMenuItem.Name = "partidasDeMatrimonioToolStripMenuItem";
            this.partidasDeMatrimonioToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.partidasDeMatrimonioToolStripMenuItem.Text = "Partidas de matrimonio";
            this.partidasDeMatrimonioToolStripMenuItem.Click += new System.EventHandler(this.partidasDeMatrimonioToolStripMenuItem_Click);
            // 
            // partidasDeDivorcioToolStripMenuItem
            // 
            this.partidasDeDivorcioToolStripMenuItem.Name = "partidasDeDivorcioToolStripMenuItem";
            this.partidasDeDivorcioToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.partidasDeDivorcioToolStripMenuItem.Text = "Partidas de divorcio";
            this.partidasDeDivorcioToolStripMenuItem.Click += new System.EventHandler(this.partidasDeDivorcioToolStripMenuItem_Click);
            // 
            // marginacionesToolStripMenuItem
            // 
            this.marginacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidasDeNacimientoToolStripMenuItem,
            this.partidasDeDefunciónToolStripMenuItem});
            this.marginacionesToolStripMenuItem.Name = "marginacionesToolStripMenuItem";
            this.marginacionesToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.marginacionesToolStripMenuItem.Text = "Marginaciones";
            // 
            // partidasDeNacimientoToolStripMenuItem
            // 
            this.partidasDeNacimientoToolStripMenuItem.Name = "partidasDeNacimientoToolStripMenuItem";
            this.partidasDeNacimientoToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.partidasDeNacimientoToolStripMenuItem.Text = "Partidas de nacimiento";
            this.partidasDeNacimientoToolStripMenuItem.Click += new System.EventHandler(this.partidasDeNacimientoToolStripMenuItem_Click);
            // 
            // partidasDeDefunciónToolStripMenuItem
            // 
            this.partidasDeDefunciónToolStripMenuItem.Name = "partidasDeDefunciónToolStripMenuItem";
            this.partidasDeDefunciónToolStripMenuItem.Size = new System.Drawing.Size(316, 34);
            this.partidasDeDefunciónToolStripMenuItem.Text = "Partidas de defunción";
            this.partidasDeDefunciónToolStripMenuItem.Click += new System.EventHandler(this.partidasDeDefunciónToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeOperacionesToolStripMenuItem,
            this.reporteDeEstadísticasDeNacimientosToolStripMenuItem,
            this.reporteDeDefuncionesToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(111, 34);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeOperacionesToolStripMenuItem
            // 
            this.reporteDeOperacionesToolStripMenuItem.Name = "reporteDeOperacionesToolStripMenuItem";
            this.reporteDeOperacionesToolStripMenuItem.Size = new System.Drawing.Size(472, 34);
            this.reporteDeOperacionesToolStripMenuItem.Text = "Reporte de operaciones";
            this.reporteDeOperacionesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeOperacionesToolStripMenuItem_Click);
            // 
            // reporteDeEstadísticasDeNacimientosToolStripMenuItem
            // 
            this.reporteDeEstadísticasDeNacimientosToolStripMenuItem.Name = "reporteDeEstadísticasDeNacimientosToolStripMenuItem";
            this.reporteDeEstadísticasDeNacimientosToolStripMenuItem.Size = new System.Drawing.Size(472, 34);
            this.reporteDeEstadísticasDeNacimientosToolStripMenuItem.Text = "Reporte de estadísticas de nacimientos";
            this.reporteDeEstadísticasDeNacimientosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeEstadísticasDeNacimientosToolStripMenuItem_Click);
            // 
            // reporteDeDefuncionesToolStripMenuItem
            // 
            this.reporteDeDefuncionesToolStripMenuItem.Name = "reporteDeDefuncionesToolStripMenuItem";
            this.reporteDeDefuncionesToolStripMenuItem.Size = new System.Drawing.Size(472, 34);
            this.reporteDeDefuncionesToolStripMenuItem.Text = "Reporte de defunciones";
            this.reporteDeDefuncionesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeDefuncionesToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisosToolStripMenuItem,
            this.respaldarBaseDeDatosToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.configuraciónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.permisosToolStripMenuItem.Text = "Permisos";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // respaldarBaseDeDatosToolStripMenuItem
            // 
            this.respaldarBaseDeDatosToolStripMenuItem.Name = "respaldarBaseDeDatosToolStripMenuItem";
            this.respaldarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.respaldarBaseDeDatosToolStripMenuItem.Text = "Respaldar base de datos";
            this.respaldarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.respaldarBaseDeDatosToolStripMenuItem_Click);
            // 
            // auditoríaToolStripMenuItem
            // 
            this.auditoríaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAccionesToolStripMenuItem});
            this.auditoríaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.auditoríaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.auditoríaToolStripMenuItem.Name = "auditoríaToolStripMenuItem";
            this.auditoríaToolStripMenuItem.Size = new System.Drawing.Size(113, 34);
            this.auditoríaToolStripMenuItem.Text = "Auditoría";
            // 
            // verAccionesToolStripMenuItem
            // 
            this.verAccionesToolStripMenuItem.Name = "verAccionesToolStripMenuItem";
            this.verAccionesToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.verAccionesToolStripMenuItem.Text = "Ver acciones";
            this.verAccionesToolStripMenuItem.Click += new System.EventHandler(this.verAccionesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(86, 34);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario,
            this.toolStripStatusLabel2,
            this.lblNombreEmpleado,
            this.toolStripStatusLabel3,
            this.conectado,
            this.desconectado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 742);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1226, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 25);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0, 3, 7, 2);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(91, 25);
            this.lblUsuario.Text = "lblUsuario";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.Image")));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(216, 25);
            this.toolStripStatusLabel2.Text = "Nombre de empleado:";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(0, 3, 7, 2);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(111, 25);
            this.lblNombreEmpleado.Text = "lblEmpleado";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(75, 25);
            this.toolStripStatusLabel3.Text = "Estado: ";
            // 
            // conectado
            // 
            this.conectado.Image = ((System.Drawing.Image)(resources.GetObject("conectado.Image")));
            this.conectado.Name = "conectado";
            this.conectado.Size = new System.Drawing.Size(122, 25);
            this.conectado.Text = "Conectado";
            // 
            // desconectado
            // 
            this.desconectado.Image = ((System.Drawing.Image)(resources.GetObject("desconectado.Image")));
            this.desconectado.Name = "desconectado";
            this.desconectado.Size = new System.Drawing.Size(149, 25);
            this.desconectado.Text = "Desconectado";
            this.desconectado.Visible = false;
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
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 702);
            this.panel1.TabIndex = 4;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // juzgadosToolStripMenuItem
            // 
            this.juzgadosToolStripMenuItem.Name = "juzgadosToolStripMenuItem";
            this.juzgadosToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.juzgadosToolStripMenuItem.Text = "Juzgados";
            this.juzgadosToolStripMenuItem.Click += new System.EventHandler(this.juzgadosToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ToolStripMenuItem profesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidasDeMatrimonioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidasDeDivorcioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem causasDeMuerteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marginacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidasDeNacimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidasDeDefunciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEstadísticasDeNacimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeDefuncionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juzgadosToolStripMenuItem;
    }
}
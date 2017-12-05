namespace GestionBasica.Reportes
{
    partial class VisorReporteOperaciones
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rbtnDivorcios = new System.Windows.Forms.RadioButton();
            this.rbtnDefunciones = new System.Windows.Forms.RadioButton();
            this.rbtnMatrimonios = new System.Windows.Forms.RadioButton();
            this.rbtnNacimientos = new System.Windows.Forms.RadioButton();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.crvOperaciones = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rbtnDivorcios);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnDefunciones);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnMatrimonios);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnNacimientos);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFinal);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtpInicial);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crvOperaciones);
            this.splitContainer1.Size = new System.Drawing.Size(892, 537);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 1;
            // 
            // rbtnDivorcios
            // 
            this.rbtnDivorcios.AutoSize = true;
            this.rbtnDivorcios.Location = new System.Drawing.Point(15, 215);
            this.rbtnDivorcios.Name = "rbtnDivorcios";
            this.rbtnDivorcios.Size = new System.Drawing.Size(118, 17);
            this.rbtnDivorcios.TabIndex = 8;
            this.rbtnDivorcios.Text = "Partidas de divorcio";
            this.rbtnDivorcios.UseVisualStyleBackColor = true;
            this.rbtnDivorcios.CheckedChanged += new System.EventHandler(this.rbtnDivorcios_CheckedChanged);
            // 
            // rbtnDefunciones
            // 
            this.rbtnDefunciones.AutoSize = true;
            this.rbtnDefunciones.Location = new System.Drawing.Point(15, 169);
            this.rbtnDefunciones.Name = "rbtnDefunciones";
            this.rbtnDefunciones.Size = new System.Drawing.Size(128, 17);
            this.rbtnDefunciones.TabIndex = 7;
            this.rbtnDefunciones.Text = "Partidas de defunción";
            this.rbtnDefunciones.UseVisualStyleBackColor = true;
            this.rbtnDefunciones.CheckedChanged += new System.EventHandler(this.rbtnDefunciones_CheckedChanged);
            // 
            // rbtnMatrimonios
            // 
            this.rbtnMatrimonios.AutoSize = true;
            this.rbtnMatrimonios.Location = new System.Drawing.Point(15, 192);
            this.rbtnMatrimonios.Name = "rbtnMatrimonios";
            this.rbtnMatrimonios.Size = new System.Drawing.Size(131, 17);
            this.rbtnMatrimonios.TabIndex = 6;
            this.rbtnMatrimonios.Text = "Partidas de matrimonio";
            this.rbtnMatrimonios.UseVisualStyleBackColor = true;
            this.rbtnMatrimonios.CheckedChanged += new System.EventHandler(this.rbtnMatrimonios_CheckedChanged);
            // 
            // rbtnNacimientos
            // 
            this.rbtnNacimientos.AutoSize = true;
            this.rbtnNacimientos.Checked = true;
            this.rbtnNacimientos.Location = new System.Drawing.Point(15, 146);
            this.rbtnNacimientos.Name = "rbtnNacimientos";
            this.rbtnNacimientos.Size = new System.Drawing.Size(132, 17);
            this.rbtnNacimientos.TabIndex = 5;
            this.rbtnNacimientos.TabStop = true;
            this.rbtnNacimientos.Text = "Partidas de nacimiento";
            this.rbtnNacimientos.UseVisualStyleBackColor = true;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "yyyy-MM-dd H:mm:ss";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(15, 110);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 4;
            this.dtpFinal.Value = new System.DateTime(2017, 11, 25, 23, 59, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha final:";
            // 
            // dtpInicial
            // 
            this.dtpInicial.CustomFormat = "yyyy-MM-dd H:mm:ss";
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(15, 55);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpInicial.TabIndex = 2;
            this.dtpInicial.Value = new System.DateTime(2017, 11, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha inicial:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(140, 245);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // crvOperaciones
            // 
            this.crvOperaciones.ActiveViewIndex = -1;
            this.crvOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOperaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvOperaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvOperaciones.Location = new System.Drawing.Point(0, 0);
            this.crvOperaciones.Name = "crvOperaciones";
            this.crvOperaciones.Size = new System.Drawing.Size(641, 537);
            this.crvOperaciones.TabIndex = 0;
            this.crvOperaciones.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorReporteOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 537);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VisorReporteOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor de Reporte de Operaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOperaciones;
        private System.Windows.Forms.RadioButton rbtnDivorcios;
        private System.Windows.Forms.RadioButton rbtnDefunciones;
        private System.Windows.Forms.RadioButton rbtnMatrimonios;
        private System.Windows.Forms.RadioButton rbtnNacimientos;
    }
}
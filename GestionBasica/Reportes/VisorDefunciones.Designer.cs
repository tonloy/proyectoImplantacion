namespace GestionBasica.Reportes
{
    partial class VisorDefunciones
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
            this.cbxCausas = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.crvNacimientos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
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
            this.splitContainer1.Panel1.Controls.Add(this.cbxCausas);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFinal);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtpInicial);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crvNacimientos);
            this.splitContainer1.Size = new System.Drawing.Size(878, 555);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbxCausas
            // 
            this.cbxCausas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCausas.Enabled = false;
            this.cbxCausas.FormattingEnabled = true;
            this.cbxCausas.Location = new System.Drawing.Point(24, 193);
            this.cbxCausas.Name = "cbxCausas";
            this.cbxCausas.Size = new System.Drawing.Size(200, 21);
            this.cbxCausas.TabIndex = 66;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(53, 154);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "¿Causa de muerte específica?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "yyyy-MM-dd";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(24, 113);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 9;
            this.dtpFinal.Value = new System.DateTime(2017, 11, 25, 23, 59, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha final:";
            // 
            // dtpInicial
            // 
            this.dtpInicial.CustomFormat = "yyyy-MM-dd";
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(24, 58);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpInicial.TabIndex = 7;
            this.dtpInicial.Value = new System.DateTime(2017, 11, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha inicial:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(149, 238);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // crvNacimientos
            // 
            this.crvNacimientos.ActiveViewIndex = -1;
            this.crvNacimientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNacimientos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNacimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvNacimientos.Location = new System.Drawing.Point(0, 0);
            this.crvNacimientos.Name = "crvNacimientos";
            this.crvNacimientos.Size = new System.Drawing.Size(629, 555);
            this.crvNacimientos.TabIndex = 1;
            this.crvNacimientos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorDefunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 555);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VisorDefunciones";
            this.Text = "Visor de Defunciones";
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNacimientos;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.ComboBox cbxCausas;
    }
}
namespace GestionBasica.Reportes
{
    partial class VisorPartidaMatrimonio
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
            this.crvVisorMat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVisorMat
            // 
            this.crvVisorMat.ActiveViewIndex = -1;
            this.crvVisorMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisorMat.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisorMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisorMat.Location = new System.Drawing.Point(0, 0);
            this.crvVisorMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crvVisorMat.Name = "crvVisorMat";
            this.crvVisorMat.Size = new System.Drawing.Size(278, 244);
            this.crvVisorMat.TabIndex = 1;
            this.crvVisorMat.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorPartidaMatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.crvVisorMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VisorPartidaMatrimonio";
            this.Text = "VisorPartidaMatrimonio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisorPartidaMatrimonio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisorMat;
    }
}
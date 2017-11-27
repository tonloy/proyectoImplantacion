namespace GestionBasica.GUI
{
    partial class GestionPermisos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.dtgPermisos_o = new System.Windows.Forms.DataGridView();
            this.dtgPermisos_d = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idOpcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOpcion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos_o)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos_d)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol";
            // 
            // cbxRoles
            // 
            this.cbxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoles.FormattingEnabled = true;
            this.cbxRoles.Location = new System.Drawing.Point(37, 61);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(220, 21);
            this.cbxRoles.TabIndex = 1;
            this.cbxRoles.SelectedValueChanged += new System.EventHandler(this.cbxRoles_SelectedValueChanged);
            // 
            // dtgPermisos_o
            // 
            this.dtgPermisos_o.AllowUserToAddRows = false;
            this.dtgPermisos_o.AllowUserToDeleteRows = false;
            this.dtgPermisos_o.AllowUserToResizeRows = false;
            this.dtgPermisos_o.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisos_o.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOpcion,
            this.Opcion});
            this.dtgPermisos_o.Location = new System.Drawing.Point(37, 123);
            this.dtgPermisos_o.MultiSelect = false;
            this.dtgPermisos_o.Name = "dtgPermisos_o";
            this.dtgPermisos_o.ReadOnly = true;
            this.dtgPermisos_o.RowHeadersVisible = false;
            this.dtgPermisos_o.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermisos_o.Size = new System.Drawing.Size(240, 191);
            this.dtgPermisos_o.TabIndex = 2;
            this.dtgPermisos_o.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgPermisos_o_CellFormatting);
            // 
            // dtgPermisos_d
            // 
            this.dtgPermisos_d.AllowUserToAddRows = false;
            this.dtgPermisos_d.AllowUserToDeleteRows = false;
            this.dtgPermisos_d.AllowUserToResizeRows = false;
            this.dtgPermisos_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPermisos_d.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOpcion1,
            this.Opcion1});
            this.dtgPermisos_d.Location = new System.Drawing.Point(426, 123);
            this.dtgPermisos_d.MultiSelect = false;
            this.dtgPermisos_d.Name = "dtgPermisos_d";
            this.dtgPermisos_d.ReadOnly = true;
            this.dtgPermisos_d.RowHeadersVisible = false;
            this.dtgPermisos_d.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPermisos_d.Size = new System.Drawing.Size(240, 191);
            this.dtgPermisos_d.TabIndex = 3;
            this.dtgPermisos_d.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgPermisos_d_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Permisos otorgados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Permisos disponibles";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "<< Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Quitar >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idOpcion
            // 
            this.idOpcion.DataPropertyName = "idOpcion";
            this.idOpcion.HeaderText = "ID";
            this.idOpcion.Name = "idOpcion";
            this.idOpcion.ReadOnly = true;
            this.idOpcion.Width = 50;
            // 
            // Opcion
            // 
            this.Opcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opcion.DataPropertyName = "Opcion";
            this.Opcion.HeaderText = "Opción";
            this.Opcion.Name = "Opcion";
            this.Opcion.ReadOnly = true;
            // 
            // idOpcion1
            // 
            this.idOpcion1.DataPropertyName = "idOpcion";
            this.idOpcion1.HeaderText = "ID";
            this.idOpcion1.Name = "idOpcion1";
            this.idOpcion1.ReadOnly = true;
            this.idOpcion1.Width = 50;
            // 
            // Opcion1
            // 
            this.Opcion1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opcion1.DataPropertyName = "Opcion";
            this.Opcion1.HeaderText = "Opción";
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.ReadOnly = true;
            // 
            // GestionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgPermisos_d);
            this.Controls.Add(this.dtgPermisos_o);
            this.Controls.Add(this.cbxRoles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GestionPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Permisos";
            this.Load += new System.EventHandler(this.GestionPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos_o)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPermisos_d)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRoles;
        private System.Windows.Forms.DataGridView dtgPermisos_o;
        private System.Windows.Forms.DataGridView dtgPermisos_d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOpcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOpcion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opcion1;
    }
}
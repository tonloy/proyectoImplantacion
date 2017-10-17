﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GestionBasica.GUI
{
    public partial class GestionPadres : Form
    {
        BindingSource _GRUPOS = new BindingSource();
        string _idPadre;

        public string IdPadre1
        {
            get { return _idPadre; }
            set { _idPadre = value; }
        }
        public GestionPadres()
        {
            InitializeComponent();
            CargarPadres();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }
        private void GestionPadres_Load(object sender, EventArgs e)
        {
            if (_idPadre != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["IdPadre"].Value.ToString() == _idPadre)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.CurrentCell = dataGridView1.Rows[row.Index].Cells[0];
                        dataGridView1.CurrentCell.Selected = true;
                    }
                }
            }
        }
        private void CargarPadres()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODOS_LOS_PADRES();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength == 0)
            {
                _GRUPOS.RemoveFilter();
            }
            else
            {
                _GRUPOS.Filter = "NombreCompleto like '%" + txbFiltrar.Text + "%'";
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dataGridView1.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            PadreEdicion frm = new PadreEdicion();
            frm.ShowDialog();
            CargarPadres();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MadreEdicion frm = new MadreEdicion();
            frm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IPadre miInterfaz = this.Owner as IPadre;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdPadre(dataGridView1.CurrentRow.Cells["IdPadre"].Value.ToString());
                miInterfaz.cambiarPadre(dataGridView1.CurrentRow.Cells["NombreCompleto"].Value.ToString());
            }
            this.Dispose();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea EDITAR el Padre seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    PadreEdicion frm = new PadreEdicion();
                    frm.txtID.Text = dataGridView1.CurrentRow.Cells["idPadre"].Value.ToString();
                    frm.txbNombreCompleto.Text = dataGridView1.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                    frm.txtConocidapor.Text = dataGridView1.CurrentRow.Cells["ConocidoPor"].Value.ToString();
                    frm.mskTEdad.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                    frm.cbxDepartamentos.SelectedIndex = frm.cbxDepartamentos.FindStringExact(dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString());
                    frm.cbxMunicipio.SelectedIndex = frm.cbxMunicipio.FindStringExact(dataGridView1.CurrentRow.Cells["Municipio"].Value.ToString());
                    frm.txtDomicilio.Text = dataGridView1.CurrentRow.Cells["Domicilio"].Value.ToString();
                    frm.cbxProfesiones.SelectedIndex = frm.cbxProfesiones.FindStringExact(dataGridView1.CurrentRow.Cells["Profesion"].Value.ToString());
                    frm.cbxPaises.SelectedIndex = frm.cbxPaises.FindStringExact(dataGridView1.CurrentRow.Cells["Nacionalidad"].Value.ToString());
                    frm.mtxtDUI.Text = dataGridView1.CurrentRow.Cells["DUI"].Value.ToString();
                    frm.cbxParentesco.SelectedIndex = frm.cbxParentesco.FindStringExact(dataGridView1.CurrentRow.Cells["Parentesco"].Value.ToString());
                    frm.txtObservaciones.Text = dataGridView1.CurrentRow.Cells["Observaciones"].Value.ToString();

                    frm.ShowDialog();
                    CargarPadres();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un Padre");
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}

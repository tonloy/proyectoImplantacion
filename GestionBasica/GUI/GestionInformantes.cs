using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI
{
    public partial class GestionInformantes : Form
    {
        BindingSource _GRUPOS = new BindingSource();
        public GestionInformantes()
        {
            InitializeComponent();
        }

        private void GestionInformantes_Load(object sender, EventArgs e)
        {
            CargarInformantes();
        }

        private void CargarInformantes()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODOS_LOS_INFORMANTES();
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
            InformanteEdicion frm = new InformanteEdicion();
            frm.ShowDialog();
            CargarInformantes();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IInformante miInterfaz = this.Owner as IInformante;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdInformantes(dataGridView1.CurrentRow.Cells["IdInformante"].Value.ToString());
                miInterfaz.cambiarInformantes(dataGridView1.CurrentRow.Cells["NombreCompleto"].Value.ToString());
            }
            this.Dispose();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea EDITAR el informante seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    InformanteEdicion frm = new InformanteEdicion();
                    frm.txbIdInformante.Text = dataGridView1.CurrentRow.Cells["IdInformante"].Value.ToString();
                    frm.txtNombreCompleto.Text = dataGridView1.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                    frm.txtConocidapor.Text = dataGridView1.CurrentRow.Cells["ConocidoPor"].Value.ToString();
                    frm.txtObservaciones.Text = dataGridView1.CurrentRow.Cells["Observaciones"].Value.ToString();
                    frm.mtxtDUI.Text = dataGridView1.CurrentRow.Cells["DUI"].Value.ToString();
                    frm.cbxParentesco.SelectedIndex = frm.cbxParentesco.FindStringExact(dataGridView1.CurrentRow.Cells["Parentesco"].Value.ToString());
                    frm.mtxtDUI.ReadOnly = true;
                    frm.cbxParentesco.Enabled = false;

                    frm.ShowDialog();
                    CargarInformantes();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un informante");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}

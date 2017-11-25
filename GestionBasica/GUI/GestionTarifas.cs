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
    public partial class GestionTarifas : Form
    {
        BindingSource _EMPLEADOS = new BindingSource();
        public GestionTarifas()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void GestionTarifas_Load(object sender, EventArgs e)
        {
            CargarCostos();
        }

        private void CargarCostos()
        {
            try
            {
                _EMPLEADOS.DataSource = CacheManager1.Cache.TODOS_LOS_COSTOS();
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
                _EMPLEADOS.RemoveFilter();
            }
            else
            {
                _EMPLEADOS.Filter = "Tipo_partida like '%" + txbFiltrar.Text + "%'";
            }
            dtgCostos.AutoGenerateColumns = false;
            dtgCostos.DataSource = _EMPLEADOS;
            lblNumeroFilas.Text = dtgCostos.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void dtgCostos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            EdicionTarifa tar = new EdicionTarifa();
            tar.ShowDialog();
            CargarCostos();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea EDITAR la tarifa seleccionada?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionTarifa frm = new EdicionTarifa();
                    frm.txbIdTarifa.Text = dtgCostos.CurrentRow.Cells["idCosto"].Value.ToString();
                    frm.txtMonto.Text = dtgCostos.CurrentRow.Cells["Monto"].Value.ToString();
                    frm.cbxPartidas.SelectedIndex = frm.cbxPartidas.FindStringExact(dtgCostos.CurrentRow.Cells["Tipo_partida"].Value.ToString());
                    frm.ShowDialog();
                    CargarCostos();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
        }
    }
}

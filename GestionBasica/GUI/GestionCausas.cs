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
    public partial class GestionCausas : Form
    {
        BindingSource _EMPLEADOS = new BindingSource();
        public GestionCausas()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void GestionCausas_Load(object sender, EventArgs e)
        {
            CargarCausas();
        }

        private void CargarCausas()
        {
            try
            {
                _EMPLEADOS.DataSource = CacheManager1.Cache.TODOS_LOS_CAUSAS();
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
                _EMPLEADOS.Filter = "Causa like '%" + txbFiltrar.Text + "%'";
            }
            dtgEmpleados.AutoGenerateColumns = false;
            dtgEmpleados.DataSource = _EMPLEADOS;
            lblNumeroFilas.Text = dtgEmpleados.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void dtgEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ELIMINAR la causa de muerte seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Primer paso
                    CLS.Causa_muerte oEmpleado = new CLS.Causa_muerte();
                    //Paso 2 pasar el id del grupo a eliminar
                    oEmpleado.IdCausa = dtgEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString();
                    if (oEmpleado.Eliminar())
                    {
                        MessageBox.Show("Causa de muerte eliminada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar la causa de muerte seleccionada.");
                    }
                    CargarCausas();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione una causa de muerte");
                }
            }
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            EdicionCausa fml = new EdicionCausa();
            fml.ShowDialog();
            CargarCausas();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionCausa frm = new EdicionCausa();
                    frm.txbIdCausa.Text = dtgEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString();
                    frm.txbCausa.Text = dtgEmpleados.CurrentRow.Cells["Causa"].Value.ToString();
                    frm.ShowDialog();
                    CargarCausas();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
        }
    }
}

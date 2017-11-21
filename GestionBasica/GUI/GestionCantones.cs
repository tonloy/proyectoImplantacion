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
    public partial class GestionCantones : Form
    {
        BindingSource _EMPLEADOS = new BindingSource();
        public GestionCantones()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void CargarCausas()
        {
            try
            {
                _EMPLEADOS.DataSource = CacheManager1.Cache.TODOS_LOS_CANTONES();
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
                _EMPLEADOS.Filter = "Canton like '%" + txbFiltrar.Text + "%'";
            }
            dtgEmpleados.AutoGenerateColumns = false;
            dtgEmpleados.DataSource = _EMPLEADOS;
            lblNumeroFilas.Text = dtgEmpleados.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void GestionCantones_Load(object sender, EventArgs e)
        {
            CargarCausas();
        }

        private void dtgEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            EdicionCanton flo = new EdicionCanton();
            flo.ShowDialog();
            CargarCausas();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea EDITAR el cantón seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionCanton frm = new EdicionCanton();
                    frm.txbIdCanton.Text = dtgEmpleados.CurrentRow.Cells["idCanton"].Value.ToString();
                    frm.txbCanton.Text = dtgEmpleados.CurrentRow.Cells["Canton"].Value.ToString();
                    frm.cbxDepartamentos.SelectedIndex = frm.cbxDepartamentos.FindStringExact(dtgEmpleados.CurrentRow.Cells["Departamento"].Value.ToString());
                    frm.cbxMunicipios.SelectedIndex = frm.cbxMunicipios.FindStringExact(dtgEmpleados.CurrentRow.Cells["Municipio"].Value.ToString());
                    frm.ShowDialog();
                    CargarCausas();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ELIMINAR el cantón seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Primer paso
                    CLS.Canton oEmpleado = new CLS.Canton();
                    //Paso 2 pasar el id del grupo a eliminar
                    oEmpleado.IdCanton = dtgEmpleados.CurrentRow.Cells["idCanton"].Value.ToString();
                    if (oEmpleado.Eliminar())
                    {
                        MessageBox.Show("Cantón eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el cantón seleccionado.");
                    }
                    CargarCausas();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un cantón");
                }
            }
        }
    }
}

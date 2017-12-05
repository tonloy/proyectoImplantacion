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
    public partial class GestionJuzgados : Form
    {

        BindingSource _JUZGADOS = new BindingSource();
        public GestionJuzgados()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }


        private void CargarJuzgados()
        {
            try
            {
                _JUZGADOS.DataSource = CacheManager1.Cache.TODOS_LOS_JUZGADOS_hoy_si();
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
                _JUZGADOS.RemoveFilter();
            }
            else
            {
                _JUZGADOS.Filter = "Nombre like '%" + txbFiltrar.Text + "%'";
            }
            dtgEmpleados.AutoGenerateColumns = false;
            dtgEmpleados.DataSource = _JUZGADOS;
            lblNumeroFilas.Text = dtgEmpleados.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void GestionJuzgados_Load(object sender, EventArgs e)
        {
            CargarJuzgados();
        }


        private void txbNueva_Click_1(object sender, EventArgs e)
        {
            EdicionJuzgado flo = new EdicionJuzgado();
            flo.ShowDialog();
            CargarJuzgados();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea EDITAR el Juzgado seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionJuzgado frm = new EdicionJuzgado();
                    frm.txbIdCanton.Text = dtgEmpleados.CurrentRow.Cells["ID"].Value.ToString();
                    frm.txbNombreJuzgado.Text = dtgEmpleados.CurrentRow.Cells["Juzgado"].Value.ToString();
                    frm.txtDireccionJuzgado.Text = dtgEmpleados.CurrentRow.Cells["Direccion"].Value.ToString();
                    frm.cbxMunicipios.SelectedIndex = frm.cbxMunicipios.FindStringExact(dtgEmpleados.CurrentRow.Cells["Municipio"].Value.ToString());
                    frm.ShowDialog();
                    CargarJuzgados();
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
                    CLS.Juzgados oEmpleado = new CLS.Juzgados();
                    //Paso 2 pasar el id del grupo a eliminar
                    oEmpleado.IdJuzgados = dtgEmpleados.CurrentRow.Cells["ID"].Value.ToString();
                    if (oEmpleado.Eliminar())
                    {
                        MessageBox.Show("Juzgado eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el Juzgado seleccionado.");
                    }
                    CargarJuzgados();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un cantón");
                }

            }
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}

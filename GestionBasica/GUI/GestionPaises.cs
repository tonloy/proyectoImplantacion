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
    public partial class GestionPaises : Form
    {
        BindingSource _PROFESIONES = new BindingSource();
        public GestionPaises()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
            CargarPaises();
        }
        private void CargarPaises()
        {
            try
            {
                _PROFESIONES.DataSource = CacheManager1.Cache.TODOS_LOS_PAISES();
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
                _PROFESIONES.RemoveFilter();
            }
            else
            {
                _PROFESIONES.Filter = "Pais like '%" + txbFiltrar.Text + "%'";
            }
            dtgEmpleados.AutoGenerateColumns = false;
            dtgEmpleados.DataSource = _PROFESIONES;
            lblNumeroFilas.Text = dtgEmpleados.Rows.Count.ToString() + " Registros Encontrados";
        }
        private void dtgEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void GestionPaises_Load(object sender, EventArgs e)
        {

        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            EdicionPais form = new EdicionPais();
            form.ShowDialog();
            CargarPaises();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionPais frm = new EdicionPais();
                    frm.txbIdPais.Text = dtgEmpleados.CurrentRow.Cells["idPais"].Value.ToString();
                    frm.txbNombreCompleto.Text = dtgEmpleados.CurrentRow.Cells["Pais"].Value.ToString();
                    frm.txtNacionalidad.Text = dtgEmpleados.CurrentRow.Cells["Nacionalidad"].Value.ToString();

                    frm.ShowDialog();
                    CargarPaises();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ELIMINAR la profesión seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Primer paso
                    CLS.Pais oEmpleado = new CLS.Pais();
                    //Paso 2 pasar el id del grupo a eliminar
                    oEmpleado.IdPais = dtgEmpleados.CurrentRow.Cells["idPais"].Value.ToString();
                    if (oEmpleado.Eliminar())
                    {
                        MessageBox.Show("País eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el país seleccionado.");
                    }
                    CargarPaises();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un país");
                }
            }
        }
    }
}

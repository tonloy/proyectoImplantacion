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
    public partial class GestionProfesiones : Form
    {
        BindingSource _PROFESIONES = new BindingSource();
        public GestionProfesiones()
        {
            InitializeComponent();
            CargarProfesiones();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }
        private void CargarProfesiones()
        {
            try
            {
                _PROFESIONES.DataSource = CacheManager1.Cache.TODOS_LOS_PROFESIONES();
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
                _PROFESIONES.Filter = "Profesion like '%" + txbFiltrar.Text + "%'";
            }
            dtgEmpleados.AutoGenerateColumns = false;
            dtgEmpleados.DataSource = _PROFESIONES;
            lblNumeroFilas.Text = dtgEmpleados.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void GestionProfesiones_Load(object sender, EventArgs e)
        {

        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionProfesion frm = new EdicionProfesion();
                    frm.txbIdEmpleado.Text = dtgEmpleados.CurrentRow.Cells["idProfesion"].Value.ToString();
                    frm.txbNombreCompleto.Text = dtgEmpleados.CurrentRow.Cells["Profesion"].Value.ToString();
                    

                    frm.ShowDialog();
                    CargarProfesiones();
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
                    CLS.Profesion oEmpleado = new CLS.Profesion();
                    //Paso 2 pasar el id del grupo a eliminar
                    oEmpleado.IdProfesion = dtgEmpleados.CurrentRow.Cells["idProfesion"].Value.ToString();
                    if (oEmpleado.Eliminar())
                    {
                        MessageBox.Show("Profesión eliminada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar la profesión seleccionado.");
                    }
                    CargarProfesiones();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione una profesión");
                }
            }
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            EdicionProfesion frm = new EdicionProfesion();
            frm.ShowDialog();
            CargarProfesiones();
        }

        private void dtgEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }
    }
}

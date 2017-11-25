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
    public partial class GestionEmpleados : Form
    {

        String IdFuncionario1;
        public string IdFuncionario11 {
            get{ return IdFuncionario1; }
            set{ IdFuncionario1 = value;}
        }

        BindingSource _EMPLEADOS = new BindingSource();
        public GestionEmpleados()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void CargarEmpleados()
        {
            try
            {
                _EMPLEADOS.DataSource = CacheManager1.Cache.TODOS_LOS_EMPLEADOS();
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
                _EMPLEADOS.Filter = "NombreCompleto like '%" + txbFiltrar.Text + "%' or Cargo like '%" + txbFiltrar.Text + "%'";
            }
            dtgEmpleados.AutoGenerateColumns = false;
            dtgEmpleados.DataSource = _EMPLEADOS;
            lblNumeroFilas.Text = dtgEmpleados.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            EdicionEmpleado frm = new EdicionEmpleado();
            frm.ShowDialog();
            CargarEmpleados();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionEmpleado frm = new EdicionEmpleado();
                    frm.txbIdEmpleado.Text = dtgEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString();
                    frm.txbNombreCompleto.Text = dtgEmpleados.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                    frm.cbxCargos.SelectedIndex = frm.cbxCargos.FindStringExact(dtgEmpleados.CurrentRow.Cells["Cargo"].Value.ToString());
                    frm.txtRubricas.Text= dtgEmpleados.CurrentRow.Cells["Rubricas"].Value.ToString();

                    frm.ShowDialog();
                    CargarEmpleados();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
        }

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ELIMINAR el empleado seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Primer paso
                    CLS.Empleado oEmpleado = new CLS.Empleado();
                    //Paso 2 pasar el id del grupo a eliminar
                    oEmpleado.IdEmpleado = dtgEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString();
                    if (oEmpleado.Eliminar())
                    {
                        MessageBox.Show("Empleado eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el empleado seleccionado.");
                    }
                    CargarEmpleados();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un empleado");
                }
            }
        }

        private void dtgEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6,0,88);
        }

        private void dtgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                Matrimonio.IFuncionario miInterfaz = this.Owner as Matrimonio.IFuncionario;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdFuncionario(dtgEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString());
                miInterfaz.cambiarfuncionario(dtgEmpleados.CurrentRow.Cells["NombreCompleto"].Value.ToString());
            }
            this.Dispose();
        }
    }
}

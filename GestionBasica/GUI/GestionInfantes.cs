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
    public partial class GestionInfantes : Form
    {
        BindingSource _GRUPOS = new BindingSource();
        public GestionInfantes()
        {
            InitializeComponent();
        }

        private void GestionInfantes_Load(object sender, EventArgs e)
        {
            CargarInfantes();
        }

        private void CargarInfantes()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODOS_LOS_INFANTES();
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
            InfanteEdicion frm = new InfanteEdicion();
            frm.ShowDialog();
            CargarInfantes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea EDITAR el infante seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    InfanteEdicion frm = new InfanteEdicion();
                    frm.txbIdInfante.Text = dataGridView1.CurrentRow.Cells["IdInfante"].Value.ToString();
                    frm.txtNombreCompleto.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                    frm.txtLugarNac.Text = dataGridView1.CurrentRow.Cells["LugarNac"].Value.ToString();
                    frm.txtHora.Text = dataGridView1.CurrentRow.Cells["Hora"].Value.ToString();
                    frm.dtpFecha.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString());
                    if (dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString() == "M")
                    {
                        frm.rbtnMasculino.Checked = true;
                    }
                    else
                    {
                        frm.rbtnFemenino.Checked = true;
                    }
                    frm.txtLugarNac.ReadOnly = true;
                    frm.rbtnMasculino.Enabled = false;
                    frm.rbtnFemenino.Enabled = false;
                    frm.ShowDialog();
                    CargarInfantes();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IInfante miInterfaz = this.Owner as IInfante;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdInfante(dataGridView1.CurrentRow.Cells["IdInfante"].Value.ToString());
                miInterfaz.cambiarInfante(dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString());
            }
            this.Dispose();
        }
    }
}

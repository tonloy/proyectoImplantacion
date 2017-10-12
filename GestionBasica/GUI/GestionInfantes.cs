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
        String _idInfante;

        public String IdInfante1
        {
            get { return _idInfante; }
            set { _idInfante = value; }
        }
        public GestionInfantes()
        {
            InitializeComponent();
            CargarInfantes();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);

        }

        private void GestionInfantes_Load(object sender, EventArgs e)
        {
            if (_idInfante != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["IdInfante"].Value.ToString() == _idInfante)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.CurrentCell = dataGridView1.Rows[row.Index].Cells[0];
                        dataGridView1.CurrentCell.Selected = true;
                    }
                }
            }
        }

        private void CargarInfantes()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODOS_LOS_INFANTES();
                dataGridView1.ClearSelection();
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
            dataGridView1.ClearSelection();
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
                    frm.cbxDepartamentos.SelectedIndex = frm.cbxDepartamentos.FindStringExact(dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString());
                    frm.cbxMunicipio.SelectedIndex = frm.cbxMunicipio.FindStringExact(dataGridView1.CurrentRow.Cells["LugarNac"].Value.ToString());
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
                    if (dataGridView1.CurrentRow.Cells["Revisado"].Value.ToString() == "True")
                    {
                        frm.txtNombreCompleto.ReadOnly = true;
                        frm.txtHora.ReadOnly = true;
                        frm.dtpFecha.Enabled = false;
                        frm.cbxDepartamentos.Enabled = false;
                        frm.cbxMunicipio.Enabled = false;
                        frm.rbtnMasculino.Enabled = false;
                        frm.rbtnFemenino.Enabled = false;
                        frm.chbxRevisado.Checked = true;
                        frm.chbxRevisado.Enabled = false;
                    }
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}

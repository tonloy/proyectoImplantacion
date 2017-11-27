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
        String _idInformante;
        Boolean _profesional = false;

        public String IdInformante1
        {
            get { return _idInformante; }
            set { _idInformante = value; }
        }

        public bool Profesional
        {
            get
            {
                return _profesional;
            }

            set
            {
                _profesional = value;
            }
        }

        public GestionInformantes()
        {
            InitializeComponent();
            CargarInformantes();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void GestionInformantes_Load(object sender, EventArgs e)
        {
            if (_idInformante != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["IdPadre"].Value.ToString() == _idInformante)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.CurrentCell = dataGridView1.Rows[row.Index].Cells[0];
                        dataGridView1.CurrentCell.Selected = true;
                    }
                }
            }
        }

        private void CargarInformantes()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODOS_LOS_PADRES();
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
            PadreEdicion frm = new PadreEdicion();
            frm.ShowDialog();
            CargarInformantes();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                    PadreEdicion frm = new PadreEdicion();
                    frm.txtID.Text = dataGridView1.CurrentRow.Cells["idPadre"].Value.ToString();
                    frm.txbNombreCompleto.Text = dataGridView1.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                    frm.txtConocidapor.Text = dataGridView1.CurrentRow.Cells["ConocidoPor"].Value.ToString();
                    frm.mskTEdad.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                    frm.cbxDepartamentos.SelectedIndex = frm.cbxDepartamentos.FindStringExact(dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString());
                    frm.cbxMunicipio.SelectedIndex = frm.cbxMunicipio.FindStringExact(dataGridView1.CurrentRow.Cells["Municipio"].Value.ToString());
                    frm.txtDomicilio.Text = dataGridView1.CurrentRow.Cells["Domicilio"].Value.ToString();
                    frm.cbxProfesiones.SelectedIndex = frm.cbxProfesiones.FindStringExact(dataGridView1.CurrentRow.Cells["Profesion"].Value.ToString());
                    frm.cbxPaises.SelectedIndex = frm.cbxPaises.FindStringExact(dataGridView1.CurrentRow.Cells["Nacionalidad"].Value.ToString());
                    frm.mtxtDUI.Text = dataGridView1.CurrentRow.Cells["DUI"].Value.ToString();
                    frm.cbxParentesco.SelectedIndex = frm.cbxParentesco.FindStringExact(dataGridView1.CurrentRow.Cells["Parentesco"].Value.ToString());
                    frm.txtObservaciones.Text = dataGridView1.CurrentRow.Cells["Observaciones"].Value.ToString();
                    frm.txtNumPartida.Text= dataGridView1.CurrentRow.Cells["Nit"].Value.ToString();

                    if (dataGridView1.CurrentRow.Cells["Nit"].Value.ToString() == "    -      -   -")
                    {
                        frm.chbxMenor.Checked = false;
                    }
                    else
                    {
                        frm.chbxMenor.Checked = true;
                    }

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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!_profesional)
            {
                IInformante miInterfaz = this.Owner as IInformante;
                if (miInterfaz != null)
                {
                    miInterfaz.cambiarIdInformantes(dataGridView1.CurrentRow.Cells["IdPadre"].Value.ToString());
                    miInterfaz.cambiarInformantes(dataGridView1.CurrentRow.Cells["NombreCompleto"].Value.ToString());
                }
                this.Dispose();
            }else
            {
                IProfesional miInterfaz = this.Owner as IProfesional;
                if (miInterfaz != null)
                {
                    miInterfaz.cambiarIdProfesional(dataGridView1.CurrentRow.Cells["IdPadre"].Value.ToString());
                    miInterfaz.cambiarProfesional(dataGridView1.CurrentRow.Cells["NombreCompleto"].Value.ToString());
                }
                this.Dispose();
            }
        }
    }
}

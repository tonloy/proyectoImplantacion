using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI.Defunciones
{
    public partial class GestionDifuntos : Form
    {
        BindingSource _GRUPOS = new BindingSource();
        string _idPadre;
        public GestionDifuntos()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
            CargarPersonas();
        }

        public string IdPadre
        {
            get
            {
                return _idPadre;
            }

            set
            {
                _idPadre = value;
            }
        }

        private void CargarPersonas()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODOS_LOS_PADRES1();
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
                _GRUPOS.Filter = "NombreCompleto like '%" + txbFiltrar.Text + "%' or ConocidoPor like '%" + txbFiltrar.Text + "%'";
            }
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void GestionDifuntos_Load(object sender, EventArgs e)
        {
            if (_idPadre != null)
            {
                foreach (DataGridViewRow row in dtgPartidas.Rows)
                {
                    if (row.Cells["ID"].Value.ToString() == _idPadre)
                    {
                        dtgPartidas.ClearSelection();
                        dtgPartidas.CurrentCell = dtgPartidas.Rows[row.Index].Cells[0];
                        dtgPartidas.CurrentCell.Selected = true;
                    }
                }
                if (_idPadre.Length>0)
                {
                    dtgPartidas.Enabled = false;
                }
            }
        }

        private void dtgPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            DifuntoEdicion fmr = new DifuntoEdicion();
            fmr.ShowDialog();
            CargarPersonas();
        }

        private void dtgPartidas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgPartidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IInfante miInterfaz = this.Owner as IInfante;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdInfante(dtgPartidas.CurrentRow.Cells["ID"].Value.ToString());
                miInterfaz.cambiarInfante(dtgPartidas.CurrentRow.Cells["Nombre"].Value.ToString());
            }
            this.Dispose();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea EDITAR la persona seleccionada?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DifuntoEdicion frm = new DifuntoEdicion();
                    frm.txtID.Text = dtgPartidas.CurrentRow.Cells["ID"].Value.ToString();
                    frm.txbNombreCompleto.Text = dtgPartidas.CurrentRow.Cells["Nombre"].Value.ToString();
                    frm.cbxDepartamentos.SelectedIndex = frm.cbxDepartamentos.FindStringExact(dtgPartidas.CurrentRow.Cells["Departamento"].Value.ToString());
                    frm.cbxMunicipio.SelectedIndex = frm.cbxMunicipio.FindStringExact(dtgPartidas.CurrentRow.Cells["Municipio"].Value.ToString());
                    frm.txtConocidapor.Text= dtgPartidas.CurrentRow.Cells["ConocidoPor"].Value.ToString();
                    frm.mskTEdad.Text= dtgPartidas.CurrentRow.Cells["Edad"].Value.ToString();
                    frm.txtDomicilio.Text= dtgPartidas.CurrentRow.Cells["Domicilio"].Value.ToString();
                    frm.cbxProfesiones.SelectedIndex = frm.cbxProfesiones.FindStringExact(dtgPartidas.CurrentRow.Cells["Profesión"].Value.ToString());
                    frm.cbxPaises.SelectedIndex = frm.cbxPaises.FindStringExact(dtgPartidas.CurrentRow.Cells["Nacionalidad"].Value.ToString());
                    frm.mtxtDUI.Text= dtgPartidas.CurrentRow.Cells["Dui"].Value.ToString();
                    frm.txtNumPartida.Text= dtgPartidas.CurrentRow.Cells["Nit"].Value.ToString();

                    frm.cbxEstados.Text=dtgPartidas.CurrentRow.Cells["Estado_familiar"].Value.ToString();
                    if(dtgPartidas.CurrentRow.Cells["Dui"].Value.ToString()== "        -")
                    {
                        frm.mtxtDUI.ReadOnly = true;
                    }else
                    {
                        frm.txtNumPartida.ReadOnly = true;
                    }
                    if (dtgPartidas.CurrentRow.Cells["Género"].Value.ToString() == "Masculino")
                    {
                        frm.rbtnMasculino.Checked = true;
                    }
                    else
                    {
                        frm.rbtnFemenino.Checked = true;
                    }
                    if (dtgPartidas.CurrentRow.Cells["Revisado"].Value.ToString() == "True")
                    {
                        frm.txbNombreCompleto.ReadOnly = true;
                        frm.cbxDepartamentos.Enabled = false;
                        frm.cbxMunicipio.Enabled = false;
                        frm.rbtnMasculino.Enabled = false;
                        frm.rbtnFemenino.Enabled = false;
                        frm.checkBox1.Checked = true;
                        frm.checkBox1.Enabled = false;
                        frm.mskTEdad.ReadOnly = true;
                        frm.cbxEstados.Enabled = false;
                        frm.txtConocidapor.ReadOnly = true;
                        frm.txtDomicilio.ReadOnly = true;
                        frm.cbxProfesiones.Enabled = false;
                        frm.cbxPaises.Enabled = false;
                        frm.mtxtDUI.Enabled = false;
                        frm.txtNumPartida.Enabled = false;
                        frm.btnGuardar.Visible = false;
                    }
                    frm.ShowDialog();
                    CargarPersonas();
                }
                catch(Exception en)
                {
                    MessageBox.Show("Por favor seleccione un registro " +en.StackTrace);
                }
            }
        }
    }
}

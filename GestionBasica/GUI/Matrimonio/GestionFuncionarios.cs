using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI.Matrimonio
{
    public partial class GestionFuncionarios : Form
    {
        String IdFuncionario1;
        public string IdFuncionario11
        {
            get { return IdFuncionario1; }
            set { IdFuncionario1 = value; }
        }

        BindingSource _GRUPOS = new BindingSource();
        public GestionFuncionarios()
        {
            InitializeComponent();
            CargarPadres();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }


        private void CargarPadres()
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
            dtgFuncionarios.AutoGenerateColumns = false;
            dtgFuncionarios.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgFuncionarios.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void dtgFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Matrimonio.IFuncionario miInterfaz = this.Owner as Matrimonio.IFuncionario;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdFuncionario(dtgFuncionarios.CurrentRow.Cells["idPadre"].Value.ToString());
                miInterfaz.cambiarfuncionario(dtgFuncionarios.CurrentRow.Cells["NombreCompleto"].Value.ToString());
            }
            this.Dispose();
        }

        private void GestionFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void dtgFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            PadreEdicion frm = new PadreEdicion();
            frm.Show();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea EDITAR el Funcionario seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    PadreEdicion frm = new PadreEdicion();
                    frm.txtID.Text = dtgFuncionarios.CurrentRow.Cells["idPadre"].Value.ToString();
                    frm.txbNombreCompleto.Text = dtgFuncionarios.CurrentRow.Cells["NombreCompleto"].Value.ToString();
                    frm.txtConocidapor.Text = dtgFuncionarios.CurrentRow.Cells["ConocidoPor"].Value.ToString();
                    frm.mskTEdad.Text = dtgFuncionarios.CurrentRow.Cells["Edad"].Value.ToString();
                    frm.cbxDepartamentos.SelectedIndex = frm.cbxDepartamentos.FindStringExact(dtgFuncionarios.CurrentRow.Cells["Departamento"].Value.ToString());
                    frm.cbxMunicipio.SelectedIndex = frm.cbxMunicipio.FindStringExact(dtgFuncionarios.CurrentRow.Cells["Municipio"].Value.ToString());
                    frm.txtDomicilio.Text = dtgFuncionarios.CurrentRow.Cells["Domicilio"].Value.ToString();
                    frm.cbxProfesiones.SelectedIndex = frm.cbxProfesiones.FindStringExact(dtgFuncionarios.CurrentRow.Cells["Profesion"].Value.ToString());
                    frm.cbxPaises.SelectedIndex = frm.cbxPaises.FindStringExact(dtgFuncionarios.CurrentRow.Cells["Nacionalidad"].Value.ToString());
                    frm.mtxtDUI.Text = dtgFuncionarios.CurrentRow.Cells["DUI"].Value.ToString();
                    frm.cbxParentesco.SelectedIndex = frm.cbxParentesco.FindStringExact(dtgFuncionarios.CurrentRow.Cells["Parentesco"].Value.ToString());
                    frm.txtObservaciones.Text = dtgFuncionarios.CurrentRow.Cells["Observaciones"].Value.ToString();
                    frm.txtNumPartida.Text = dtgFuncionarios.CurrentRow.Cells["Nit"].Value.ToString();
                    frm.txtRubrica.Text = dtgFuncionarios.CurrentRow.Cells["Rubrica"].Value.ToString();
                    if (dtgFuncionarios.CurrentRow.Cells["FechaNac"].Value.ToString() != "")
                    {
                        frm.dtpFecha.Value = Convert.ToDateTime(dtgFuncionarios.CurrentRow.Cells["FechaNac"].Value.ToString());
                    }
                    if (dtgFuncionarios.CurrentRow.Cells["Nit"].Value.ToString() == "    -      -   -")
                    {
                        frm.chbxMenor.Checked = false;
                    }
                    else
                    {
                        frm.chbxMenor.Checked = true;
                    }

                    frm.ShowDialog();
                    CargarPadres();
                }
                catch(Exception u)
                {
                    MessageBox.Show("Por favor seleccione un funcionario "+u.Message);
                }
            }
        }
    }
}

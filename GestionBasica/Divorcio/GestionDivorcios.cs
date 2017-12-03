using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.Divorcio
{
    public partial class GestionDivorcios : Form
    {
        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
        BindingSource _GRUPOS = new BindingSource();
        public GestionDivorcios()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void GestionDivorcios_Load(object sender, EventArgs e)
        {
            CargarPartidas();
        }

        private void CargarPartidas()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODAS_PARTIDAS_DIVORCIO();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }

        private void FiltrarLocalmente()
        {
            _GRUPOS.DataSource = CacheManager1.Cache.TODAS_PARTIDAS_DIVORCIO();
            if (txbFiltrar.TextLength == 0)
            {
                _GRUPOS.RemoveFilter();
            }
            else
            {
                _GRUPOS.Filter = "Hombre like '%" + txbFiltrar.Text + "%' or Mujer like '%"+txbFiltrar.Text+"%'";
                
            }
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void dtgPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            EdicionDivorcio frm = new EdicionDivorcio();
            frm.ShowDialog();
            CargarPartidas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea EDITAR la partida seleccionada?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionDivorcio frm = new EdicionDivorcio();

                    frm.txbIdPartida.Text = dtgPartidas.CurrentRow.Cells["ID"].Value.ToString();
                    frm.txbFolio.Text = dtgPartidas.CurrentRow.Cells["folio"].Value.ToString();
                    frm.txbNumPartida.Text = dtgPartidas.CurrentRow.Cells["NumPartida"].Value.ToString();
                    frm.txbLibro.Text = dtgPartidas.CurrentRow.Cells["Libro"].Value.ToString();
                    frm.txbNotario.Text = dtgPartidas.CurrentRow.Cells["NombreNotario"].Value.ToString();
                    frm.cbxJuzgados.SelectedIndex = frm.cbxJuzgados.FindStringExact(dtgPartidas.CurrentRow.Cells["Juzgado"].Value.ToString());
                    frm.txbFechaMat.Text= dtgPartidas.CurrentRow.Cells["FechaMat"].Value.ToString();
                    frm.dtpFechaSentencia.Value = Convert.ToDateTime(dtgPartidas.CurrentRow.Cells["Fecha_sentencia"].Value.ToString());
                    frm.dtpFechaEjecutoriada.Value = Convert.ToDateTime(dtgPartidas.CurrentRow.Cells["Fecha_ejecutoriada"].Value.ToString());
                    frm.txbIdMatrimonio.Text= dtgPartidas.CurrentRow.Cells["idMatrimonio"].Value.ToString();
                    frm.pictureBox1.ImageLocation= dtgPartidas.CurrentRow.Cells["Imagen"].Value.ToString();
                    frm.txbTutela.Text= dtgPartidas.CurrentRow.Cells["Tutela"].Value.ToString();
                    frm.txbMujer.Text= dtgPartidas.CurrentRow.Cells["NombreEsposa"].Value.ToString();
                    frm.txbHombre.Text = dtgPartidas.CurrentRow.Cells["NombreEsposo"].Value.ToString();
                    frm.txbRegimen.Text= dtgPartidas.CurrentRow.Cells["RegimenPatrimonial"].Value.ToString();

                    if (dtgPartidas.CurrentRow.Cells["Revisado"].Value.ToString()=="True")
                    {
                        frm.txbFolio.ReadOnly = true;
                        frm.txbLibro.ReadOnly = true;
                        frm.txbNumPartida.ReadOnly = true;
                        frm.pictureBox1.Enabled = false;
                        frm.chbxRespaldo.Enabled = false;
                        frm.chbxRevisado.Checked = true;
                        frm.chbxRevisado.Enabled = false;
                        frm.btnSeleccionar.Enabled = false;
                        frm.dtpFechaEjecutoriada.Enabled = false;
                        frm.dtpFechaSentencia.Enabled = false;
                        frm.txbNotario.ReadOnly = true;
                        frm.txbTutela.ReadOnly = true;
                        frm.btnGuardar.Visible = false;
                    }

                    if (dtgPartidas.CurrentRow.Cells["Imagen"].Value.ToString()!="")
                    {
                        frm.pictureBox1.Visible = true;
                        frm.chbxRespaldo.Checked = true;
                    }

                    frm.ShowDialog();
                    CargarPartidas();

                }
                catch(Exception u)
                {
                    MessageBox.Show("Por favor seleccione un Registro" +u.StackTrace);
                }
            }
        }

        private void txbImprimir_Click(object sender, EventArgs e)
        {
            if (dtgPartidas.CurrentRow.Cells["Imagen"].Value.ToString() == "")
            {
                MessageBox.Show("No hay respaldo para esta partida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Reportes.VisorPartidaNac frm = new Reportes.VisorPartidaNac();
                frm.pictureBox1.ImageLocation = dtgPartidas.CurrentRow.Cells["Imagen"].Value.ToString();
                frm.IdPartida = dtgPartidas.CurrentRow.Cells["ID"].Value.ToString();
                frm.ShowDialog();
            }
        }
    }
}

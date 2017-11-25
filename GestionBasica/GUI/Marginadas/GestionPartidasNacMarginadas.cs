using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI.Marginadas
{
    public partial class GestionPartidasNacMarginadas : Form
    {
        DataTable _Marginacion = new DataTable();
        BindingSource _GRUPOS = new BindingSource();
        public GestionPartidasNacMarginadas()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void GestionPartidasNacMarginadas_Load(object sender, EventArgs e)
        {
            CargarPartidas();
        }

        private void CargarPartidas()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS_MARGINADAS();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }

        private void FiltrarLocalmente()
        {
            _GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS_MARGINADAS();
            if (txbFiltrar.TextLength == 0)
            {
                _GRUPOS.RemoveFilter();
            }
            else
            {
                _GRUPOS.Filter = "infante like '%" + txbFiltrar.Text + "%'";
                //_GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS(txbFiltrar.Text);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS_MARGINADAS(Convert.ToDateTime(dateTimePicker1.Value.ToString()).ToString("yyyy-MM-dd"));
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void txbImprimir_Click(object sender, EventArgs e)
        {
            if (dtgPartidas.CurrentRow.Cells["Ruta"].Value.ToString() == "")
            {
                MessageBox.Show("No hay respaldo para esta partida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Reportes.VisorPartidaNac frm = new Reportes.VisorPartidaNac();
                frm.pictureBox1.ImageLocation = dtgPartidas.CurrentRow.Cells["Ruta"].Value.ToString();
                frm.IdPartida = dtgPartidas.CurrentRow.Cells["idPartida"].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea RESPALDAR la partida seleccionada?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    PartidaEdicion frm = new PartidaEdicion();
                    frm.txbNumPartida.Text = dtgPartidas.CurrentRow.Cells["NumPartida"].Value.ToString();
                    frm.txbIdPartida.Text = dtgPartidas.CurrentRow.Cells["idPartida"].Value.ToString();
                    frm.pictureBox1.ImageLocation = dtgPartidas.CurrentRow.Cells["Ruta"].Value.ToString();
                    frm.txbIdInfante.Text = dtgPartidas.CurrentRow.Cells["IdInfante"].Value.ToString();
                    frm.txbInfante.Text = dtgPartidas.CurrentRow.Cells["NombreInfante"].Value.ToString();
                    frm.txtIdPadre.Text = dtgPartidas.CurrentRow.Cells["IdPadre"].Value.ToString();
                    frm.txtNombrePadre.Text = dtgPartidas.CurrentRow.Cells["NombrePadre"].Value.ToString();
                    frm.txtIdMadre.Text = dtgPartidas.CurrentRow.Cells["IdMadre"].Value.ToString();
                    frm.txtNombreMadre.Text = dtgPartidas.CurrentRow.Cells["NombreMadre"].Value.ToString();
                    frm.txtIdInformante.Text = dtgPartidas.CurrentRow.Cells["IdInformante"].Value.ToString();
                    frm.txtNombreInformante.Text = dtgPartidas.CurrentRow.Cells["NombreInformante"].Value.ToString();
                    frm.txbLibro.Text = dtgPartidas.CurrentRow.Cells["Libro"].Value.ToString();
                    frm.txbFolio.Text = dtgPartidas.CurrentRow.Cells["Folio"].Value.ToString();

                    frm.txbLibro.ReadOnly = true;
                    frm.txbFolio.ReadOnly = true;
                    frm.txbNumPartida.ReadOnly = true;
                    frm.button1.Enabled = false;
                    frm.button2.Enabled = false;
                    frm.button3.Enabled = false;
                    frm.button4.Enabled = false;

                    if (dtgPartidas.CurrentRow.Cells["Ruta"].Value.ToString() == "")
                    {
                        frm.cbxRespaldoPda.Checked = false;
                    }
                    else
                    {
                        frm.cbxRespaldoPda.Checked = true;
                    }

                    frm.ShowDialog();
                    CargarPartidas();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CargarMarginacion();
        }

        private void CargarMarginacion()
        {
            try
            {
                _Marginacion = CacheManager1.Cache.MarginacionPartidaNac(dtgPartidas.CurrentRow.Cells["idPartida"].Value.ToString());
                foreach (DataRow row in _Marginacion.Rows)
                {
                    EdicionMarginacion eM = new EdicionMarginacion();
                    eM.txtIdPartida.Text = row[0].ToString();
                    eM.txtNumPartida.Text = row[1].ToString();
                    eM.mtxtHoraSentencia.Text = row[2].ToString();
                    eM.dtpFechaSentencia.Value = Convert.ToDateTime(row[3].ToString());
                    eM.cbxJuzgados.SelectedIndex = eM.cbxJuzgados.FindStringExact(row[4].ToString());
                    eM.txtExplicacion.Text = row[5].ToString();

                    eM.btnCancelar.Visible = false;
                    eM.button1.Visible = false;
                    eM.dtpFechaSentencia.Enabled = false;
                    eM.txtExplicacion.ReadOnly = true;
                    eM.mtxtHoraSentencia.ReadOnly = true;
                    eM.cbxJuzgados.Enabled = false;
                    eM.ShowDialog();
                }
            }
            catch
            {

            }
        }
    }
}

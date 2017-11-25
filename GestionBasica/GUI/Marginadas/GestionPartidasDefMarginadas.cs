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
    public partial class GestionPartidasDefMarginadas : Form
    {
        BindingSource _Partidas = new BindingSource();
        DataTable _Marginacion = new DataTable();
        public GestionPartidasDefMarginadas()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void GestionPartidasDefMarginadas_Load(object sender, EventArgs e)
        {
            CargarPartidas();
        }

        private void CargarMarginacion()
        {
            try
            {
                _Marginacion= CacheManager1.Cache.MarginacionPartidaDef(dtgPartidas.CurrentRow.Cells["ID"].Value.ToString());
                foreach(DataRow row in _Marginacion.Rows)
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

        private void CargarPartidas()
        {
            try
            {
                _Partidas.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS_DEFUNCION();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }

        private void FiltrarLocalmente()
        {
            _Partidas.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS_DEFUNCION_MARGINADAS();
            if (txbFiltrar.TextLength == 0)
            {
                _Partidas.RemoveFilter();
            }
            else
            {
                _Partidas.Filter = "Fallecido like '%" + txbFiltrar.Text + "%'";
                //_GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS(txbFiltrar.Text);
            }
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _Partidas;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _Partidas.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS_DEFUNCION_MARGINADAS(Convert.ToDateTime(dateTimePicker1.Value.ToString()).ToString("yyyy-MM-dd"));
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _Partidas;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void dtgPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void btnCambiarDatos_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Realmente desea modificar esta partida?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                try
                {
                    Defunciones.DefuncionEdicion fro = new Defunciones.DefuncionEdicion();
                    fro.txbIdPartida.Text = dtgPartidas.CurrentRow.Cells["ID"].Value.ToString();
                    fro.txbFolio.Text = dtgPartidas.CurrentRow.Cells["Folio"].Value.ToString();
                    fro.txbLibro.Text = dtgPartidas.CurrentRow.Cells["Libro"].Value.ToString();
                    fro.txbNumPartida.Text = dtgPartidas.CurrentRow.Cells["NumPartida"].Value.ToString();
                    if (dtgPartidas.CurrentRow.Cells["Imagen"].Value.ToString() != "")
                    {
                        fro.pictureBox1.Visible = true;
                        fro.pictureBox1.ImageLocation = dtgPartidas.CurrentRow.Cells["Imagen"].Value.ToString();
                        fro.cbxRespaldoPda.Checked = true;
                    }
                    if (dtgPartidas.CurrentRow.Cells["Asistencia"].Value.ToString().Equals("True"))
                    {
                        fro.chbxAsistencia.Checked = true;
                    }
                    else
                    {
                        fro.chbxAsistencia.Checked = false;
                    }
                    fro.txbIdDifunto.Text = dtgPartidas.CurrentRow.Cells["idDifunto"].Value.ToString();
                    fro.txbDifunto.Text = dtgPartidas.CurrentRow.Cells["Nombre"].Value.ToString();
                    fro.txbIdConyuge.Text = dtgPartidas.CurrentRow.Cells["idConyuge"].Value.ToString();
                    fro.txbConyuge.Text = dtgPartidas.CurrentRow.Cells["Conyuge"].Value.ToString();
                    fro.txtIdMadre.Text = dtgPartidas.CurrentRow.Cells["idMadre"].Value.ToString();
                    fro.txtNombreMadre.Text = dtgPartidas.CurrentRow.Cells["Madre"].Value.ToString();
                    fro.txtIdPadre.Text = dtgPartidas.CurrentRow.Cells["idPadre"].Value.ToString();
                    fro.txtNombrePadre.Text = dtgPartidas.CurrentRow.Cells["Padre"].Value.ToString();
                    fro.txtIdInformante.Text = dtgPartidas.CurrentRow.Cells["idInformante"].Value.ToString();
                    fro.txtNombreInformante.Text = dtgPartidas.CurrentRow.Cells["Informante"].Value.ToString();
                    fro.txbIdTestigo1.Text = dtgPartidas.CurrentRow.Cells["idTestigo1"].Value.ToString();
                    fro.txbTestigo1.Text = dtgPartidas.CurrentRow.Cells["Testigo1"].Value.ToString();
                    fro.txbIdTestigo2.Text = dtgPartidas.CurrentRow.Cells["idTestigo2"].Value.ToString();
                    fro.txbTestigo2.Text = dtgPartidas.CurrentRow.Cells["Testigo2"].Value.ToString();
                    fro.txbIdProfesional.Text = dtgPartidas.CurrentRow.Cells["idProfesional"].Value.ToString();
                    fro.txbProfesional.Text = dtgPartidas.CurrentRow.Cells["Profesional"].Value.ToString();
                    fro.cbxDepartamentos.SelectedIndex = fro.cbxDepartamentos.FindStringExact(dtgPartidas.CurrentRow.Cells["Departamento"].Value.ToString());
                    fro.cbxMunicipios.SelectedIndex = fro.cbxMunicipios.FindStringExact(dtgPartidas.CurrentRow.Cells["Lugardefallecimiento"].Value.ToString());
                    fro.cbxCantones.SelectedIndex = fro.cbxCantones.FindStringExact(dtgPartidas.CurrentRow.Cells["Canton"].Value.ToString());
                    fro.cbxCausas.SelectedIndex = fro.cbxCausas.FindStringExact(dtgPartidas.CurrentRow.Cells["Causa"].Value.ToString());
                    fro.dtpFecha.Value = Convert.ToDateTime(dtgPartidas.CurrentRow.Cells["FechaFallecimiento"].Value.ToString());
                    fro.txtHora.Text = dtgPartidas.CurrentRow.Cells["HoraFallecimiento"].Value.ToString();

                    //if (dtgPartidas.CurrentRow.Cells["Revisado"].Value.ToString().Equals("True"))
                    //{
                        fro.chbxRevisado.Checked = true;
                        fro.chbxRevisado.Enabled = false;
                        fro.btnConyuge.Enabled = false;
                        fro.btnDifunto.Enabled = false;
                        fro.btnInformante.Enabled = false;
                        fro.btnPadre.Enabled = false;
                        fro.btnMadre.Enabled = false;
                        fro.btnProfesional.Enabled = false;
                        fro.btnTestigo1.Enabled = false;
                        fro.btnTestigo2.Enabled = false;
                        fro.chbxAsistencia.Enabled = false;
                        //fro.cbxRespaldoPda.Enabled = false;
                        fro.txbLibro.ReadOnly = true;
                        fro.txbNumPartida.ReadOnly = true;
                        fro.txbFolio.ReadOnly = true;
                        fro.cbxCausas.Enabled = false;
                        fro.cbxDepartamentos.Enabled = false;
                        fro.cbxMunicipios.Enabled = false;
                        fro.txtHora.ReadOnly = true;
                        fro.dtpFecha.Enabled = false;
                        fro.cbxCantones.Enabled = false;

                        //fro.btnGuardar.Visible = false;
                    //}
                    fro.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
            else
            {
                MessageBox.Show("¡No tiene permisos para realizar esta acción!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarPartidas();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CargarMarginacion();
        }
    }
}

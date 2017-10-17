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
    public partial class GestionPartidas : Form
    {
        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
        SessionManager.MarginarPartida _Datos = SessionManager.MarginarPartida.Instancia;
        BindingSource _GRUPOS = new BindingSource();
        public GestionPartidas()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void GestionPartidas_Load(object sender, EventArgs e)
        {
            CargarPartidas();
        }

        private void CargarPartidas()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalmente()
        {
            _GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS();
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

        private void txbNueva_Click(object sender, EventArgs e)
        {
            PartidaEdicion frm = new PartidaEdicion();
            frm.ShowDialog();
            CargarPartidas();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (_SESION.Grupo == "Administrador" && (MessageBox.Show("¿Realmente desea marginar esta partida?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                InfanteEdicion.marginando = true;
                GestionInfantes._marginar = true;
                PartidaEdicion frm = new PartidaEdicion();
                frm.button2.Enabled = false;
                frm.button3.Enabled = false;
                frm.button4.Enabled = false;
                frm.Marginando = true;
                //frm.txbIdPartida.Text = dtgPartidas.CurrentRow.Cells["idPartida"].Value.ToString();
                _Datos.IdPartidaVieja = dtgPartidas.CurrentRow.Cells["idPartida"].Value.ToString();
                //frm.txbLibro.Text = dtgPartidas.CurrentRow.Cells["Libro"].Value.ToString();
                
                //frm.txbFolio.Text = dtgPartidas.CurrentRow.Cells["Folio"].Value.ToString();
               
                //frm.txbNumPartida.Text = dtgPartidas.CurrentRow.Cells["NumPartida"].Value.ToString();   
                
                frm.txtIdMadre.Text = dtgPartidas.CurrentRow.Cells["IdMadre"].Value.ToString();
                _Datos.IdMadre = dtgPartidas.CurrentRow.Cells["IdMadre"].Value.ToString();
                frm.txtNombreMadre.Text = dtgPartidas.CurrentRow.Cells["NombreMadre"].Value.ToString();
                _Datos.Madre = dtgPartidas.CurrentRow.Cells["NombreMadre"].Value.ToString();
                frm.txtIdPadre.Text = dtgPartidas.CurrentRow.Cells["IdPadre"].Value.ToString();
                _Datos.IdPadre = dtgPartidas.CurrentRow.Cells["IdPadre"].Value.ToString();
                frm.txtNombrePadre.Text = dtgPartidas.CurrentRow.Cells["NombrePadre"].Value.ToString();
                _Datos.Padre = dtgPartidas.CurrentRow.Cells["NombrePadre"].Value.ToString();
                frm.txtIdInformante.Text = dtgPartidas.CurrentRow.Cells["IdInformante"].Value.ToString();
                _Datos.IdInformante = dtgPartidas.CurrentRow.Cells["IdInformante"].Value.ToString();
                frm.txtNombreInformante.Text = dtgPartidas.CurrentRow.Cells["NombreInformante"].Value.ToString();
                _Datos.Informante = dtgPartidas.CurrentRow.Cells["NombreInformante"].Value.ToString();
                frm.txbIdInfante.Text = dtgPartidas.CurrentRow.Cells["IdInfante"].Value.ToString();
                _Datos.IdInfante = dtgPartidas.CurrentRow.Cells["IdInfante"].Value.ToString();
                frm.txbInfante.Text = dtgPartidas.CurrentRow.Cells["NombreInfante"].Value.ToString();
                _Datos.Infante = dtgPartidas.CurrentRow.Cells["NombreInfante"].Value.ToString();
                //frm.pictureBox1.ImageLocation = dtgPartidas.CurrentRow.Cells["Ruta"].Value.ToString();
                frm.ShowDialog();
                EdicionMarginacion frm1 = new EdicionMarginacion();
                frm1.txtIdPartida.Text = _Datos.IdPartidaVieja;
                frm1.txtNumPartida.Text = dtgPartidas.CurrentRow.Cells["NumPartida"].Value.ToString();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("¡No tiene permisos para realizar esta acción!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarPartidas();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS(Convert.ToDateTime(dateTimePicker1.Value.ToString()).ToString("yyyy-MM-dd"));
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void dtgPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbImprimir_Click(object sender, EventArgs e)
        {
            Reportes.VisorPartidaNac frm = new Reportes.VisorPartidaNac();
            frm.pictureBox1.ImageLocation = dtgPartidas.CurrentRow.Cells["Ruta"].Value.ToString();
            frm.IdPartida = dtgPartidas.CurrentRow.Cells["idPartida"].Value.ToString();
            frm.ShowDialog();
        }
    }
}

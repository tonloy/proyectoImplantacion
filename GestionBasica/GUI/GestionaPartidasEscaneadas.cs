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
    public partial class GestionaPartidasEscaneadas : Form
    {
        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
        SessionManager.MarginarPartida _Datos = SessionManager.MarginarPartida.Instancia;
        BindingSource _Partidas = new BindingSource();
        public GestionaPartidasEscaneadas()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            
        }

        private void GestionaPartidasEscaneadas_Load(object sender, EventArgs e)
        {
            CargarPartidas();
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
            _Partidas.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS_DEFUNCION();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _Partidas.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS_DEFUNCION(Convert.ToDateTime(dateTimePicker1.Value.ToString()).ToString("yyyy-MM-dd"));
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _Partidas;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Defunciones.DefuncionEdicion fmo = new Defunciones.DefuncionEdicion();
            fmo.ShowDialog();
            CargarPartidas();
        }

        private void dtgPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_SESION.Grupo == "Administrador" && (MessageBox.Show("¿Realmente desea marginar esta partida?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                
                _Datos.IdPartidaVieja = dtgPartidas.CurrentRow.Cells["ID"].Value.ToString();
                _Datos.IdInfante = dtgPartidas.CurrentRow.Cells["idDifunto"].Value.ToString();
                
                EdicionMarginacion frm1 = new EdicionMarginacion();
                frm1.txtIdPartida.Text = _Datos.IdPartidaVieja;
                frm1.seleccion = 1;
                frm1.txtNumPartida.Text = dtgPartidas.CurrentRow.Cells["NumPartida"].Value.ToString();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("¡No tiene permisos para realizar esta acción!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarPartidas();
        }

        private void txbImprimir_Click(object sender, EventArgs e)
        {
            if (dtgPartidas.CurrentRow.Cells["Imagen"].Value.ToString() == "") {
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

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
    public partial class GestionPdasMatrimonio : Form
    {
        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
        SessionManager.MarginarPartida _Datos = SessionManager.MarginarPartida.Instancia;
        BindingSource _GRUPOS = new BindingSource();

        public GestionPdasMatrimonio()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }


        private void GestionPdasMatrimonio_Load(object sender, EventArgs e)
        {
            CargarPartidas();
        }



        private void CargarPartidas()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODAS_PARTIDAS_MATRIMONIO();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }


        private void FiltrarLocalmente()
        {
            _GRUPOS.DataSource = CacheManager1.Cache.TODAS_PARTIDAS_MATRIMONIO();
            if (txbFiltrar.TextLength == 0)
            {
                _GRUPOS.RemoveFilter();
            }
            else
            {
                _GRUPOS.Filter = "Esposo like '%" + txbFiltrar.Text + "%'";
                //_GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS(txbFiltrar.Text);
            }
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }



        private void dtgPartidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            GestionBasica.GUI.Matrimonio.IngresarPartidaMat frm = new GestionBasica.GUI.Matrimonio.IngresarPartidaMat();
            CargarPartidas();
            frm.ShowDialog();
        }
    }
    
}

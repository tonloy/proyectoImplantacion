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
    }
}

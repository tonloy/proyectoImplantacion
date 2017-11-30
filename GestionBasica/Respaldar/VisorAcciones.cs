using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.Respaldar
{
    public partial class VisorAcciones : Form
    {
        BindingSource _EMPLEADOS = new BindingSource();
        public VisorAcciones()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void VisorAcciones_Load(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        private void dtgCostos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void CargarMovimientos()
        {
            try
            {
                _EMPLEADOS.DataSource = CacheManager1.Cache.TODOS_LOS_MOVIMIENTOS();
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
                _EMPLEADOS.RemoveFilter();
            }
            else
            {
                _EMPLEADOS.Filter = "Fecha like '%" + txbFiltrar.Text + "%'";
            }
            dtgCostos.AutoGenerateColumns = false;
            dtgCostos.DataSource = _EMPLEADOS;
            lblNumeroFilas.Text = dtgCostos.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void txbFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

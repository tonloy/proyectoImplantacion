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
    public partial class GestionTestigos : Form
    {
        String _idInfante;
        public String IdInfante1
        {
            get { return _idInfante; }
            set { _idInfante = value; }
        }

        BindingSource _GRUPOS = new BindingSource();
        public GestionTestigos()
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dataGridView1.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IInfante miInterfaz = this.Owner as IInfante;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdInfante(dataGridView1.CurrentRow.Cells["idPadre"].Value.ToString());
                miInterfaz.cambiarInfante(dataGridView1.CurrentRow.Cells["NombreCompleto"].Value.ToString());
            }
            this.Dispose();
        }
    }
}

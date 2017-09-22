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
    public partial class GestionInformantes : Form
    {
        BindingSource _GRUPOS = new BindingSource();
        public GestionInformantes()
        {
            InitializeComponent();
        }

        private void GestionInformantes_Load(object sender, EventArgs e)
        {
            CargarInformantes();
        }

        private void CargarInformantes()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODOS_LOS_INFORMANTES();
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

        private void txbNueva_Click(object sender, EventArgs e)
        {
            InformanteEdicion frm = new InformanteEdicion();
            frm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IInformante miInterfaz = this.Owner as IInformante;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdInformantes(dataGridView1.CurrentRow.Cells["IdInformante"].Value.ToString());
                miInterfaz.cambiarInformantes(dataGridView1.CurrentRow.Cells["NombreCompleto"].Value.ToString());
            }
            this.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI.Defunciones
{
    public partial class GestionDifuntos : Form
    {
        BindingSource _GRUPOS = new BindingSource();
        string _idPadre;
        public GestionDifuntos()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
            CargarPersonas();
        }

        public string IdPadre
        {
            get
            {
                return _idPadre;
            }

            set
            {
                _idPadre = value;
            }
        }

        private void CargarPersonas()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODOS_LOS_PADRES1();
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
                _GRUPOS.Filter = "NombreCompleto like '%" + txbFiltrar.Text + "%' or ConocidoPor like '%" + txbFiltrar.Text + "%'";
            }
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void GestionDifuntos_Load(object sender, EventArgs e)
        {
            if (_idPadre != null)
            {
                foreach (DataGridViewRow row in dtgPartidas.Rows)
                {
                    if (row.Cells["ID"].Value.ToString() == _idPadre)
                    {
                        dtgPartidas.ClearSelection();
                        dtgPartidas.CurrentCell = dtgPartidas.Rows[row.Index].Cells[0];
                        dtgPartidas.CurrentCell.Selected = true;
                    }
                }
            }
        }

        private void dtgPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            DifuntoEdicion fmr = new DifuntoEdicion();
            fmr.ShowDialog();
            CargarPersonas();
        }

        private void dtgPartidas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgPartidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IInfante miInterfaz = this.Owner as IInfante;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdInfante(dtgPartidas.CurrentRow.Cells["ID"].Value.ToString());
                miInterfaz.cambiarInfante(dtgPartidas.CurrentRow.Cells["Nombre"].Value.ToString());
            }
            this.Dispose();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }
    }
}

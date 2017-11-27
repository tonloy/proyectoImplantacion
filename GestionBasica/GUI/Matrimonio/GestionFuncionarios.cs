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
    public partial class GestionFuncionarios : Form
    {
        String IdFuncionario1;
        public string IdFuncionario11
        {
            get { return IdFuncionario1; }
            set { IdFuncionario1 = value; }
        }

        BindingSource _GRUPOS = new BindingSource();
        public GestionFuncionarios()
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
            dtgFuncionarios.AutoGenerateColumns = false;
            dtgFuncionarios.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgFuncionarios.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void dtgFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Matrimonio.IFuncionario miInterfaz = this.Owner as Matrimonio.IFuncionario;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdFuncionario(dtgFuncionarios.CurrentRow.Cells["idPadre"].Value.ToString());
                miInterfaz.cambiarfuncionario(dtgFuncionarios.CurrentRow.Cells["NombreCompleto"].Value.ToString());
            }
            this.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.Reportes
{
    public partial class VisorDefunciones : Form
    {
        BindingSource _Causas = new BindingSource();
        public VisorDefunciones()
        {
            InitializeComponent();
            CargarCausas();
        }

        private void CargarCausas()
        {
            try
            {
                _Causas.DataSource = CacheManager1.Cache.TODOS_LAS_CAUSAS_DE_MUERTE();
                cbxCausas.DataSource = null;
                cbxCausas.DataSource = _Causas;
                cbxCausas.DisplayMember = "Causa";
                cbxCausas.ValueMember = "idCausa";
                cbxCausas.Text = "Elija una causa";
            }
            catch
            {

            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                REP.VistaDefunciones cReporte = new REP.VistaDefunciones();
                cReporte.SetDataSource(CacheManager1.Cache.Reporte_defunciones1(dtpInicial.Text, dtpFinal.Text));
                cReporte.SetParameterValue("FechaInicial",dtpInicial.Text);
                cReporte.SetParameterValue("FechaFinal", dtpFinal.Text);
                crvNacimientos.ReportSource = cReporte;
            }else
            {
                REP.VistaDefunciones cReporte = new REP.VistaDefunciones();
                cReporte.SetDataSource(CacheManager1.Cache.Reporte_defunciones2(dtpInicial.Text, dtpFinal.Text,cbxCausas.SelectedValue.ToString()));
                cReporte.SetParameterValue("FechaInicial", dtpInicial.Text);
                cReporte.SetParameterValue("FechaFinal", dtpFinal.Text);
                crvNacimientos.ReportSource = cReporte;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cbxCausas.Enabled = true;
            }
        }
    }
}

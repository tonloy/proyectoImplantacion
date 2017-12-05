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
    public partial class VisorEstadisticaNacimientos : Form
    {
        SessionManager.Sesion _Sesion = SessionManager.Sesion.Instancia;
        public VisorEstadisticaNacimientos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            REP.Nacimientos cReporte = new REP.Nacimientos();
            cReporte.SetDataSource(CacheManager1.Cache.EstadisticaNacimientos(dtpInicial.Text,dtpFinal.Text,_Sesion.Usuario));
            crvNacimientos.ReportSource = cReporte;
        }

        private void VisorEstadisticaNacimientos_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class VisorPartidaNacGenerada : Form
    {
        Int32 idPartida;

        public Int32 IdPartida
        {
            get { return idPartida; }
            set { idPartida = value; }
        }
        public VisorPartidaNacGenerada()
        {
            InitializeComponent();
            
        }

        private void CargarPartida()
        {
            REP.VistaPreviaPartidaNac cReporte = new REP.VistaPreviaPartidaNac();
            cReporte.SetDataSource(CacheManager1.Cache.TODAS_LAS_PARTIDAS(idPartida));
            crvVisor.ReportSource = cReporte;
        }

        private void VisorPartidaNacGenerada_Load(object sender, EventArgs e)
        {
            CargarPartida();
        }
    }
}

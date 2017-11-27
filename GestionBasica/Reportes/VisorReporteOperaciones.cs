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
    public partial class VisorReporteOperaciones : Form
    {
        String tipo="Impresión de partida de nacimiento";
        String operacion="Partidas de nacimiento";
        public VisorReporteOperaciones()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(rbtnNacimientos.Checked || rbtnMatrimonios.Checked || rbtnDivorcios.Checked || rbtnDefunciones.Checked)
            {
                REP.Operaciones cReporte = new REP.Operaciones();
                cReporte.SetDataSource(CacheManager1.Cache.Reporte_Operaciones(dtpInicial.Text, dtpFinal.Text, tipo));
                cReporte.SetParameterValue("TipoOperacion",operacion);
                crvOperaciones.ReportSource = cReporte;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un tipo de documento");
            }
        }

        private void rbtnDefunciones_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDefunciones.Checked) {
                tipo = "Impresión de partida de defunción";
                operacion = "Partidas de defunción";
            }
            else
            {
                tipo = "Impresión de partida de nacimiento";
                operacion = "Partidas de nacimiento";
            }
        }

        private void rbtnMatrimonios_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMatrimonios.Checked)
            {
                tipo = "Impresión de partida de matrimonio";
                operacion = "Partidas de matrimonio";
            }
            else
            {
                tipo = "Impresión de partida de nacimiento";
                operacion = "Partidas de nacimiento";
            }
        }

        private void rbtnDivorcios_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDivorcios.Checked)
            {
                tipo = "Impresión de acta de divorcio";
                operacion = "Actas de divorcio";
            }
            else
            {
                tipo = "Impresión de partida de nacimiento";
                operacion = "Partidas de nacimiento";
            }
        }
    }
}

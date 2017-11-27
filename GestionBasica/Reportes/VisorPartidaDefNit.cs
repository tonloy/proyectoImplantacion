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
    public partial class VisorPartidaDefNit : Form
    {
        Int32 idPartida;
        String _idPartida;

        public string IdPartida
        {
            get
            {
                return _idPartida;
            }

            set
            {
                _idPartida = value;
            }
        }

        public int IdPartida1
        {
            get
            {
                return idPartida;
            }

            set
            {
                idPartida = value;
            }
        }

        public VisorPartidaDefNit()
        {
            InitializeComponent();
        }

        private void VisorPartidaDefNit_Load(object sender, EventArgs e)
        {
            CargarPartida();
            Operaciones();
        }

        private void CargarPartida()
        {
            REP.PartidaDefNit cReporte = new REP.PartidaDefNit();
            cReporte.SetDataSource(CacheManager1.Cache.TODAS_LAS_PARTIDAS_DEFUNCION_REPORTE2(IdPartida1));
            String fecha = GestionBasica.CLS.Hora.fecha_letras(DateTime.Today.ToString("yyyy-MM-dd"));
            cReporte.SetParameterValue("FechaActual", fecha);
            crvVisor.ReportSource = cReporte;
        }

        private void Operaciones()
        {
            CLS.Operaciones oUsuario = new CLS.Operaciones();
            oUsuario.IdPartida = IdPartida;
            try
            {
                if (oUsuario.Guardar(8))
                {

                }
                else
                {
                    MessageBox.Show("El registro no fue insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

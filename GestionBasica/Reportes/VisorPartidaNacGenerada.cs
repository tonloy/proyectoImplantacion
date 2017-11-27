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
        String _idPartida;

        public Int32 IdPartida
        {
            get { return idPartida; }
            set { idPartida = value; }
        }

        public string IdPartida1
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

        public VisorPartidaNacGenerada()
        {
            InitializeComponent();
            
        }

        private void CargarPartida()
        {
            REP.VistaPreviaPartidaNac cReporte = new REP.VistaPreviaPartidaNac();
            cReporte.SetDataSource(CacheManager1.Cache.TODAS_LAS_PARTIDAS(idPartida));
            String fecha = GestionBasica.CLS.Hora.fecha_letras(DateTime.Today.ToString("yyyy-MM-dd"));
            cReporte.SetParameterValue("FechaActual",fecha);
            crvVisor.ReportSource = cReporte;
        }

        private void VisorPartidaNacGenerada_Load(object sender, EventArgs e)
        {
            CargarPartida();
            Operaciones();
        }
        private void Operaciones()
        {
            CLS.Operaciones oUsuario = new CLS.Operaciones();
            oUsuario.IdPartida = _idPartida;
            try
            {
                if (oUsuario.Guardar(2))
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

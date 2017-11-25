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
    public partial class VisorPartidaDefGenerada : Form
    {
        Int32 idPartida;
        String _idPartida;
        public VisorPartidaDefGenerada()
        {
            InitializeComponent();
        }

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

        private void CargarPartida()
        {
            REP.VistaPreviaPartidaDef cReporte = new REP.VistaPreviaPartidaDef();
            cReporte.SetDataSource(CacheManager1.Cache.TODAS_LAS_PARTIDAS_DEFUNCION_REPORTE(idPartida));
            crvVisor.ReportSource = cReporte;
        }

        private void VisorPartidaDefGenerada_Load(object sender, EventArgs e)
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

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
    public partial class VisorPartidaMatrimonio : Form
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


        private void CargarPartida()
        {
            REP.PdaMatrimonio cReporte = new REP.PdaMatrimonio();
            cReporte.SetDataSource(CacheManager1.Cache.REPORTE_PARTIDA_MATRIMONIO(idPartida));
            crvVisorMat.ReportSource = cReporte;
        }

        public VisorPartidaMatrimonio()
        {
            InitializeComponent();
        

        }

        private void Operaciones()
        {
            CLS.Operaciones oUsuario = new CLS.Operaciones();
            oUsuario.IdPartida = _idPartida;
            try
            {
                if (oUsuario.Guardar(4))
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

        private void VisorPartidaMatrimonio_Load(object sender, EventArgs e)
        {
            CargarPartida();
            Operaciones();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI.Marginadas
{
    public partial class MarginacionesNac : Form
    {
        BindingSource _GRUPOS = new BindingSource();
        String idPartida;
        public MarginacionesNac()
        {
            InitializeComponent();
        }

        public string IdPartida
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

        private void MarginacionesNac_Load(object sender, EventArgs e)
        {
            CargarMarginaciones();
        }

        private void CargarMarginaciones()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.MarginacionesNac(idPartida);
                FiltrarLocalmente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalmente()
        {
            
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }
    }
}

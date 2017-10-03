using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI
{
    public partial class EdicionMarginacion : Form
    {
        BindingSource _Juzgados = new BindingSource();
        public EdicionMarginacion()
        {
            InitializeComponent();
            CargarJuzgados();
        }

        private void EdicionMarginacion_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CargarJuzgados()
        {
            try
            {
                _Juzgados.DataSource = CacheManager1.Cache.TODOS_LOS_JUZGADOS();
                cbxJuzgados.DataSource = null;
                cbxJuzgados.DataSource = _Juzgados;
                cbxJuzgados.DisplayMember = "Nombre";
                cbxJuzgados.ValueMember = "idJuzgados";
                cbxJuzgados.Text = "Seleccione un juzgado";
            }
            catch
            {

            }
        }
    }
}

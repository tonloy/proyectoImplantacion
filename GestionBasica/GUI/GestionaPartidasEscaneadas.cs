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
    public partial class GestionaPartidasEscaneadas : Form
    {
        public GestionaPartidasEscaneadas()
        {
            InitializeComponent();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            PartidaEdicion frm = new PartidaEdicion();
            frm.ShowDialog();
            EdicionMarginacion frm1 = new EdicionMarginacion();
            frm1.ShowDialog();
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            EdicionNuevoEscaneo frm = new EdicionNuevoEscaneo();
            frm.ShowDialog();
        }
    }
}

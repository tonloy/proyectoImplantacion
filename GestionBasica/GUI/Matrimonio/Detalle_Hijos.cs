using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI.Matrimonio
{
    public partial class Detalle_Hijos : Form
    {
        public static string detalle_hijosfrm;
        public Detalle_Hijos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            detalle_hijosfrm = txtDetalleHijos.Text;
            Close();
        }

        private void Detalle_Hijos_Load(object sender, EventArgs e)
        {
            txtDetalleHijos.Text = detalle_hijosfrm;
        }
    }
}

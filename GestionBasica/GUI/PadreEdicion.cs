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
    public partial class PadreEdicion : Form
    {
        public PadreEdicion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InformanteEdicion frm = new InformanteEdicion();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class MadreEdicion : Form
    {
        public MadreEdicion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PadreEdicion frm = new PadreEdicion();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

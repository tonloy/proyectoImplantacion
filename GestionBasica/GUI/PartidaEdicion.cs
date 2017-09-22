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
    public partial class PartidaEdicion : Form,IInfante
    {
        public PartidaEdicion()
        {
            InitializeComponent();
        }

        public void cambiarIdInfante(String idInfante)
        {
            txbIdInfante.Text = idInfante;
        }
        public void cambiarInfante(String infante)
        {
            txbInfante.Text = infante;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionInfantes frm = new GestionInfantes();
            frm.Show(this);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionPadres frm = new GestionPadres();
            frm.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionPadres frm = new GestionPadres();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionInformantes frm = new GestionInformantes();
            frm.ShowDialog();
        }

        private void PartidaEdicion_Load(object sender, EventArgs e)
        {

        }
    }
}

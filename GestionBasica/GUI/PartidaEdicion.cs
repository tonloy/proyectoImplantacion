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
    public partial class PartidaEdicion : Form,IInfante,IPadre
    {
        public PartidaEdicion()
        {
            InitializeComponent();
        }

        //Infantes
        public void cambiarIdInfante(String idInfante)
        {
            txbIdInfante.Text = idInfante;
        }
        public void cambiarInfante(String infante)
        {
            txbInfante.Text = infante;
        }

        //padres
        public void cambiarIdPadre(String idPadre)
        {
            txtIdPadre.Text = idPadre;
        }
        public void cambiarPadre(String Padre)
        {
            txtNombrePadre.Text = Padre;
        }


        //madres
        public void cambiarIdMadre(String idMadre)
        {
           txtIdMadre.Text = idMadre;
        }
        public void cambiarMadre(String Madre)
        {
            txtNombreMadre.Text = Madre;
        }


        //Informante
        public void cambiarIdInformantes(String idInformante)
        {
            txtIdInformante.Text = idInformante;
        }
        public void cambiarInformantes(String Informante)
        {
           txtNombreInformante.Text = Informante;
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
            frm.Show(this);
        }

        private void PartidaEdicion_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

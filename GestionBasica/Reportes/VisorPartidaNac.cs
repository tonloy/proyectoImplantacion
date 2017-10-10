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
    public partial class VisorPartidaNac : Form
    {
        String _idPartida;

        public String IdPartida
        {
            get { return _idPartida; }
            set { _idPartida = value; }
        }
        public VisorPartidaNac()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void VisorPartidaNac_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDialog myPrinDialog1 = new PrintDialog();
            myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            myPrinDialog1.Document = myPrintDocument1;

            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            {
               myPrintDocument1.Print();
            }
            Operaciones();
        }

        private void Operaciones()
        {
            CLS.Operaciones oUsuario = new CLS.Operaciones();
            oUsuario.IdPartida = _idPartida;
            try
            {
                if (oUsuario.Guardar(2))
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagen = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(imagen, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(imagen,0,0);

            imagen.Dispose();
        }
    }
}

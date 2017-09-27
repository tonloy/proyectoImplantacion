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
    public partial class SeleccionImagen : Form,IImagen
    {
        public SeleccionImagen()
        {
            InitializeComponent();
        }
        //Recibir imagen
        public void cambiarImagen(String ruta)
        {
            pictureBox1.ImageLocation = ruta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SeleccionImagen_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation == null)
            {
                MessageBox.Show("Seleccione una imagen por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IImagen miInterfaz = this.Owner as IImagen;
                if (miInterfaz != null)
                {
                    miInterfaz.cambiarImagen(pictureBox1.ImageLocation);
                }
                this.Dispose();
            }
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            EscanearImagen frm = new EscanearImagen();
            frm.Show(this);
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Abrir.ShowDialog() == DialogResult.OK)
                {
                    string imagen = Abrir.FileName;
                    //pictureBox1.Image = Image.FromFile(imagen);
                    pictureBox1.ImageLocation = Abrir.FileName;
                }
            }
            catch
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}

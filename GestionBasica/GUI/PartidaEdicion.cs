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
    public partial class PartidaEdicion : Form,IInfante,IPadre,IInformante,IImagen
    {
        Boolean marginando = false;

        public Boolean Marginando
        {
            get { return marginando; }
            set { marginando = value; }
        }
        String ruta_imagen;
        public PartidaEdicion()
        {
            InitializeComponent();
        }
        //Imagen
        public void cambiarImagen(String ruta)
        {
            pictureBox1.ImageLocation = ruta;
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

        private String obtenerRuta(String rtpbx)
        {
            ruta_imagen = rtpbx.Replace("\\","\\\\");
            return ruta_imagen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbIdInfante.TextLength > 0)
            {
                GestionInfantes frm = new GestionInfantes();
                frm.IdInfante1 = txbIdInfante.Text;                
                frm.Show(this);
            }
            else
            {
                GestionInfantes frm = new GestionInfantes();
                frm.Show(this);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Madres
            if (txtIdMadre.TextLength > 0)
            {
                GestionMadres frm = new GestionMadres();
                frm.IdMadre = txtIdMadre.Text;
                frm.Show(this);
            }
            else
            {
                GestionMadres frm = new GestionMadres();
                frm.Show(this);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIdPadre.TextLength > 0)
            {
                GestionPadres frm = new GestionPadres();
                frm.IdPadre1 = txtIdPadre.Text;
                frm.Show(this);
            }
            else
            {
                GestionPadres frm = new GestionPadres();
                frm.Show(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtIdInformante.TextLength > 0)
            {
                GestionInformantes frm = new GestionInformantes();
                frm.IdInformante1 = txtIdInformante.Text;
                frm.Show(this);
            }
            else
            {
                GestionInformantes frm = new GestionInformantes();
                frm.Show(this);
            }
        }

        private void PartidaEdicion_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            SeleccionImagen frm = new SeleccionImagen();
            frm.Show(this);
        }

        private void Procesar()
        {
            CLS.PartidaNac oUsuario = new CLS.PartidaNac();

            oUsuario.IdInfante = txbIdInfante.Text;
            oUsuario.IdMadre = txtIdMadre.Text;
            oUsuario.IdPadre = txtIdPadre.Text;
            oUsuario.IdInformante = txtIdInformante.Text;
            oUsuario.Folio = txbFolio.Text;
            oUsuario.Libro = txbLibro.Text;
            oUsuario.NumPartida = txbNumPartida.Text;
            oUsuario.IdPartida = txbIdPartida.Text;
            oUsuario.Ruta = obtenerRuta(pictureBox1.ImageLocation);

            if (ValidarDatos())
            {
                if (marginando)
                {
                    Close();
                }
                else
                {
                    //Insertando
                    try
                    {
                        if (oUsuario.Guardar())
                        {
                            MessageBox.Show("Registro insertado correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
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
            }
        }

        private Boolean ValidarDatos()
        {
            Boolean Validado = true;
            Notificador.Clear();
            if (txbFolio.TextLength == 0)
            {
                Notificador.SetError(txbFolio, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txbLibro.TextLength == 0)
            {
                Notificador.SetError(txbLibro, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txbNumPartida.TextLength == 0)
            {
                Notificador.SetError(txbNumPartida, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txbIdInfante.TextLength == 0)
            {
                Notificador.SetError(button1, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txtIdMadre.TextLength == 0)
            {
                Notificador.SetError(button2, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txtIdPadre.TextLength == 0)
            {
                Notificador.SetError(button3, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txtIdInformante.TextLength == 0)
            {
                Notificador.SetError(button4, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (pictureBox1.ImageLocation.Length == 0)
            {
                Notificador.SetError(pictureBox1, "Seleccione una imagen");
                Validado = false;
            }

            return Validado;
        }
    }
}

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
            //Madres
            GestionMadres frm = new GestionMadres();
            frm.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionPadres frm = new GestionPadres();
            frm.Show(this);
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
            oUsuario.Ruta = pictureBox1.ImageLocation;

            if (ValidarDatos())
            {
                if (txbIdPartida.TextLength > 0)
                {
                    /*Actualizando
                    try
                    {
                        if (oUsuario.Actualizar())
                        {
                            MessageBox.Show("Registro actualizado correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
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

            return Validado;
        }
    }
}

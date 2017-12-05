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
        SessionManager.MarginarPartida _Datos = SessionManager.MarginarPartida.Instancia;
        SessionManager.Sesion _Sesion = SessionManager.Sesion.Instancia;

        public Boolean Marginando
        {
            get { return marginando; }
            set { marginando = value; }
        }
        String ruta_imagen;
        public PartidaEdicion()
        {
          
            InitializeComponent();
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
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
                frm.ShowDialog(this);
            }
            else
            {
                GestionInfantes frm = new GestionInfantes();
                frm.ShowDialog(this);
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
                frm.ShowDialog(this);
            }
            else
            {
                GestionMadres frm = new GestionMadres();
                frm.ShowDialog(this);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIdPadre.TextLength > 0)
            {
                GestionPadres frm = new GestionPadres();
                frm.IdPadre1 = txtIdPadre.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionPadres frm = new GestionPadres();
                frm.ShowDialog(this);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtIdInformante.TextLength > 0)
            {
                GestionInformantes frm = new GestionInformantes();
                frm.IdInformante1 = txtIdInformante.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionInformantes frm = new GestionInformantes();
                frm.ShowDialog(this);
            }
        }

        private void PartidaEdicion_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Procesar();
            if (txbIdPartida.TextLength < 0)
            {
                Operaciones();
            }
        }

        private void Operaciones()
        {
            CLS.Operaciones oUsuario = new CLS.Operaciones();
            try
            {
                if (oUsuario.Guardar(1))
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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            SeleccionImagen frm = new SeleccionImagen();
            frm.ShowDialog(this);
        }

        private void Procesar()
        {
            CLS.PartidaNac oUsuario = new CLS.PartidaNac();

            oUsuario.IdInfante = txbIdInfante.Text;
            oUsuario.IdMadre = txtIdMadre.Text;
            oUsuario.IdPadre = txtIdPadre.Text;
            oUsuario.IdInformante = txtIdInformante.Text;
            oUsuario.Tomo = txbFolio.Text;
            oUsuario.Libro = txbLibro.Text;
            oUsuario.NumPartida = txbNumPartida.Text;
            oUsuario.IdPartida = txbIdPartida.Text;
            oUsuario.Ruta = obtenerRuta(pictureBox1.ImageLocation);
            oUsuario.Tomo_letras = CLS.Conv.enletras(txbFolio.Text);
            oUsuario.Libro_letras = CLS.Conv.enletras(txbLibro.Text);
            oUsuario.NumPartida_letras = CLS.Conv.enletras(txbNumPartida.Text);
            oUsuario.Anio_insercion_letras1 = CLS.Conv.enletras(DateTime.Today.Year.ToString());
            oUsuario.Fecha_insercion_letras1 = CLS.Hora.fecha_letras(DateTime.Today.ToString("yyyy-MM-dd"));

            CLS.Movimiento nuevo = new CLS.Movimiento();            
            nuevo.IdUsuario = _Sesion.IdUsuario;

            if (ValidarDatos())
            {
                if (txtIdPadre.TextLength == 0)
                {
                    oUsuario.IdPadre = "23";
                }
                if (txtIdMadre.TextLength == 0)
                {
                    oUsuario.IdMadre = "23";
                }
                if (marginando)
                {
                    _Datos.Tomo = txbFolio.Text;
                    _Datos.Libro = txbLibro.Text;
                    _Datos.NumPartida = txbNumPartida.Text;
                    _Datos.Ruta = obtenerRuta(pictureBox1.ImageLocation);
                    _Datos.Tomo_letras = oUsuario.Tomo_letras;
                    _Datos.Libro_letras = oUsuario.Libro_letras;
                    _Datos.NumPartida_letras = oUsuario.NumPartida_letras;
                    _Datos.AnioInsercionLetras = oUsuario.Anio_insercion_letras1;

                    //nuevo.Accion = "El usuario " + _Sesion.Usuario + " marginó la partida de nacimiento número " + oUsuario.NumPartida;
                    //nuevo.Guardar();

                    Close();
                }
                else
                {
                    if (txbIdPartida.TextLength > 0) {
                        try
                        {
                            if (oUsuario.Actualizar())
                            {
                                nuevo.Accion = "El usuario " + _Sesion.Usuario + " actualizó la partida de nacimiento número "+ oUsuario.NumPartida;
                                nuevo.Guardar();
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
                        }
                    }
                    //Insertando
                    else
                    {
                        try
                        {
                            if (oUsuario.Guardar())
                            {
                                nuevo.Accion = "El usuario " + _Sesion.Usuario + " registró la partida de nacimiento número "+ oUsuario.NumPartida;
                                nuevo.Guardar();
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
            if (txtIdMadre.TextLength == 0 && txtIdPadre.TextLength == 0)
            {
                if (txtIdMadre.TextLength == 0) { Notificador.SetError(button2, "Este campo no puede quedar vacío."); }
                if(txtIdPadre.TextLength == 0) { Notificador.SetError(button3, "Este campo no puede quedar vacío."); }                
                Validado = false;
            }
            /*if (txtIdPadre.TextLength == 0)
            {
                Notificador.SetError(button3, "Este campo no puede quedar vacío.");
                Validado = false;
            }*/
            if (txtIdInformante.TextLength == 0)
            {
                Notificador.SetError(button4, "Este campo no puede quedar vacío.");
                Validado = false;
            }

            return Validado;
        }

        private void cbxRespaldoPda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRespaldoPda.Checked)
            {
                pictureBox1.Visible = true;
            }
            else {
                pictureBox1.Visible = false; 
            }             
        }

        private void txbLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) || (e.KeyChar == (char)Keys.Space))
            {
                Notificador.SetError(txbLibro, "Solo se permiten números");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) || (e.KeyChar == (char)Keys.Space))
            {
                Notificador.SetError(txbFolio, "Solo se permiten números");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txbNumPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) || (e.KeyChar == (char)Keys.Space))
            {
                Notificador.SetError(txbNumPartida, "Solo se permiten números");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txbLibro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbInfante_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1,"Haga doble clic para seleccionar una imagen");
            
        }
    }
}

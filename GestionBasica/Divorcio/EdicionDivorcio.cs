using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.Divorcio
{
    public partial class EdicionDivorcio : Form, GestionBasica.GUI.IImagen,IDivorcio
    {
        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
        BindingSource _Juzgados = new BindingSource();
        BindingSource _Datos = new BindingSource();
        DataTable datos = new DataTable();
        String ruta_imagen;
        int revisado;
        SessionManager.Sesion _Sesion = SessionManager.Sesion.Instancia;
        public static String idEsposo;
        public static String idEsposa;

        public EdicionDivorcio()
        {
            InitializeComponent();
            CargarJuzgados();
        }

        //Imagen
        public void cambiarImagen(String ruta)
        {
            pictureBox1.ImageLocation = ruta;
        }

        //Pda matrimonio
        public void cambiarIdMatrimonio(String id)
        {
            txbIdMatrimonio.Text = id;
        }

        public void cambiarFolio(String infante)
        {
            txbFolioMat.Text = infante;
        }
        public void cambiarNumPartida(String pda)
        {
            txbNumPartidaMat.Text = pda;
        }
        public void cambiarRegimen(String pda)
        {
            txbRegimen.Text = pda;
        }
        public void cambiarEsposo(String esposo)
        {
            txbHombre.Text = esposo;
        }
        public void cambiarEsposa(String esposa)
        {
            txbMujer.Text = esposa;
        }
        public void cambiarFechaMat(String fecha)
        {
            txbFechaMat.Text = fecha;
        }

        private void CargarJuzgados()
        {
            try
            {
                _Juzgados.DataSource = CacheManager1.Cache.TODOS_LOS_JUZGADOS();
                cbxJuzgados.DataSource = null;
                cbxJuzgados.DataSource = _Juzgados;
                cbxJuzgados.DisplayMember = "Nombre";
                cbxJuzgados.ValueMember = "idJuzgados";
                cbxJuzgados.Text = "Seleccione un juzgado";
            }
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EdicionDivorcio_Load(object sender, EventArgs e)
        {

        }

        private void chbxRespaldo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxRespaldo.Checked)
            {
                pictureBox1.Visible = true;
            }else
            {
                pictureBox1.Visible = false;
            }
        }

        private String obtenerRuta(String rtpbx)
        {
            ruta_imagen = rtpbx.Replace("\\", "\\\\");
            return ruta_imagen;
        }

        private Boolean ValidarDatos()
        {
            Boolean Validado = true;
            Notificador.Clear();
            if (txbLibro.TextLength == 0)
            {
                Notificador.SetError(txbLibro, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txbFolio.TextLength == 0)
            {
                Notificador.SetError(txbFolio, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txbNumPartida.TextLength == 0)
            {
                Notificador.SetError(txbNumPartida, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txbIdMatrimonio.TextLength == 0)
            {
                Notificador.SetError(btnSeleccionar, "Seleccione una partida de matrimonio.");
                Validado = false;
            }
            if (txbNotario.TextLength == 0)
            {
                Notificador.SetError(txbNotario, "Este campo no puede ir vacío.");
                Validado = false;
            }
            if (txbTutela.TextLength == 0)
            {
                Notificador.SetError(txbTutela, "Este campo no puede vacío.");
                Validado = false;
            }
            if (chbxRespaldo.Checked && pictureBox1.ImageLocation == "")
            {
                Notificador.SetError(pictureBox1, "Seleccione un imagen de respaldo.");
                Validado = false;
            }
            if (chbxRevisado.Checked && pictureBox1.ImageLocation == "")
            {
                pictureBox1.Visible = true;
                chbxRespaldo.Checked = true;
                Notificador.SetError(pictureBox1, "Seleccione un imagen de respaldo.");
                Validado = false;
            }

            return Validado;
        }

        private void Operaciones()
        {
            CLS.Operaciones oUsuario = new CLS.Operaciones();
            try
            {
                if (oUsuario.Guardar(5))
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

        private void Procesar()
        {
            CLS.Divorcio oUsuario = new CLS.Divorcio();

            oUsuario.IdDivorcio = txbIdPartida.Text;
            oUsuario.NumPartida1 = txbNumPartida.Text;
            oUsuario.Libro1 = txbLibro.Text;
            oUsuario.Folio1 = txbFolio.Text;
            oUsuario.IdMatrimonio = txbIdMatrimonio.Text;
            oUsuario.Fecha_sentencia1= Convert.ToDateTime(dtpFechaSentencia.Value.ToString()).ToString("yyyy-MM-dd");
            oUsuario.Fecha_ejecutoriada1= Convert.ToDateTime(dtpFechaEjecutoriada.Value.ToString()).ToString("yyyy-MM-dd");
            oUsuario.NombreNotario1 = txbNotario.Text;
            oUsuario.Tutela1 = txbTutela.Text;
            oUsuario.Libro_letras1 = CLS.Conv.enletras(txbLibro.Text);
            oUsuario.Folio_letras1 = CLS.Conv.enletras(txbFolio.Text);
            oUsuario.NumActa_letras1 = CLS.Conv.enletras(txbNumPartida.Text);
            oUsuario.IdJuzgado = cbxJuzgados.SelectedValue.ToString();

            CLS.Movimiento nue = new CLS.Movimiento();
            nue.IdUsuario = _Sesion.IdUsuario;

            if (ValidarDatos())
            {
                if (chbxRevisado.Checked)
                {
                    revisado = 1;
                }
                else
                {
                    revisado = 0;
                }
                
                if (chbxRespaldo.Checked)
                {
                    oUsuario.Imagen1 = obtenerRuta(pictureBox1.ImageLocation);
                }
                else
                {
                    oUsuario.Imagen1 = "";
                }
                
                    if (txbIdPartida.TextLength > 0)
                    {
                        //Actualizando
                        try
                        {
                            if (oUsuario.Modificar(revisado))
                            {
                                nue.Accion = "El usuario " + _Sesion.Usuario + " actualizó la partida de divorcio número " + oUsuario.NumPartida1;
                                nue.Guardar();
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
                    else
                    {
                        //Insertando
                        try
                        {
                            if (oUsuario.Guardar(revisado))
                            {
                                MarginarPartidaNac();
                                nue.Accion = "El usuario " + _Sesion.Usuario + " registró la partida de divorcio número " + oUsuario.NumPartida1;
                                nue.Guardar();
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
        private void MarginarPartidaNac()
        {
            CLS.Marginacion mar = new CLS.Marginacion();
            mar.Explicacion = "El señor " + txbHombre.Text + " se divorció de " + txbMujer.Text + " el día " + dtpFechaSentencia.Value.ToString();

            mar.Marginar_por_Divorcio1(idEsposo);

            CLS.Marginacion marg = new CLS.Marginacion();
            marg.Explicacion = "La señora " + txbMujer.Text + " se divorció de " + txbHombre.Text + " el día " + dtpFechaSentencia.Value.ToString();

            marg.Marginar_por_Divorcio2(idEsposa);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
            if (txbIdPartida.Text=="")
            {
                Operaciones();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            GUI.Matrimonio.GestionPdasMatrimonio fom = new GUI.Matrimonio.GestionPdasMatrimonio();
            fom.ShowDialog(this);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            GUI.SeleccionImagen frm = new GUI.SeleccionImagen();
            frm.ShowDialog(this);
        }

        private void txbIdMatrimonio_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
    }


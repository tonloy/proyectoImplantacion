using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI
{
    public partial class EdicionMarginacion : Form
    {
        SessionManager.Sesion _Sesion = SessionManager.Sesion.Instancia;

        SessionManager.MarginarPartida _Datos = SessionManager.MarginarPartida.Instancia;
        BindingSource _Juzgados = new BindingSource();
        public int seleccion = 0;
        public EdicionMarginacion()
        {
            InitializeComponent();
            CargarJuzgados();
        }

        private void EdicionMarginacion_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 0:
                    Procesar();
                    break;
                case 1:
                    ProcesarDefuncion();
                    break;
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
        private void Procesar()
        {
            CLS.Marginacion oUsuario = new CLS.Marginacion();

            oUsuario.NumPartida = txtIdPartida.Text;
            oUsuario.Explicacion = txtExplicacion.Text;
            _Datos.FechaSentencia = Convert.ToDateTime(dtpFechaSentencia.Value.ToString()).ToString("yyyy-MM-dd");

            CLS.Movimiento nueo = new CLS.Movimiento();

            nueo.Accion = "El usuario " + _Sesion.Usuario + " marginó la partida de nacimiento número " + txtNumPartida.Text;
            nueo.IdUsuario = _Sesion.IdUsuario;

            if (mtxtHoraSentencia.MaskCompleted) { 
                _Datos.HoraSentencia = Convert.ToDateTime(mtxtHoraSentencia.Text).ToShortTimeString(); }
            _Datos.IdJuzgado = cbxJuzgados.SelectedValue.ToString();

            if (ValidarDatos())
            {
                //Insertando
                    try
                    {
                        if (oUsuario.Guardar())
                        {
                        nueo.Guardar();
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
        private void ProcesarDefuncion()
        {
            CLS.Marginacion oUsuario = new CLS.Marginacion();

            oUsuario.NumPartida = txtIdPartida.Text;
            oUsuario.Explicacion = txtExplicacion.Text;
            _Datos.FechaSentencia = Convert.ToDateTime(dtpFechaSentencia.Value.ToString()).ToString("yyyy-MM-dd");

            CLS.Movimiento njuevo = new CLS.Movimiento();
            njuevo.Accion = "El usuario " + _Sesion.Usuario + " marginó la partida de defunción número " + txtNumPartida.Text;
            njuevo.IdUsuario = _Sesion.IdUsuario;

            if (mtxtHoraSentencia.MaskCompleted)
            {
                _Datos.HoraSentencia = Convert.ToDateTime(mtxtHoraSentencia.Text).ToShortTimeString();
            }
            _Datos.IdJuzgado = cbxJuzgados.SelectedValue.ToString();

            if (ValidarDatos())
            {
                //Insertando
                try
                {
                    if (oUsuario.GuardarDefuncion())
                    {
                        njuevo.Guardar();
                        MessageBox.Show("Partida marginada correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("La marginación no se pudo realizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private Boolean ValidarDatos()
        {
            Boolean Validado = true;
            Notificador.Clear();
            if (mtxtHoraSentencia.TextLength == 0 || !mtxtHoraSentencia.MaskCompleted)
            {
                Notificador.SetError(mtxtHoraSentencia, "Este campo no puede quedar vacío o incompleto.");
                Validado = false;
            }
            if (dtpFechaSentencia.Value == null)
            {
                Notificador.SetError(dtpFechaSentencia, "Seleccione una fecha.");
                Validado = false;
            }
            if (txtExplicacion.TextLength == 0)
            {
                Notificador.SetError(txtExplicacion, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (cbxJuzgados.SelectedValue == null)
            {
                Notificador.SetError(cbxJuzgados, "Seleccione una juzgado.");
                Validado = false;
            }
            if (!esHoraValida())
            {
                Notificador.SetError(mtxtHoraSentencia, "La hora ingresada no es válida.");
                Validado = false;
            }
            return Validado;
        }

        private Boolean esHoraValida()
        {
            Regex r = new Regex("([0-1][0-9]|2[0-3]):[0-5][0-9]");
            Boolean sw = true;
            if (!r.Match(mtxtHoraSentencia.Text).Success)
            {
                sw = false;
            }
            return sw;
        }
    }
}

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
    public partial class EdicionMarginacion : Form
    {
        SessionManager.MarginarPartida _Datos = SessionManager.MarginarPartida.Instancia;
        BindingSource _Juzgados = new BindingSource();
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
            Procesar();
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
            _Datos.HoraSentencia = Convert.ToDateTime(mtxtHoraSentencia.Text).ToShortTimeString();
            _Datos.IdJuzgado = cbxJuzgados.SelectedValue.ToString();

            if (ValidarDatos())
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
            return Validado;
        }
    }
}

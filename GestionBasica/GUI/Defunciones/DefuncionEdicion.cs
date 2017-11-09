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

namespace GestionBasica.GUI.Defunciones
{
    public partial class DefuncionEdicion : Form
    {
        Boolean marginando = false;
        BindingSource _Municipio = new BindingSource();
        BindingSource _Departamentos = new BindingSource();
        BindingSource _Causas = new BindingSource();
        String ruta_imagen;

        public bool Marginando
        {
            get
            {
                return marginando;
            }

            set
            {
                marginando = value;
            }
        }

        public DefuncionEdicion()
        {
            InitializeComponent();
            CargarDepartamentos();
            CargarMunicipios();
            CargarCausas();
        }

        //Imagen
        public void cambiarImagen(String ruta)
        {
            pictureBox1.ImageLocation = ruta;
        }

        //Difuntos
        public void cambiarIdInfante(String idInfante)
        {
            txbIdDifunto.Text = idInfante;
        }
        public void cambiarInfante(String infante)
        {
            txbDifunto.Text = infante;
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

        private void CargarDepartamentos()
        {
            try
            {
                _Departamentos.DataSource = CacheManager1.Cache.TODOS_LOS_DEPARTAMENTOS();
                cbxDepartamentos.DataSource = null;
                cbxDepartamentos.DataSource = _Departamentos;
                cbxDepartamentos.DisplayMember = "Departamento";
                cbxDepartamentos.ValueMember = "idDepartamento";
                cbxDepartamentos.Text = "Elija un Departamento";
            }
            catch
            {

            }
        }

        private void CargarCausas()
        {
            try
            {
                _Causas.DataSource = CacheManager1.Cache.TODOS_LAS_CAUSAS_DE_MUERTE();
                cbxCausas.DataSource = null;
                cbxCausas.DataSource = _Causas;
                cbxCausas.DisplayMember = "Causa";
                cbxCausas.ValueMember = "idCausa";
                cbxCausas.Text = "Elija una causa";
            }
            catch
            {

            }
        }

        private void CargarMunicipios()
        {
            DataView dv = new DataView(CacheManager1.Cache.TODOS_LOS_MUNICIPIOS());
            dv.RowFilter = "idDepartamento = " + (cbxDepartamentos.SelectedIndex + 1);
            cbxMunicipios.DataSource = dv.ToTable();
            cbxMunicipios.DisplayMember = "municipio";
            cbxMunicipios.ValueMember = "idMunicipio";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbxAsistencia_CheckStateChanged(object sender, EventArgs e)
        {
            if (!chbxAsistencia.Checked)
            {
                btnProfesional.Enabled = false;
            }else
            {
                btnProfesional.Enabled = true;
            }
        }

        private void cbxRespaldoPda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRespaldoPda.Checked)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void DefuncionEdicion_Load(object sender, EventArgs e)
        {

        }

        private void txtHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartamentos.Items.Count > 0)
            {
                CargarMunicipios();
            }
        }

        private Boolean esHoraValida()
        {
            Regex r = new Regex("([0-1][0-9]|2[0-3]):[0-5][0-9]");
            Boolean sw = true;
            if (!r.Match(txtHora.Text).Success)
            {
                sw = false;
            }
            return sw;
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
            if (txbIdDifunto.TextLength == 0)
            {
                Notificador.SetError(btnDifunto, "Seleccione una persona.");
                Validado = false;
            }
            if (txbIdTestigo1.TextLength == 0)
            {
                Notificador.SetError(btnTestigo1, "Seleccione una persona.");
                Validado = false;
            }
            if (txbIdTestigo2.TextLength == 0)
            {
                Notificador.SetError(btnTestigo2, "Seleccione una persona.");
                Validado = false;
            }
            if (txtIdInformante.TextLength == 0)
            {
                Notificador.SetError(btnInformante, "Seleccione una persona.");
                Validado = false;
            }
            if (txtHora.TextLength == 0 || !txtHora.MaskCompleted)
            {
                Notificador.SetError(txtHora, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (!esHoraValida())
            {
                Notificador.SetError(txtHora, "Hora no válida.");
                Validado = false;
            }
            if (chbxAsistencia.Checked && txbIdProfesional.TextLength==0)
            {
                Notificador.SetError(btnProfesional, "Seleccione una persona.");
                Validado = false;
            }
            if (cbxRespaldoPda.Checked && pictureBox1.ImageLocation=="")
            {
                Notificador.SetError(pictureBox1, "Seleccione un imagen.");
                Validado = false;
            }

            return Validado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            CLS.PartidaDef oUsuario = new CLS.PartidaDef();


            oUsuario.NumPartida1 = txbNumPartida.Text;
            oUsuario.Libro1 = txbLibro.Text;
            oUsuario.Folio1 = txbFolio.Text;
            oUsuario.IdFallecido = txbIdDifunto.Text;
            oUsuario.IdInformante = txtIdInformante.Text;
            oUsuario.IdTestigo1 = txbIdTestigo1.Text;
            oUsuario.IdTestigo2 = txbIdTestigo2.Text;
            oUsuario.IdPadre = txtIdPadre.Text;
            oUsuario.IdMadre = txtIdMadre.Text;
            oUsuario.IdConyuge = txbIdConyuge.Text;
            oUsuario.IdProfesional = txbIdProfesional.Text;
            oUsuario.Lugar_fallecimiento1 = cbxMunicipios.SelectedValue.ToString();
            oUsuario.Causa_muerte1 = cbxCausas.SelectedValue.ToString();
            oUsuario.Fecha_fallecimiento1 = Convert.ToDateTime(dtpFecha.Value.ToString()).ToString("yyyy-MM-dd");
            oUsuario.Hora_fallecimiento1 = txtHora.Text;
            oUsuario.Fecha_fallecimiento_letras1 = CLS.Hora.fecha_letras(oUsuario.Fecha_fallecimiento1);
            oUsuario.Hora_fallecimiento_letras1 = CLS.Hora.hora_letras(txtHora.Text);
            oUsuario.Anio_insercion_letras1 = CLS.Conv.enletras(DateTime.Today.Year.ToString());
            oUsuario.Fecha_insercion_letras1 = CLS.Hora.fecha_letras(DateTime.Today.ToString("yyyy-MM-dd"));
            oUsuario.Libro_letras1 = CLS.Conv.enletras(txbLibro.Text);
            oUsuario.Folio_letras1 = CLS.Conv.enletras(txbFolio.Text);
            oUsuario.NumPartida_letras1 = CLS.Conv.enletras(txbNumPartida.Text);


            if (ValidarDatos())
            {
                if (chbxAsistencia.Checked)
                {
                    oUsuario.Asistencia_medica1 = "Si";
                }
                else
                {
                    oUsuario.Asistencia_medica1 = "No";
                }
                if (cbxRespaldoPda.Checked)
                {
                    oUsuario.Imagen1 = obtenerRuta(pictureBox1.ImageLocation);
                }else
                {
                    oUsuario.Imagen1 = "";
                }
                if (txbIdProfesional.TextLength == 0)
                {
                    oUsuario.IdProfesional = "null";
                }if (txbIdConyuge.TextLength == 0)
                {
                    oUsuario.IdConyuge = "null";
                }if (txtIdMadre.TextLength == 0)
                {
                    oUsuario.IdMadre = "null";
                }if (txtIdPadre.TextLength==0)
                {
                    oUsuario.IdPadre = "null";
                }
                {

                }
                if (!marginando)
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
                }else
                {

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            SeleccionImagen frm = new SeleccionImagen();
            frm.ShowDialog(this);
        }
    }
}

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

namespace GestionBasica.GUI.Matrimonio
{
    public partial class IngresarPartidaMat : Form, IPadre, IInformante, IInfante, IFuncionario,IImagen
    {
        public static Boolean marginando = false;
        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
        Int32 _revisado = 0;
        String ruta_imagen;
        public static string idpapaA= "";
        public static string idmapaA = "";
        public static string idpapaB = "";
        public static string idmapaB = "";
        public static string EF_Hombre, EF_Mujer;

        ErrorProvider Notificador = new ErrorProvider();
        BindingSource _Municipio = new BindingSource();
        BindingSource _Departamentos = new BindingSource();

        public IngresarPartidaMat()
        {
            InitializeComponent();
            CargarDepartamentos();
            CargarMunicipios();
            CargarRegimenesMatrimoniales();
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
        }

        //Esposo
        //padres
        public void cambiarIdPadre(String idPadre) { txtID_Esposo.Text = idPadre; }
        public void cambiarPadre(String Padre) { txtEsposo.Text = Padre; }

        //para esposa
        public void cambiarIdMadre(String idMadre) { txtIdEsposa.Text = idMadre; }
        public void cambiarMadre(String Madre) { txtEsposa.Text = Madre; }

        //TEstigo1
        public void cambiarIdInfante(String idInfante) { txt_IdInf1.Text = idInfante; }
        public void cambiarInfante(String infante) { txtInformante1.Text = infante; }

        //para testigo 2
        public void cambiarIdInformantes(String idInformante) { txtIdInfo2.Text = idInformante; }
        public void cambiarInformantes(String Informante) { txtInformante2.Text = Informante; }

        //funcuinario
        public void cambiarIdFuncionario(string idFuncionario) { txtIDFuncionario.Text = idFuncionario; }
        public void cambiarfuncionario(string funcionario) { txtFuncionario.Text = funcionario; }

        //imagen
        public void cambiarImagen(String ruta) { pictureBox1.ImageLocation = ruta; }

        private void MarginarPartidaMat()
        {
            CLS.Marginacion mar = new CLS.Marginacion();
            mar.Explicacion = "El señor " + txtEsposo.Text + " se casó con " + txtEsposa.Text + " el día " + dtpFecha.Value.ToString()+" en "+cbxMunicipio.Text;

            mar.Marginar_por_Divorcio1(txtID_Esposo.Text);

            CLS.Marginacion marg = new CLS.Marginacion();
            marg.Explicacion = "La señora " + txtEsposa.Text + " se casó con " + txtEsposo.Text + " el día " + dtpFecha.Value.ToString() + " en " + cbxMunicipio.Text;

            marg.Marginar_por_Divorcio2(txtIdEsposa.Text);
        }

        private void IngresarPartidaMat_Load(object sender, EventArgs e)
        {
            

        }

        private void CargarRegimenesMatrimoniales()
        {
            DataRow fila;
            DataTable tipos = new DataTable();
            tipos.Columns.Add("Tipo");
            tipos.Columns.Add("Valor");

            fila = tipos.NewRow();
            fila["Tipo"] = "Separación de Bienes";
            fila["Valor"] = "1";
            tipos.Rows.Add(fila);

            fila = tipos.NewRow();
            fila["Tipo"] = "Partición de Ganancias";
            fila["Valor"] = "2";
            tipos.Rows.Add(fila);

            fila = tipos.NewRow();
            fila["Tipo"] = "Comunidad Diferida";
            fila["Valor"] = "3";
            tipos.Rows.Add(fila);

            cbxRegimenPatrimonial.DataSource = tipos;
            cbxRegimenPatrimonial.ValueMember = "Valor";
            cbxRegimenPatrimonial.DisplayMember = "Tipo";

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

        private void CargarMunicipios()
        {
            DataView dv = new DataView(CacheManager1.Cache.TODOS_LOS_MUNICIPIOS());
            dv.RowFilter = "idDepartamento = " + (cbxDepartamentos.SelectedIndex + 1);
            cbxMunicipio.DataSource = dv.ToTable();
            cbxMunicipio.DisplayMember = "municipio";
            cbxMunicipio.ValueMember = "idMunicipio";
        }

        private void Procesar()
        {
            CLS.Partidas_Matrimonio oPdaMatrimonio = new CLS.Partidas_Matrimonio();

            oPdaMatrimonio.Idpartida_matrimonio = txtID_Partida_cod.Text;
            oPdaMatrimonio.Folio = txbFolio.Text;
            oPdaMatrimonio.NumPartida1 = txbNumPartida.Text;

            oPdaMatrimonio.IdEsposo = txtID_Esposo.Text;
            oPdaMatrimonio.IdEsposa = txtIdEsposa.Text;
            oPdaMatrimonio.IdTestigo = txt_IdInf1.Text;
            oPdaMatrimonio.IdTestigo2 = txtIdInfo2.Text;
            oPdaMatrimonio.IdFuncionario = txtIDFuncionario.Text;

            oPdaMatrimonio.IdPadre_esposo = idpapaA;
            oPdaMatrimonio.IdMadre_esposo = idmapaA;
            oPdaMatrimonio.IdPadre_esposa = idpapaB;
            oPdaMatrimonio.IdMadre_esposa = idmapaB;

            oPdaMatrimonio.Lugar_matrimonio1 = cbxMunicipio.Text;
            oPdaMatrimonio.Fecha_matrimonio1 = Convert.ToDateTime(dtpFecha.Value.ToString()).ToString("yyyy-MM-dd");
            oPdaMatrimonio.Apellido_elegido1 = txtApellidoCasada.Text;
            oPdaMatrimonio.Regimen_patrimonial1 = cbxRegimenPatrimonial.Text;
            oPdaMatrimonio.Folio_letras = CLS.Conv.enletras(txbFolio.Text);

            oPdaMatrimonio.Fecha_matrimonio_letra1 = CLS.Hora.fecha_letras(oPdaMatrimonio.Fecha_matrimonio1);
            oPdaMatrimonio.Fecha_insercion1 = DateTime.Today.ToString("yyyy-MM-dd");
            oPdaMatrimonio.Hora_insercion1 = txtHora.Text;
            oPdaMatrimonio.Hora_insercion_letra1 = CLS.Hora.hora_letras(oPdaMatrimonio.Hora_insercion1);

            oPdaMatrimonio.Imagen1 = obtenerRuta(pictureBox1.ImageLocation);
            oPdaMatrimonio.Detalle_hijos = Detalle_Hijos.detalle_hijosfrm;
            oPdaMatrimonio.Hora_inse_entero1 = CLS.Conv.enletras( DateTime.Now.Hour.ToString());
            oPdaMatrimonio.Anio_insercion_letras = CLS.Conv.enletras(DateTime.Today.Year.ToString());

            /*
            oPdaMatrimonio.Anio_insercion_letras = CLS.Conv.enletras(DateTime.Today.Year.ToString());
            oPdaMatrimonio.Fecha_insercion_letra1 = CLS.Hora.fecha_letras(DateTime.Now.TimeOfDay.ToString("yyyy-MM-dd"));
            oPdaMatrimonio.Hora_insercion1 = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            */
            CLS.Movimiento movi = new CLS.Movimiento();
            movi.IdUsuario = _SESION.IdUsuario;

            if (ValidarDatos())
                    {
                    if (chbxRevisado.Checked)
                    {
                        _revisado = 1;
                    }
                    else {
                        _revisado = 0;
                    }
                        if (txtID_Partida_cod.TextLength > 0)
                        {
                            //Actualizando
                            try
                            {
                                if (oPdaMatrimonio.Actualizar(_revisado))                        
                                {
                            movi.Accion = "El usuario " + _SESION.Usuario + " modificó la partida de matrimonio con número " + txbNumPartida.Text;
                            
                            movi.Guardar();
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
                                if (oPdaMatrimonio.Insertar(_revisado))
                                {
                                    MarginarPartidaMat();
                            movi.Accion = "El usuario " + _SESION.Usuario + " registró una nueva partida de matrimonio con número " + txbNumPartida.Text;
                            movi.Guardar();
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

        private void Operaciones()
        {
            CLS.Operaciones oUsuario = new CLS.Operaciones();
            try
            {
                if (oUsuario.Guardar(3))
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

        private void IDPadresHombre()
        {
            DataTable _Datos = new DataTable();
            _Datos = CacheManager1.Cache.ID_Papas_Conyuges(txtID_Esposo.Text);
            idmapaA = "23";
            idpapaA = "23";
            foreach (DataRow row in _Datos.Rows)
            {
               
                idmapaA = row[1].ToString();
                idpapaA = row[0].ToString();

            }

        }

        private void IDPadresMujer()
        {
            DataTable _Datos = new DataTable();
            _Datos = CacheManager1.Cache.ID_Papas_Conyuges(txtIdEsposa.Text);
            idmapaB = "23";
            idpapaB = "23";
            foreach (DataRow row in _Datos.Rows)
            {
                idmapaB = row[1].ToString();
                idpapaB = row[0].ToString();
            }

        }

        private void EstadoFam_Hombre()
        {
            DataTable _Datos = new DataTable();
            _Datos = CacheManager1.Cache.EstadoFamiliar_Conyugue(txtID_Esposo.Text);

            foreach (DataRow row in _Datos.Rows)
            {
                EF_Hombre = row[0].ToString();
            }
        }

        private void EstadoFam_Mujer()
        {
            DataTable _Datos = new DataTable();
            _Datos = CacheManager1.Cache.EstadoFamiliar_Conyugue(txtIdEsposa.Text);

            foreach (DataRow row in _Datos.Rows)
            {
                EF_Mujer = row[0].ToString();
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
            if (txbNumPartida.TextLength == 0 )
            {
                Notificador.SetError(txbNumPartida, "Este campo no puede quedar vacío.");
                Validado = false;
            }

            if (txtEsposo.TextLength == 0)
            {
                Notificador.SetError(button1, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txtEsposa.TextLength == 0)
            {
                Notificador.SetError(button2, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txtInformante1.TextLength == 0)
            {
                Notificador.SetError(button3, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txtInformante2.TextLength == 0)
            {
                Notificador.SetError(button4, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txtFuncionario.TextLength == 0)
            {
                Notificador.SetError(button7, "Este campo no puede quedar vacío.");
                Validado = false;
            }

            if (txtApellidoCasada.TextLength == 0)
            {
                Notificador.SetError(txtApellidoCasada, "Este campo no puede quedar vacío.");
                Validado = false;
            }

            if (!esHoraValida())
            {
                Notificador.SetError(txtHora, "Hora no válida.");
                Validado = false;
            }

            if ((EF_Hombre == "Casado/a" || EF_Mujer=="Casado/a")&&txtID_Partida_cod.TextLength<0)
            {
                MessageBox.Show("El estado Familiar del conyugue es: Casado/a", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Validado = false;
            }
            if(cbxRespaldoPda.Checked && pictureBox1.ImageLocation == "") {
                Notificador.SetError(pictureBox1, "Seleccione una imagen.");
                Validado = false;
            }
            if (chbxRevisado.Checked && pictureBox1.ImageLocation == "")
            {
                pictureBox1.Visible = true;
                cbxRespaldoPda.Checked = true;
                Notificador.SetError(pictureBox1, "Seleccione una imagen.");
                Validado = false;
            }

            return Validado;
        }

        //botones de seleciion de sujeto 
        private void button7_Click(object sender, EventArgs e)
        {
            if (txtIDFuncionario.TextLength > 0)
            {
                GestionFuncionarios frm = new GestionFuncionarios();
                frm.IdFuncionario11 = txtIDFuncionario.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionFuncionarios frm = new GestionFuncionarios();
                frm.ShowDialog(this);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIdInfo2.TextLength > 0)
            {
                GestionTestigos frm = new GestionTestigos();
                frm.IdInfante1 = txtIdInfo2.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionTestigos frm = new GestionTestigos();
                frm.ShowDialog(this);
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_IdInf1.TextLength > 0)
            {
                GestionInformantes frm = new GestionInformantes();
                frm.IdInformante1 = txt_IdInf1.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionInformantes frm = new GestionInformantes();
                frm.ShowDialog(this);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID_Esposo.TextLength > 0)
            {
                GestionPadres frm = new GestionPadres();
                frm.IdPadre1 = txtID_Esposo.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionPadres frm = new GestionPadres();
                frm.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Madres
            if (txtIdEsposa.TextLength > 0)
            {
                GestionMadres frm = new GestionMadres();
                frm.IdMadre = txtIdEsposa.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionMadres frm = new GestionMadres();
                frm.ShowDialog(this);
            }
        }


        //cerrar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //eventos
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

        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartamentos.Items.Count > 0)
            {
                CargarMunicipios();
            }
        }

        //validaciones
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

        //no tienen nada
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void txbFolio_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e){      }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbxMunicipio_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtID_Esposo_TextChanged(object sender, EventArgs e)
        {
            IDPadresHombre();
            EstadoFam_Hombre();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
            Operaciones();

        }

        private void txtIdEsposa_TextChanged(object sender, EventArgs e)
        {
            IDPadresMujer();
            EstadoFam_Mujer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            GUI.Matrimonio.Detalle_Hijos frm = new Detalle_Hijos();
            frm.Show();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Haga doble clic para seleccionar una imagen");
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            SeleccionImagen frm = new SeleccionImagen();
            frm.ShowDialog(this);
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using GestionBasica.CLS;

namespace GestionBasica.GUI
{
    public partial class InfanteEdicion : Form
    {
        public static Boolean marginando = false;
        Int32 _revisado = 0;
        BindingSource _Municipio = new BindingSource();
        BindingSource _Departamentos = new BindingSource();

        public InfanteEdicion()
        {
            InitializeComponent();            
            CargarDepartamentos();
            CargarMunicipios();
            //List<TextBox> tList = new List<TextBox>();
            //List<string> sList = new List<string>();
            //tList.Add(txtHora);
            //sList.Add("p. ej. ocho horas veinte minutos del dia diez de enero de dos mil diesiocho");
            //SetCueBanner(ref tList, sList);
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

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        //private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        //void SetCueBanner(ref List<TextBox> textbox, List<string> CueText)
        //{
        //    for (int x = 0; x < textbox.Count; x++)
        //    {
        //        SendMessage(textbox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
        //    }
        //}

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            CLS.Infante oUsuario = new CLS.Infante();

            oUsuario.IdInfante = txbIdInfante.Text;
            oUsuario.Hora1 = txtHora.Text;
            oUsuario.NombreCompleto1 = txtNombreCompleto.Text;
            oUsuario.LugarNac1 = cbxMunicipio.SelectedValue.ToString();
            oUsuario.FechaNac1 = Convert.ToDateTime(dtpFecha.Value.ToString()).ToString("yyyy-MM-dd");
            oUsuario.Hora_letras1 = Hora.hora_letras(txtHora.Text);
            oUsuario.FechaNac_letras1 = Hora.fecha_letras(oUsuario.FechaNac1);

            if (ValidarDatos())
            {
                if (rbtnFemenino.Checked)
                {
                    oUsuario.Sexo1 = "Femenino";
                }
                else
                {
                    oUsuario.Sexo1 = "Masculino";
                }
                if(chbxRevisado.Checked){
                    _revisado = 1;
                }
                if (txbIdInfante.TextLength > 0)
                {
                    //Actualizando
                    try
                    {
                        if (oUsuario.Actualizar(_revisado))
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
                    }
                }
                else
                {
                    //Insertando
                    try
                    {
                        if (oUsuario.Insertar(_revisado))
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
            if (txtNombreCompleto.TextLength == 0)
            {
                Notificador.SetError(txtNombreCompleto, "Este campo no puede quedar vacío.");
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
            if (!rbtnFemenino.Checked && !rbtnMasculino.Checked)
            {
                Notificador.SetError(rbtnFemenino, "Seleccione un género.");
                Validado = false;
            }

            return Validado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InfanteEdicion_Load(object sender, EventArgs e)
        {
            if (marginando)
            {
                txtNombreCompleto.ReadOnly = false;
            }
        }

        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                Notificador.SetError(txtNombreCompleto, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                e.KeyChar.ToString().ToUpper();
                Notificador.Clear();
            }
        }

        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartamentos.Items.Count > 0)
            {
                CargarMunicipios();
            }
        }

        private void txtNombreCompleto_Leave(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text.Length > 0)
            {
                txtNombreCompleto.Text = txtNombreCompleto.Text.ToUpper();
            }
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
    }
}

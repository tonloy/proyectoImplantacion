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
    public partial class PadreEdicion : Form {

        BindingSource _Municipio = new BindingSource();
        BindingSource _Departamentos = new BindingSource();
        BindingSource _Profesiones = new BindingSource();
        BindingSource _Nacionalidades = new BindingSource();
        BindingSource _Parentesco = new BindingSource();
        public PadreEdicion()
        {
            InitializeComponent();            
            CargarDepartamentos();
            CargarMunicipios();
            CargarProfesiones();
            CargarPaises();
            CargarParentescos();
        }
        private void CargarParentescos()
        {
            try
            {
                _Parentesco.DataSource = CacheManager1.Cache.TODOS_LOS_PARENTESCOS();
                cbxParentesco.DataSource = null;
                cbxParentesco.DataSource = _Parentesco;
                cbxParentesco.DisplayMember = "Parentesco";
                cbxParentesco.ValueMember = "idParentesco";
                cbxParentesco.Text = "Seleccione un parentesco";
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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

        private void CargarProfesiones()
        {
            try
            {
                _Profesiones.DataSource = CacheManager1.Cache.TODOS_LOS_PROFESIONES();
                cbxProfesiones.DataSource = null;
                cbxProfesiones.DataSource = _Profesiones;
                cbxProfesiones.DisplayMember = "Profesion";
                cbxProfesiones.ValueMember = "idProfesion";
                cbxProfesiones.Text = "Elija una profesión";
            }
            catch
            {

            }
        }
        private void CargarPaises()
        {
            try
            {
                _Nacionalidades.DataSource = CacheManager1.Cache.TODOS_LOS_PAISES();
                cbxPaises.DataSource = null;
                cbxPaises.DataSource = _Nacionalidades;
                cbxPaises.DisplayMember = "Nacionalidad";
                cbxPaises.ValueMember = "idPais";
                cbxPaises.Text = "Elija una nacionalidad";
            }
            catch
            {

            }
        }

        private void Procesar()
        {
            CLS.Padres oPadre = new CLS.Padres();

            oPadre.IdPadre = txtID.Text;
            oPadre.NombreCompleto1 = txbNombreCompleto.Text;
            oPadre.ConocidoPor1 = txtConocidapor.Text;
            oPadre.Edad1 = mskTEdad.Text;
            oPadre.IdMunicipio = cbxMunicipio.SelectedValue.ToString();
            oPadre.Domicilio1 = txtDomicilio.Text;
            oPadre.Profesion1 = cbxProfesiones.SelectedValue.ToString();
            oPadre.Nacionalidad1 = cbxPaises.SelectedValue.ToString();
            oPadre.DUI1 = mtxtDUI.Text;
            oPadre.Parentesco1 = cbxParentesco.SelectedValue.ToString();
            oPadre.Observaciones1 = txtObservaciones.Text;
            oPadre.Rubrica1 = txtRubrica.Text;
            if (mskTEdad.MaskCompleted) {
                oPadre.Edad_letras1 = CLS.Conv.enletras(mskTEdad.Text); }
            oPadre.NumPartida1 = txtNumPartida.Text;
            if (txtNumPartida.MaskCompleted) { 
            oPadre.NumPartidaLetras1 = CLS.Nit.nit_letras(txtNumPartida.Text); }
            if (mtxtDUI.MaskCompleted)
            {
                oPadre.DUI_letras1 = CLS.Dui.dui_letras(mtxtDUI.Text);
            }

            if (ValidarDatos())
            {

                if (txtID.TextLength > 0)
                {
                    //Actualizando
                    try
                    {
                        if (oPadre.Actualizar())
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
                        if (oPadre.Insertar())
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
            if (txbNombreCompleto.TextLength == 0)
            {
                Notificador.SetError(txbNombreCompleto, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (txtConocidapor.TextLength == 0)
            {
                Notificador.SetError(txtConocidapor, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (txtRubrica.TextLength == 0)
            {
                Notificador.SetError(txtRubrica, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (mskTEdad.TextLength == 0 || !mskTEdad.MaskCompleted)
            {
                Notificador.SetError(mskTEdad, "Este campo no puede ir vacio o incompleto.");
                Validado = false;
            }

            if (cbxMunicipio.SelectedItem == null)
            {
                Notificador.SetError(cbxMunicipio, "Seleccione un rol de la lista.");
                Validado = false;
            }

            if (txtDomicilio.TextLength == 0)
            {
                Notificador.SetError(txtDomicilio, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (txtObservaciones.TextLength == 0)
            {
                Notificador.SetError(txtObservaciones, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (cbxProfesiones.SelectedItem == null)
            {
                Notificador.SetError(cbxProfesiones, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (cbxPaises.SelectedItem == null)
            {
                Notificador.SetError(cbxPaises, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (cbxDepartamentos.SelectedItem == null)
            {
                Notificador.SetError(cbxDepartamentos, "Seleccione un departamento de la lista.");
                Validado = false;
            }

            if (cbxParentesco.SelectedItem == null)
            {
                Notificador.SetError(cbxParentesco, "Seleccione un parentesco de la lista.");
                Validado = false;
            }

            if (chbxMenor.Checked)
            {
                if (txtNumPartida.TextLength == 0 || !txtNumPartida.MaskCompleted)
                {
                    Notificador.SetError(txtNumPartida, "Este campo no puede ir vacio o incompleto.");
                    Validado = false;
                }

            }
            else
            {
                if (mtxtDUI.TextLength == 0 || !mtxtDUI.MaskCompleted)
                {
                    Notificador.SetError(mtxtDUI, "Este campo no puede ir vacio o incompleto.");
                    Validado = false;
                }
            }


            return Validado;
        }

        private void CargarMunicipios()
        {
            DataView dv = new DataView(CacheManager1.Cache.TODOS_LOS_MUNICIPIOS());
            dv.RowFilter = "idDepartamento = " + (cbxDepartamentos.SelectedIndex + 1);
            cbxMunicipio.DataSource = dv.ToTable();
            cbxMunicipio.DisplayMember = "municipio";
            cbxMunicipio.ValueMember = "idMunicipio";
        }


        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartamentos.Items.Count > 0)
            {
                CargarMunicipios();
            }
            
        }

        private void PadreEdicion_Load(object sender, EventArgs e)
        {

        }

        private void txbNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                Notificador.SetError(txbNombreCompleto, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txtConocidapor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                Notificador.SetError(txtConocidapor, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txtProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txbNombreCompleto_Leave(object sender, EventArgs e)
        {
            if (txbNombreCompleto.Text.Length > 0)
            {
                txbNombreCompleto.Text = txbNombreCompleto.Text.ToUpper();
            }
        }

        private void txtConocidapor_Leave(object sender, EventArgs e)
        {
            if (txtConocidapor.Text.Length > 0)
            {
                txtConocidapor.Text = txtConocidapor.Text.ToUpper();
            }
        }

        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            if (txtDomicilio.Text.Length > 0)
            {
                txtDomicilio.Text = txtDomicilio.Text.ToUpper();
            }
        }

        private void chbxMenor_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbxMenor.Checked)
            {
                mtxtDUI.Enabled = false;
                txtNumPartida.Enabled = true;
            }
            else
            {
                mtxtDUI.Enabled = true;
                txtNumPartida.Enabled = false;
            }
        }

    }
}

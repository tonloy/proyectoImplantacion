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

        public PadreEdicion()
        {
            InitializeComponent();
            CargarMunicipios();
            CargarDepartamentos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void CargarMunicipios()
        {
            try
            {
                _Municipio.DataSource = CacheManager1.Cache.TODOS_LOS_MUNICIPIOS();
                cbxMunicipio.DataSource = null;
                cbxMunicipio.DataSource = _Municipio;
                cbxMunicipio.DisplayMember = "Municipio";
                cbxMunicipio.ValueMember = "idMunicipio";
                cbxMunicipio.Text = "Elija un Municipio";
            }
            catch
            {

            }
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
       


        private void Procesar()
        {
            CLS.Padres oPadre = new CLS.Padres();

            oPadre.IdPadre = txtID.Text;
            oPadre.NombreCompleto1 = txbNombreCompleto.Text;
            oPadre.ConocidoPor1 = txtConocidapor.Text;
            oPadre.Edad1 = mskTEdad.Text;
            oPadre.IdMunicipio = cbxMunicipio.SelectedValue.ToString();
            oPadre.Domicilio1 = txtDomicilio.Text;
            oPadre.Profesion1 = txtProfesion.Text;
            oPadre.Nacionalidad1 = txtNacionalidad.Text;
            oPadre.DUI1 = mtxtDUI.Text;


            if (ValidarDatos())
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

            if (txtProfesion.TextLength == 0)
            {
                Notificador.SetError(txtProfesion, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (txtNacionalidad.TextLength == 0)
            {
                Notificador.SetError(txtNacionalidad, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (mtxtDUI.TextLength == 0 || !mtxtDUI.MaskCompleted)
            {
                Notificador.SetError(mtxtDUI, "Este campo no puede ir vacio o incompleto.");
                Validado = false;
            }

            if (cbxDepartamentos.SelectedItem == null)
            {
                Notificador.SetError(cbxDepartamentos, "Seleccione un departamento de la lista.");
                Validado = false;
            }

            return Validado;
        }

    }
}

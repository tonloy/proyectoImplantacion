﻿using System;
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
    public partial class MadreEdicion : Form
    {
        BindingSource _Municipio = new BindingSource();
        BindingSource _Departamentos = new BindingSource();
        public MadreEdicion()
        {
            InitializeComponent();
            CargarMunicipios();
            CargarDepartamentos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void MadreEdicion_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void button3_Click_1(object sender, EventArgs e)
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
        private void CargarMunicipios()
        {
            DataView dv = new DataView(CacheManager1.Cache.TODOS_LOS_MUNICIPIOS());
            dv.RowFilter = "idDepartamento = " + (cbxDepartamentos.SelectedIndex + 1);
            cbxMunicipio.DataSource = dv.ToTable();
            cbxMunicipio.DisplayMember = "municipio";
            cbxMunicipio.ValueMember = "idMunicipio";
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

        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartamentos.Items.Count > 0)
            {
                CargarMunicipios();
            }
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
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                Notificador.SetError(txtProfesion, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                Notificador.SetError(txtNacionalidad, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txbNombreCompleto_Leave(object sender, EventArgs e)
        {
            if (txbNombreCompleto.TextLength > 0)
            {
                txbNombreCompleto.Text = txbNombreCompleto.Text.ToUpper();
            }
        }

        private void txtConocidapor_Leave(object sender, EventArgs e)
        {
            if (txtConocidapor.TextLength > 0)
            {
                txtConocidapor.Text = txtConocidapor.Text.ToUpper();
            }
        }

        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            if (txtDomicilio.TextLength > 0)
            {
                txtDomicilio.Text = txtDomicilio.Text.ToUpper();
            }
        }
    }
}

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
    public partial class InformanteEdicion : Form
    {
        BindingSource _Parentesco = new BindingSource();
        public InformanteEdicion()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void InformanteEdicion_Load(object sender, EventArgs e)
        {

        }
        private void Procesar()
        {
            CLS.Informante oUsuario = new CLS.Informante();

            oUsuario.IdInformante = txbIdInformante.Text;
            oUsuario.NombreCompleto1 = txtNombreCompleto.Text;
            oUsuario.Observaciones1 = txtObservaciones.Text;
            oUsuario.IdParentesco = cbxParentesco.SelectedValue.ToString();
            oUsuario.ConocidoPor1 = txtConocidapor.Text;
            oUsuario.DUI1 = mtxtDUI.Text;
            oUsuario.Profesion = txtProfesionUoficio.Text;

            if (ValidarDatos())
            {

                if (txbIdInformante.TextLength > 0)
                {
                    //Actualizando
                    try
                    {
                        if (oUsuario.Actualizar())
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
                        if (oUsuario.Insertar())
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
                Notificador.SetError(txtNombreCompleto, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (txtProfesionUoficio.TextLength == 0)
            {
                Notificador.SetError(txtProfesionUoficio, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (txtObservaciones.TextLength == 0)
            {
                Notificador.SetError(txtObservaciones, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (txtConocidapor.TextLength == 0)
            {
                Notificador.SetError(txtConocidapor, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (mtxtDUI.TextLength == 0 || !mtxtDUI.MaskCompleted)
            {
                Notificador.SetError(mtxtDUI, "Este campo no puede ir vacio o incompleto.");
                Validado = false;
            }
            if (cbxParentesco.SelectedItem == null)
            {
                Notificador.SetError(cbxParentesco, "Seleccione un rol de la lista.");
                Validado = false;
            }

            return Validado;
        }
    }

}
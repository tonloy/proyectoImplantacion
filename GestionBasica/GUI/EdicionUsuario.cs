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
    public partial class EdicionUsuario : Form
    {
        BindingSource _Roles = new BindingSource();
        BindingSource _Empleados = new BindingSource();
        public EdicionUsuario()
        {
            InitializeComponent();
            CargarEmpleados();
            CargarRoles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            CambiarPassword frm = new CambiarPassword();
            frm.txbIdUsuario.Text = this.txbIdUsuario.Text;
            frm.ShowDialog();
        }

        private void CargarEmpleados()
        {
            try
            {
                _Empleados.DataSource = CacheManager1.Cache.TODOS_LOS_EMPLEADOS();
                cbxEmpleados.DataSource = null;
                cbxEmpleados.DataSource = _Empleados;
                cbxEmpleados.DisplayMember = "NombreCompleto";
                cbxEmpleados.ValueMember = "idEmpleado";
                cbxEmpleados.Text = "Seleccione un empleado";
            }
            catch
            {

            }
        }

        private void EdicionUsuario_Load(object sender, EventArgs e)
        {
            if (txbIdUsuario.TextLength == 0)
            {
                btnCambiarPass.Visible = false;
            }
            else
            {
                txbCredencial.ReadOnly = true;
            }
        }

        private void CargarRoles()
        {
            try
            {
                _Roles.DataSource = CacheManager1.Cache.TODOS_LOS_ROLES();
                cbxRoles.DataSource = null;
                cbxRoles.DataSource = _Roles;
                cbxRoles.DisplayMember = "Rol";
                cbxRoles.ValueMember = "idRol";
                cbxRoles.Text = "Seleccione un rol";
            }
            catch
            {

            }
        }

        private void chkMostrar_CheckStateChanged(object sender, EventArgs e)
        {
            String pass = txbCredencial.Text;
            if (chkMostrar.Checked == true)
            {
                txbCredencial.UseSystemPasswordChar = false;
                txbCredencial.Text = pass;
            }
            else
            {
                txbCredencial.UseSystemPasswordChar = true;
                txbCredencial.Text = pass;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private Boolean ValidarDatos()
        {
            Boolean Validado = true;
            Notificador.Clear();
            if (txbUsuario.TextLength == 0)
            {
                Notificador.SetError(txbUsuario, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (txbCredencial.TextLength == 0)
            {
                Notificador.SetError(txbCredencial, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (cbxRoles.SelectedItem == null)
            {
                Notificador.SetError(cbxRoles, "Seleccione un rol de la lista.");
                Validado = false;
            }
            if (cbxEmpleados.SelectedItem == null)
            {
                Notificador.SetError(cbxEmpleados, "Seleccione un empleado de la lista.");
                Validado = false;
            }

            return Validado;
        }

        private void Procesar()
        {
            CLS.Usuario oUsuario = new CLS.Usuario();

            oUsuario.IdUsuario = txbIdUsuario.Text;
            oUsuario.Usuario1 = txbUsuario.Text;
            oUsuario.Credencial = txbCredencial.Text;
            oUsuario.IDEmpleado = cbxEmpleados.SelectedValue.ToString();
            oUsuario.IDRol = cbxRoles.SelectedValue.ToString();

            if (ValidarDatos())
            {

                if (txbIdUsuario.TextLength > 0)
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
        }
    }
}

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
    public partial class CambiarPassword : Form
    {
        public CambiarPassword()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void chkMostrar_CheckStateChanged(object sender, EventArgs e)
        {
            String pass = txbPassword.Text;
            String pass1 = txbConfirmar.Text;
            if (chkMostrar.Checked == true)
            {
                txbPassword.UseSystemPasswordChar = false;
                txbConfirmar.UseSystemPasswordChar = false;
                txbPassword.Text = pass;
                txbConfirmar.Text = pass1;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
                txbConfirmar.UseSystemPasswordChar = true;
                txbPassword.Text = pass;
                txbConfirmar.Text = pass1;
            }
        }

        private Boolean ValidarDatos()
        {
            Boolean Validado = true;
            Notificador.Clear();
            if (txbPassword.TextLength == 0)
            {
                Notificador.SetError(txbPassword, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (txbConfirmar.TextLength == 0)
            {
                Notificador.SetError(txbConfirmar, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (txbConfirmar.Text != txbPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Validado = false;
            }

            return Validado;
        }

        private void Procesar()
        {
            CLS.Usuario oUsuario = new CLS.Usuario();

            oUsuario.IdUsuario = txbIdUsuario.Text;
            oUsuario.Credencial = txbPassword.Text;

            if (ValidarDatos())
            {
                try
                {
                    if (oUsuario.ActualizarPassword())
                    {
                        MessageBox.Show("Contraseña actualizada correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("La contraseña no fue actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

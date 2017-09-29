using CacheManager1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Login : Form
    {
        Color miColor = Color.FromArgb(6,0,88);
        Boolean _Autorizado = false;

        public Boolean Autorizado
        {
            get { return _Autorizado; }
        }
        private void IniciarSesion()
        {
            DataTable Datos = new DataTable();
            Datos = Cache.DATOS_USUARIO(txbUsuario.Text, txbPassword.Text);
            if (Datos.Rows.Count == 1)
            {
                //El usuario existe
                SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
                _SESION.Usuario = Datos.Rows[0]["Usuario"].ToString();
                _SESION.IdUsuario = Datos.Rows[0]["idUsuario"].ToString();
                _SESION.IDEmpleado = Datos.Rows[0]["idEmpleado"].ToString();
                _SESION.Nombres = Datos.Rows[0]["NombreCompleto"].ToString();
                
                _SESION.IDGrupo = Datos.Rows[0]["idRol"].ToString();
                _SESION.Grupo = Datos.Rows[0]["Rol"].ToString();
                _Autorizado = true;
                Close();
            }
            else
            {
                //Usuario o contraseña erronea
                MessageBox.Show("Usuario / Contraseña erroneos", "Error en el inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _Autorizado = false;
                txbPassword.Focus();
                txbPassword.SelectAll();
            }
        }
        public Login()
        {
            InitializeComponent();
            pbxFranja.BackColor = miColor;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbPassword.Focus();
                txbPassword.SelectAll();
            }
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_Autorizado)
            {
                Application.Exit();
            }            
        }

        private void chkContrasena_CheckStateChanged(object sender, EventArgs e)
        {
            String pass = txbPassword.Text;
            if (chkContrasena.Checked == true)
            {
                txbPassword.UseSystemPasswordChar = false;
                txbPassword.Text = pass;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
                txbPassword.Text = pass;
            }
        }
    }
}

using CacheManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class Login : Form
    {
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
                //MessageBox.Show("Correcto");
                SesionManager.Sesion _SESION = SesionManager.Sesion.Instancia;
                _SESION.Usuario = Datos.Rows[0]["Usuario"].ToString();
                _SESION.IdUsuario = Datos.Rows[0]["idUsuario"].ToString();
                _SESION.IDEmpleado = Datos.Rows[0]["IDEmpleado"].ToString();
                _SESION.Nombres = Datos.Rows[0]["Nombres"].ToString();
                _SESION.Apellidos = Datos.Rows[0]["Apellidos"].ToString();
                _SESION.IDGrupo = Datos.Rows[0]["IDGrupo"].ToString();
                _SESION.Grupo = Datos.Rows[0]["Grupo"].ToString();
                _Autorizado = true;
                Close();
            }
            else
            {
                //Usuario o contraseña erronea
                MessageBox.Show("Usuario / Contraseña erroneos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _Autorizado = false;
                txbPassword.Focus();
                txbPassword.SelectAll();
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
    }
}

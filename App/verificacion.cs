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
    public partial class verificacion : Form
    {
        Boolean _Autorizado = false;
        SessionManager.Sesion _Sesion = SessionManager.Sesion.Instancia;
        int intentos=0;

        public bool Autorizado
        {
            get
            {
                return _Autorizado;
            }

            set
            {
                _Autorizado = value;
            }
        }

        public verificacion()
        {
            InitializeComponent();
        }

        private void verificacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (intentos == 3)
            {
                Close();
                Application.Exit();
            }
            else
            {
                DataTable Datos = new DataTable();
                Datos = CacheManager1.Cache.DATOS_USUARIO(_Sesion.Usuario, txbPassword.Text);
                if (Datos.Rows.Count == 1 && intentos < 3)
                {
                    Autorizado = true;
                    GestionBasica.Respaldar.RespaldarBase rBa = new GestionBasica.Respaldar.RespaldarBase();
                    rBa.ShowDialog();
                    intentos = 0;
                    Close();                    
                }
                else
                {
                    intentos++;
                    MessageBox.Show("Contraseña incorrecta. Tiene " + (3 - intentos) + " intentos más.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}

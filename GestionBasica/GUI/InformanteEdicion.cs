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
            if (txtConocidapor.TextLength == 0)
            {
                Notificador.SetError(txtConocidapor, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (mtxtDUI.TextLength == 0)
            {
                Notificador.SetError(mtxtDUI, "Seleccione un rol de la lista.");
                Validado = false;
            }
            if (cbxParentesco.SelectedItem == null)
            {
                Notificador.SetError(cbxParentesco, "Seleccione un empleado de la lista.");
                Validado = false;
            }

            return Validado;
        }
    }
}

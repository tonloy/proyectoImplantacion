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
    public partial class GestionPermisos : Form
    {
        BindingSource _Roles = new BindingSource();
        BindingSource _Permisos_d = new BindingSource();
        BindingSource _Permisos_a = new BindingSource();
        public GestionPermisos()
        {
            InitializeComponent();
            CargarRoles();
        }
        private void CargarPermisosDisponibles()
        {
            try
            {
                _Permisos_d.DataSource = CacheManager1.Cache.PERMISOS_DISPONIBLES(cbxRoles.SelectedValue.ToString());
                dtgPermisos_d.AutoGenerateColumns = false;
                dtgPermisos_d.DataSource = _Permisos_d;
            }
            catch
            {

            }
        }

        private void CargarPermisosOtorgados()
        {
            try
            {
                _Permisos_a.DataSource = CacheManager1.Cache.PERMISOS_OTORGADOS(cbxRoles.SelectedValue.ToString());
                dtgPermisos_o.AutoGenerateColumns = false;
                dtgPermisos_o.DataSource = _Permisos_a;
            }
            catch
            {

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

        private void GestionPermisos_Load(object sender, EventArgs e)
        {

        }

        private void cbxRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxRoles.SelectedValue.ToString() == "System.Data.DataRowView")
            {

            }
            else
            {
                CargarPermisosDisponibles();
                CargarPermisosOtorgados();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLS.Permiso oPermiso = new CLS.Permiso();

            try
            {
                oPermiso.IdOpcion = dtgPermisos_d.CurrentRow.Cells["idOpcion1"].Value.ToString();
                oPermiso.IdGrupo = cbxRoles.SelectedValue.ToString();

                if (oPermiso.Guardar())
                {
                    MessageBox.Show("Permiso otorgado correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPermisosOtorgados();
                    CargarPermisosDisponibles();
                }
                else
                {
                    MessageBox.Show("El permiso no fue otorgado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLS.Permiso oPermiso = new CLS.Permiso();
            try
            {
                oPermiso.IdOpcion = dtgPermisos_o.CurrentRow.Cells["idOpcion"].Value.ToString();
                oPermiso.IdGrupo = cbxRoles.SelectedValue.ToString();
                if (oPermiso.Eliminar())
                {
                    MessageBox.Show("Permiso eliminado correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPermisosOtorgados();
                    CargarPermisosDisponibles();
                }
                else
                {
                    MessageBox.Show("El permiso no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgPermisos_d_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void dtgPermisos_o_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }
    }
}

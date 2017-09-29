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
    public partial class GestionUsuarios : Form
    {
        BindingSource _USUARIOS = new BindingSource();
        public GestionUsuarios()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbNueva_Click(object sender, EventArgs e)
        {
            EdicionUsuario frm = new EdicionUsuario();
            frm.ShowDialog();
            CargarUsuarios();
        }

        private void txbModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea EDITAR el usuario seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    EdicionUsuario frm = new EdicionUsuario();
                    frm.txbIdUsuario.Text = dtgUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                    frm.txbUsuario.Text = dtgUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                    frm.txbCredencial.Text = dtgUsuarios.CurrentRow.Cells["Credencial"].Value.ToString();
                    frm.cbxEmpleados.SelectedIndex = frm.cbxEmpleados.FindStringExact(dtgUsuarios.CurrentRow.Cells["NombreCompleto"].Value.ToString());
                    frm.cbxRoles.SelectedIndex = frm.cbxRoles.FindStringExact(dtgUsuarios.CurrentRow.Cells["Rol"].Value.ToString());
                    frm.ShowDialog();
                    CargarUsuarios();
                }
                catch (System.ArgumentException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                _USUARIOS.DataSource = CacheManager1.Cache.TODOS_LOS_USUARIOS();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }

        private void FiltrarLocalmente()
        {
            if (txbFiltrar.TextLength == 0)
            {
                _USUARIOS.RemoveFilter();
            }
            else
            {
                _USUARIOS.Filter = "Usuario like '%" + txbFiltrar.Text + "%'";
            }
            dtgUsuarios.AutoGenerateColumns = false;
            dtgUsuarios.DataSource = _USUARIOS;
            lblNumeroFilas.Text = dtgUsuarios.Rows.Count.ToString() + " Registros Encontrados";
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ELIMINAR el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //Primer paso
                    CLS.Usuario oUsuario = new CLS.Usuario();
                    //Paso 2 pasar el id del usuario a eliminar
                    oUsuario.IdUsuario = dtgUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                    if (oUsuario.Eliminar())
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al intentar eliminar el usuario seleccionado.");
                    }
                    CargarUsuarios();
                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un usuario");
                }
            }
        }

        private void dtgUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }
    }
}

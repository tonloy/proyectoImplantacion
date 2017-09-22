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
    public partial class EdicionEmpleado : Form
    {
        BindingSource _CARGOS = new BindingSource();
        public EdicionEmpleado()
        {
            InitializeComponent();
            CargarCargos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EdicionEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void CargarCargos()
        {
            try
            {
                _CARGOS.DataSource = CacheManager1.Cache.TODOS_LOS_CARGOS();
                cbxCargos.DataSource = null;
                cbxCargos.DataSource = _CARGOS;
                cbxCargos.DisplayMember = "Cargo";
                cbxCargos.ValueMember = "idCargo";
                cbxCargos.Text = "Elija un grupo";
            }
            catch
            {

            }
        }

        private void Procesar()
        {
            CLS.Empleado oEmpleado = new CLS.Empleado();

            oEmpleado.IdEmpleado = txbIdEmpleado.Text;
            oEmpleado.NombreCompleto = txbNombreCompleto.Text;
            oEmpleado.IdCargo = cbxCargos.SelectedValue.ToString();

            if (ValidarDatos())
            {

                if (txbIdEmpleado.TextLength > 0)
                {
                    //Actualizando
                    try
                    {
                        if (oEmpleado.Modificar())
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
                        if (oEmpleado.Guardar())
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
            if (txbNombreCompleto.TextLength == 0)
            {
                Notificador.SetError(txbNombreCompleto, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            if (cbxCargos.SelectedItem == null)
            {
                Notificador.SetError(cbxCargos, "Seleccione un cargo de la lista.");
                Validado = false;
            }

            return Validado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }
    }
}

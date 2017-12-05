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
    public partial class EdicionJuzgado : Form
    {
        BindingSource _Municipio = new BindingSource();
        BindingSource _Departamentos = new BindingSource();
        public EdicionJuzgado()
        {
            InitializeComponent();
            CargarDepartamentos();
            CargarMunicipios();

        }

        private void CargarDepartamentos()
        {
            try
            {
                _Departamentos.DataSource = CacheManager1.Cache.TODOS_LOS_DEPARTAMENTOS();
                cbxDepartamentos.DataSource = null;
                cbxDepartamentos.DataSource = _Departamentos;
                cbxDepartamentos.DisplayMember = "Departamento";
                cbxDepartamentos.ValueMember = "idDepartamento";
                cbxDepartamentos.Text = "Elija un Departamento";
            }
            catch
            {

            }
        }
        private void CargarMunicipios()
        {
            DataView dv = new DataView(CacheManager1.Cache.TODOS_LOS_MUNICIPIOS());
            dv.RowFilter = "idDepartamento = " + (cbxDepartamentos.SelectedIndex + 1);
            cbxMunicipios.DataSource = dv.ToTable();
            cbxMunicipios.DisplayMember = "municipio";
            cbxMunicipios.ValueMember = "idMunicipio";
        }

        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartamentos.Items.Count > 0)
            {
                CargarMunicipios();
            }
        }

        private void txbNombreJuzgado_Leave(object sender, EventArgs e)
        {
            if (txbNombreJuzgado.Text.Length > 0)
            {
                txbNombreJuzgado.Text = txbNombreJuzgado.Text.ToUpper();
            }
        }

        private void txtDireccionJuzgado_Leave(object sender, EventArgs e)
        {
            if (txtDireccionJuzgado.Text.Length > 0)
            {
                txtDireccionJuzgado.Text = txtDireccionJuzgado.Text.ToUpper();
            }
        }


        private void Procesar()
        {
            CLS.Juzgados oJuzgado = new CLS.Juzgados();

            oJuzgado.IdJuzgados = txbIdCanton.Text;
            oJuzgado.Nombre1 = txbNombreJuzgado.Text;
            oJuzgado.Direccion1 = txtDireccionJuzgado.Text;
            oJuzgado.IdMunicipio = cbxMunicipios.SelectedValue.ToString();

            if (ValidarDatos())
            {

                if (txbIdCanton.TextLength > 0)
                {
                    //Actualizando
                    try
                    {
                        if (oJuzgado.Modificar())
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
                        if (oJuzgado.Guardar())
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
            if (txbNombreJuzgado.TextLength == 0)
            {
                Notificador.SetError(txbNombreJuzgado, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (txtDireccionJuzgado.TextLength == 0)
            {
                Notificador.SetError(txtDireccionJuzgado, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (cbxDepartamentos.SelectedItem == null)
            {
                Notificador.SetError(cbxDepartamentos, "Seleccione un departamento de la lista.");
                Validado = false;
            }
            if (cbxMunicipios.SelectedItem == null)
            {
                Notificador.SetError(cbxMunicipios, "Seleccione un municipio de la lista.");
                Validado = false;
            }

            return Validado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI.Defunciones
{
    public partial class DifuntoEdicion : Form
    {

        BindingSource _Municipio = new BindingSource();
        BindingSource _Departamentos = new BindingSource();
        BindingSource _Profesiones = new BindingSource();
        BindingSource _Nacionalidades = new BindingSource();
        Int32 _revisado = 0;
        private int cual = 0;

        public int Cual
        {
            get
            {
                return cual;
            }

            set
            {
                cual = value;
            }
        }

        public DifuntoEdicion()
        {
            InitializeComponent();
            CargarDepartamentos();
            CargarMunicipios();
            CargarProfesiones();
            CargarPaises();
            CargarEstadosFamiliares();
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

        private void CargarProfesiones()
        {
            try
            {
                _Profesiones.DataSource = CacheManager1.Cache.TODOS_LOS_PROFESIONES();
                cbxProfesiones.DataSource = null;
                cbxProfesiones.DataSource = _Profesiones;
                cbxProfesiones.DisplayMember = "Profesion";
                cbxProfesiones.ValueMember = "idProfesion";
                cbxProfesiones.Text = "Elija una profesión";
            }
            catch
            {

            }
        }
        private void CargarPaises()
        {
            try
            {
                _Nacionalidades.DataSource = CacheManager1.Cache.TODOS_LOS_PAISES();
                cbxPaises.DataSource = null;
                cbxPaises.DataSource = _Nacionalidades;
                cbxPaises.DisplayMember = "Nacionalidad";
                cbxPaises.ValueMember = "idPais";
                cbxPaises.Text = "Elija una nacionalidad";
            }
            catch
            {

            }
        }

        private void CargarMunicipios()
        {
            DataView dv = new DataView(CacheManager1.Cache.TODOS_LOS_MUNICIPIOS());
            dv.RowFilter = "idDepartamento = " + (cbxDepartamentos.SelectedIndex + 1);
            cbxMunicipio.DataSource = dv.ToTable();
            cbxMunicipio.DisplayMember = "municipio";
            cbxMunicipio.ValueMember = "idMunicipio";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartamentos.Items.Count > 0)
            {
                CargarMunicipios();
            }
        }

        private void txbNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                Notificador.SetError(txbNombreCompleto, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txtConocidapor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                Notificador.SetError(txtConocidapor, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txbNombreCompleto_Leave(object sender, EventArgs e)
        {
            if (txbNombreCompleto.Text.Length > 0)
            {
                txbNombreCompleto.Text = txbNombreCompleto.Text.ToUpper();
            }
        }

        private void txtConocidapor_Leave(object sender, EventArgs e)
        {
            if (txtConocidapor.Text.Length > 0)
            {
                txtConocidapor.Text = txtConocidapor.Text.ToUpper();
            }
        }

        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            if (txtDomicilio.Text.Length > 0)
            {
                txtDomicilio.Text = txtDomicilio.Text.ToUpper();
            }
        }

        private void mtxtDUI_Enter(object sender, EventArgs e)
        {
            mtxtDUI.ReadOnly = false;
            txtNumPartida.Clear();
            txtNumPartida.ReadOnly = true;
        }

        private void txtNumPartida_Enter(object sender, EventArgs e)
        {
            txtNumPartida.ReadOnly = false;
            mtxtDUI.Clear();
            mtxtDUI.ReadOnly = true;
        }

        private void Procesar()
        {
            CLS.Difunto oPadre = new CLS.Difunto();

            oPadre.IdPadre = txtID.Text;
            oPadre.NombreCompleto1 = txbNombreCompleto.Text;
            oPadre.ConocidoPor1 = txtConocidapor.Text;
            oPadre.Edad1 = mskTEdad.Text;
            oPadre.IdMunicipio = cbxMunicipio.SelectedValue.ToString();
            oPadre.Domicilio1 = txtDomicilio.Text;
            oPadre.Profesion1 = cbxProfesiones.SelectedValue.ToString();
            oPadre.Nacionalidad1 = cbxPaises.SelectedValue.ToString();
            oPadre.DUI1 = mtxtDUI.Text;
            
            if (mskTEdad.MaskCompleted)
            {
                oPadre.Edad_letras1 = CLS.Conv.enletras(mskTEdad.Text);
            }
            oPadre.NumPartida1 = txtNumPartida.Text;
            if (txtNumPartida.MaskCompleted)
            {
                oPadre.NumPartidaLetras1 = CLS.Nit.nit_letras(txtNumPartida.Text);
            }
            if (mtxtDUI.MaskCompleted)
            {
                oPadre.DUI_letras1 = CLS.Dui.dui_letras(mtxtDUI.Text);
            }

            if (ValidarDatos())
            {
                oPadre.Estado_familiar1 = cbxEstados.SelectedItem.ToString();
                if (rbtnFemenino.Checked)
                {
                    oPadre.Sexo1 = "Femenino";
                }
                else
                {
                    oPadre.Sexo1 = "Masculino";
                }
                if (checkBox1.Checked)
                {
                    _revisado = 1;
                }

                if (txtID.TextLength > 0)
                {
                    //Actualizando
                    try
                    {
                        if (oPadre.Actualizar(_revisado))
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
                        if (oPadre.Insertar(_revisado))
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

            if (txtConocidapor.TextLength == 0)
            {
                Notificador.SetError(txtConocidapor, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (mskTEdad.TextLength == 0 || !mskTEdad.MaskCompleted)
            {
                Notificador.SetError(mskTEdad, "Este campo no puede ir vacio o incompleto.");
                Validado = false;
            }

            if (cbxMunicipio.SelectedItem == null)
            {
                Notificador.SetError(cbxMunicipio, "Seleccione un municipio de la lista.");
                Validado = false;
            }
            if (cbxEstados.SelectedItem == null)
            {
                Notificador.SetError(cbxEstados, "Seleccione un estado de la lista.");
                Validado = false;
            }

            if (txtDomicilio.TextLength == 0)
            {
                Notificador.SetError(txtDomicilio, "Este campo no puede quedar vacio.");
                Validado = false;
            }
            

            if (cbxProfesiones.SelectedItem == null)
            {
                Notificador.SetError(cbxProfesiones, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (cbxPaises.SelectedItem == null)
            {
                Notificador.SetError(cbxPaises, "Este campo no puede quedar vacio.");
                Validado = false;
            }

            if (cbxDepartamentos.SelectedItem == null)
            {
                Notificador.SetError(cbxDepartamentos, "Seleccione un departamento de la lista.");
                Validado = false;
            }

            if (!txtNumPartida.ReadOnly)
            {
                if (txtNumPartida.TextLength == 0 || !txtNumPartida.MaskCompleted)
                {
                    Notificador.SetError(txtNumPartida, "Este campo no puede ir vacio o incompleto.");
                    Validado = false;
                }

            }
            else
            {
                if (mtxtDUI.TextLength == 0 || !mtxtDUI.MaskCompleted)
                {
                    Notificador.SetError(mtxtDUI, "Este campo no puede ir vacio o incompleto.");
                    Validado = false;
                }
            }


            return Validado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void DifuntoEdicion_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarEstadosFamiliares()
        {
            DataRow fila;
            DataTable tipos = new DataTable();
            tipos.Columns.Add("Tipo");
            tipos.Columns.Add("Valor");

            fila = tipos.NewRow();
            fila["Tipo"] = "Soltero/a";
            fila["Valor"] = "1";
            tipos.Rows.Add(fila);

            fila = tipos.NewRow();
            fila["Tipo"] = "Casado/a";
            fila["Valor"] = "2";
            tipos.Rows.Add(fila);

            fila = tipos.NewRow();
            fila["Tipo"] = "Divorciado/a";
            fila["Valor"] = "3";
            tipos.Rows.Add(fila);

            fila = tipos.NewRow();
            fila["Tipo"] = "Viudo/a";
            fila["Valor"] = "4";
            tipos.Rows.Add(fila);

            cbxEstados.DataSource = tipos;
            cbxEstados.ValueMember = "Valor";
            cbxEstados.DisplayMember = "Tipo";

        }
    }
}

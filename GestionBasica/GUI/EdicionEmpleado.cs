﻿using System;
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
        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
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
            oEmpleado.Rubricas = txtRubricas.Text;

            CLS.Movimiento insertar = new CLS.Movimiento();
            insertar.IdUsuario = _SESION.IdUsuario;

            if (ValidarDatos())
            {

                if (txbIdEmpleado.TextLength > 0)
                {
                    //Actualizando
                    try
                    {
                        if (oEmpleado.Modificar())
                        {
                            insertar.Accion = "El usuario " + _SESION.Usuario + " modifico el empleado con ID " + oEmpleado.IdEmpleado;
                            insertar.Guardar(); 
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
                            insertar.Accion = "El usuario " + _SESION.Usuario + " Inserto un empleado con nombre " + oEmpleado.NombreCompleto;
                            insertar.Guardar();
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

        private void txbNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space)) {
                Notificador.SetError(txbNombreCompleto, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }
    }
}

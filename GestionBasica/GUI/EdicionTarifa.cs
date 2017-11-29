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
    public partial class EdicionTarifa : Form
    {
        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
        BindingSource _CARGOS = new BindingSource();

        BindingSource _Roles = new BindingSource();
        public EdicionTarifa()
        {
            InitializeComponent();
            CargarTiposPartidas();
        }

        private void CargarTiposPartidas()
        {
            try
            {
                _Roles.DataSource = CacheManager1.Cache.TODOS_LOS_TIPOS_PARTIDAS();
                cbxPartidas.DataSource = null;
                cbxPartidas.DataSource = _Roles;
                cbxPartidas.DisplayMember = "Tipo_partida";
                cbxPartidas.ValueMember = "idTipo_partida";
            }
            catch
            {

            }
        }

        private void EdicionTarifa_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            CLS.Tarifas oUsuario = new CLS.Tarifas();

            oUsuario.IdCosto = txbIdTarifa.Text;
            oUsuario.Monto = txtMonto.Text;
            oUsuario.IdTipoPartida = cbxPartidas.SelectedValue.ToString();


            CLS.Movimiento insertar = new CLS.Movimiento();
            insertar.IdUsuario = _SESION.IdUsuario;

            if (txbIdTarifa.TextLength > 0)
                {
                    //Actualizando
                    try
                    {
                        if (oUsuario.Modificar())
                        {
                        insertar.Accion = "El usuario " + _SESION.Usuario + " modifico la tarifa de la partida con ID " + oUsuario.IdTipoPartida;
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
                        if (oUsuario.Guardar())
                        {
                        insertar.Accion = "El usuario " + _SESION.Usuario + " inserto una nueva tarifa ";
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
}

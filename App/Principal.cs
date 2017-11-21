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
    public partial class Principal : Form
    {

        DataTable _Opciones = new DataTable();
        SessionManager.Sesion _Sesion = SessionManager.Sesion.Instancia;
        public Principal()
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.FromArgb(6,0,88);
        }

        private void gestionarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionEmpleados frm = new GestionBasica.GUI.GestionEmpleados();
            frm.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _Sesion.Usuario;
            lblNombreEmpleado.Text = _Sesion.Nombres;
            tmpConexion.Start();
            CargarOpciones();
        }

        private void CargarOpciones()
        {
            gestionarToolStripMenuItem.Visible = false;
            buscarPartidaDeNacimientoToolStripMenuItem.Visible = false;
            reportesToolStripMenuItem.Visible = false;
            configuraciónToolStripMenuItem.Visible = false;
            ayudaToolStripMenuItem.Visible = false;
            try
            {
                _Opciones = CacheManager1.Cache.PERMISOS_OTORGADOS(_Sesion.IDGrupo);
                foreach (DataRow row in _Opciones.Rows)
                {
                    if (row[1].ToString() == gestionarToolStripMenuItem.Text)
                    {
                        gestionarToolStripMenuItem.Visible = true;
                    }
                    if (row[1].ToString() == buscarPartidaDeNacimientoToolStripMenuItem.Text)
                    {
                        buscarPartidaDeNacimientoToolStripMenuItem.Visible = true;
                    }
                    if (row[1].ToString() == reportesToolStripMenuItem.Text)
                    {
                        reportesToolStripMenuItem.Visible = true;
                    }
                    if(row[1].ToString() == configuraciónToolStripMenuItem.Text)
                    {
                        configuraciónToolStripMenuItem.Visible = true;
                    }
                    if(row[1].ToString() == ayudaToolStripMenuItem.Text)
                    {
                        ayudaToolStripMenuItem.Visible = true;
                    }
                }
            }
            catch
            {

            }

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            oOperacion.Desconectar();
            Application.Exit();
            
        }

        private void agregarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionPartidas frm = new GestionBasica.GUI.GestionPartidas();
            frm.ShowDialog();
        }

        private void partidasEscaneadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionaPartidasEscaneadas frm = new GestionBasica.GUI.GestionaPartidasEscaneadas();
            frm.ShowDialog();
        }

        private void reporteDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.VisorReporteOperaciones frm = new GestionBasica.GUI.VisorReporteOperaciones();
            frm.ShowDialog();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionPermisos frm = new GestionBasica.GUI.GestionPermisos();
            frm.ShowDialog();
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionUsuarios frm = new GestionBasica.GUI.GestionUsuarios();
            frm.ShowDialog();
        }

        private void SegundoPlano_DoWork(object sender, DoWorkEventArgs e)
        {
            String estado = "";
            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            if (oOperacion.VerificarConexion())
            {
                estado = "Conectado";
                SegundoPlano.ReportProgress(50, "Conectado");
            }
            else
            {
                estado = "Desconectado";
                SegundoPlano.ReportProgress(50, "Desconectado");
            }
            e.Result = estado;
            if (SegundoPlano.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private void SegundoPlano_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState.ToString() == "Conectado")
            {
                conectado.Visible = true;
                desconectado.Visible = false;
                conectado.Text = "Conectado";
            }
            else
            {
                desconectado.Visible = true;
                desconectado.Text = "Desconectado";
                conectado.Visible = false;
            }
        }

        private void SegundoPlano_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("The task has been cancelled");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error. Details: " + (e.Error as Exception).ToString());
            }
            else
            {
                //MessageBox.Show("The task has been completed. Results: " + e.Result.ToString());
            }
        }

        private void tmpConexion_Tick(object sender, EventArgs e)
        {
            SegundoPlano.RunWorkerAsync();
        }

        private void profesionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionProfesiones frm = new GestionBasica.GUI.GestionProfesiones();
            frm.ShowDialog();
        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionPaises frm = new GestionBasica.GUI.GestionPaises();
            frm.ShowDialog();
        }

        private void partidasDeMatrimonioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.Matrimonio.GestionPdasMatrimonio frm = new GestionBasica.GUI.Matrimonio.GestionPdasMatrimonio();
            frm.ShowDialog();
        }

        private void causasDeMuerteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionCausas frl = new GestionBasica.GUI.GestionCausas();
            frl.ShowDialog();
        }

        private void cantonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.GestionCantones fmor = new GestionBasica.GUI.GestionCantones();
            fmor.ShowDialog();
        }
    }
}

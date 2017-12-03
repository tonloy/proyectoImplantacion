using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI.Matrimonio
{
    public partial class GestionPdasMatrimonio : Form
    {
        SessionManager.Sesion _SESION = SessionManager.Sesion.Instancia;
        SessionManager.MarginarPartida _Datos = SessionManager.MarginarPartida.Instancia;
        BindingSource _GRUPOS = new BindingSource();
        BindingSource _Hijos = new BindingSource();
        public static int idPdaMatrimonio = 0;

        public GestionPdasMatrimonio()
        {
            InitializeComponent();
            toolStrip1.BackColor = Color.FromArgb(6, 0, 88);
        }


        private void GestionPdasMatrimonio_Load(object sender, EventArgs e)
        {
            CargarPartidas();
        }



        private void CargarPartidas()
        {
            try
            {
                _GRUPOS.DataSource = CacheManager1.Cache.TODAS_PARTIDAS_MATRIMONIO();
                FiltrarLocalmente();
            }
            catch
            {

            }
        }



        private void FiltrarLocalmente()
        {
            _GRUPOS.DataSource = CacheManager1.Cache.TODAS_PARTIDAS_MATRIMONIO();
            if (txbFiltrar.TextLength == 0)
            {
                _GRUPOS.RemoveFilter();
            }
            else
            {
                _GRUPOS.Filter = "Esposo like '%" + txbFiltrar.Text + "%'";
                //_GRUPOS.DataSource = CacheManager1.Cache.TODAS_LAS_PARTIDAS(txbFiltrar.Text);
            }
            dtgPartidas.AutoGenerateColumns = false;
            dtgPartidas.DataSource = _GRUPOS;
            lblNumeroFilas.Text = dtgPartidas.Rows.Count.ToString() + " Registros Encontrados";
        }



        private void dtgPartidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgPartidas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.FromArgb(6, 0, 88);
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalmente();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            GestionBasica.GUI.Matrimonio.IngresarPartidaMat frm = new GestionBasica.GUI.Matrimonio.IngresarPartidaMat();
            frm.ShowDialog();
            CargarPartidas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea EDITAR el Partida seleccionada?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    IngresarPartidaMat frm = new IngresarPartidaMat();

                   
                    frm.txtID_Partida_cod.Text = dtgPartidas.CurrentRow.Cells["ID"].Value.ToString();
                    frm.txbFolio.Text = dtgPartidas.CurrentRow.Cells["folio"].Value.ToString();
                    frm.txbNumPartida.Text = dtgPartidas.CurrentRow.Cells["NumPda"].Value.ToString();
                    frm.txtID_Esposo.Text = dtgPartidas.CurrentRow.Cells["idEsposo"].Value.ToString();
                    frm.txtEsposo.Text = dtgPartidas.CurrentRow.Cells["NombreEsposo"].Value.ToString();
                    frm.txtIdEsposa.Text = dtgPartidas.CurrentRow.Cells["idEsposa"].Value.ToString();
                    frm.txtEsposa.Text = dtgPartidas.CurrentRow.Cells["NombreEsposa"].Value.ToString();
                    frm.txt_IdInf1.Text = dtgPartidas.CurrentRow.Cells["idtes1"].Value.ToString();
                    frm.txtInformante1.Text = dtgPartidas.CurrentRow.Cells["Testigo1"].Value.ToString();
                    frm.txtIdInfo2.Text = dtgPartidas.CurrentRow.Cells["idtes2"].Value.ToString();
                    frm.txtInformante2.Text = dtgPartidas.CurrentRow.Cells["Testigo2"].Value.ToString();
                    frm.txtIDFuncionario.Text = dtgPartidas.CurrentRow.Cells["idfun"].Value.ToString();
                    frm.txtFuncionario.Text = dtgPartidas.CurrentRow.Cells["nfuncionario"].Value.ToString();

                    frm.cbxDepartamentos.SelectedIndex = frm.cbxDepartamentos.FindStringExact(dtgPartidas.CurrentRow.Cells["depto"].Value.ToString());
                    frm.cbxMunicipio.SelectedIndex = frm.cbxMunicipio.FindStringExact(dtgPartidas.CurrentRow.Cells["Municipio"].Value.ToString());
                    frm.cbxRegimenPatrimonial.SelectedIndex = frm.cbxRegimenPatrimonial.FindStringExact(dtgPartidas.CurrentRow.Cells["RegimenPatrimonial"].Value.ToString());
                    frm.txtHora.Text = dtgPartidas.CurrentRow.Cells["Hora_insercion"].Value.ToString();
                    frm.dtpFecha.Text = dtgPartidas.CurrentRow.Cells["FechaMat"].Value.ToString();
                    frm.txtApellidoCasada.Text = dtgPartidas.CurrentRow.Cells["ApellidoCasada"].Value.ToString();
                                        
                    Detalle_Hijos.detalle_hijosfrm = dtgPartidas.CurrentRow.Cells["hijos"].Value.ToString();

                    ///////////
                    frm.txbFolio.ReadOnly = true;
                    frm.txbNumPartida.ReadOnly = true;
                    frm.button1.Enabled = false;
                    frm.button2.Enabled = false;
                    frm.button3.Enabled = false;
                    frm.button4.Enabled = false;
                    frm.button7.Enabled = false;


                    frm.ShowDialog();
                    CargarPartidas();

                }
                catch
                {
                    MessageBox.Show("Por favor seleccione un Registro");
                }
            }
        }

        private void dtgPartidas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GestionBasica.Divorcio.EdicionDivorcio.idEsposa = dtgPartidas.CurrentRow.Cells["idEsposa"].Value.ToString();
            GestionBasica.Divorcio.EdicionDivorcio.idEsposo = dtgPartidas.CurrentRow.Cells["idEsposo"].Value.ToString();
            GestionBasica.Divorcio.IDivorcio miInterfaz = this.Owner as GestionBasica.Divorcio.IDivorcio;
            if (miInterfaz != null)
            {
                miInterfaz.cambiarIdMatrimonio(dtgPartidas.CurrentRow.Cells["ID"].Value.ToString());
                miInterfaz.cambiarFolio(dtgPartidas.CurrentRow.Cells["folio"].Value.ToString());
                miInterfaz.cambiarNumPartida(dtgPartidas.CurrentRow.Cells["NumPda"].Value.ToString());
                miInterfaz.cambiarEsposa(dtgPartidas.CurrentRow.Cells["NombreEsposa"].Value.ToString());
                miInterfaz.cambiarEsposo(dtgPartidas.CurrentRow.Cells["NombreEsposo"].Value.ToString());
                miInterfaz.cambiarFechaMat(dtgPartidas.CurrentRow.Cells["FechaMat"].Value.ToString());
                miInterfaz.cambiarRegimen(dtgPartidas.CurrentRow.Cells["RegimenPatrimonial"].Value.ToString());
            }
            this.Dispose();
        }
    }
    

}

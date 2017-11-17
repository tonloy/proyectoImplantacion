using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.GUI.Matrimonio
{
    public partial class IngresarPartidaMat : Form, IPadre,IInformante, IInfante,  IFuncionario
    {
        ErrorProvider Notificador = new ErrorProvider();
        BindingSource _Municipio = new BindingSource();
        BindingSource _Departamentos = new BindingSource();

        public IngresarPartidaMat()
        {
            InitializeComponent();
            CargarDepartamentos();
            CargarMunicipios();

        }

        //Esposo
        //padres
        public void cambiarIdPadre(String idPadre) { txtID_Esposo.Text = idPadre; }
        public void cambiarPadre(String Padre) { txtEsposo.Text = Padre; }

        //para esposa
        public void cambiarIdMadre(String idMadre) { txtIdEsposa.Text = idMadre; }
        public void cambiarMadre(String Madre) { txtEsposa.Text = Madre; }

        //TEstigo1
        public void cambiarIdInfante(String idInfante) { txt_IdInf1.Text = idInfante; }
        public void cambiarInfante(String infante) { txtInformante1.Text = infante; }

        //para testigo 2
        public void cambiarIdInformantes(String idInformante) { txtIdInfo2.Text = idInformante; }
        public void cambiarInformantes(String Informante) { txtInformante2.Text = Informante; }

        //funcuinario
        public void cambiarIdFuncionario(string idFuncionario) { txtIDFuncionario.Text = idFuncionario; }
        public void cambiarfuncionario(string funcionario) { txtFuncionario.Text = funcionario; }


        private void IngresarPartidaMat_Load(object sender, EventArgs e)
        {
            CargarRegimenesMatrimoniales();

        }

        private void CargarRegimenesMatrimoniales()
        {
            DataRow fila;
            DataTable tipos = new DataTable();
            tipos.Columns.Add("Tipo");
            tipos.Columns.Add("Valor");

            fila = tipos.NewRow();
            fila["Tipo"] = "Separación de Bienes";
            fila["Valor"] = "1";
            tipos.Rows.Add(fila);

            fila = tipos.NewRow();
            fila["Tipo"] = "Partición de Ganancias";
            fila["Valor"] = "2";
            tipos.Rows.Add(fila);

            fila = tipos.NewRow();
            fila["Tipo"] = "Comunidad Diferida";
            fila["Valor"] = "3";
            tipos.Rows.Add(fila);
            
            cbxRegimenPatrimonial.DataSource = tipos;
            cbxRegimenPatrimonial.ValueMember = "Valor";
            cbxRegimenPatrimonial.DisplayMember = "Tipo";

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
            cbxMunicipio.DataSource = dv.ToTable();
            cbxMunicipio.DisplayMember = "municipio";
            cbxMunicipio.ValueMember = "idMunicipio";
        }

        


        //botones de seleciion de sujeto 
        private void button7_Click(object sender, EventArgs e)
        {
            if (txtIDFuncionario.TextLength > 0)
            {
                GestionEmpleados frm = new GestionEmpleados();
                frm.IdFuncionario11 = txtIDFuncionario.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionEmpleados frm = new GestionEmpleados();
                frm.ShowDialog(this);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIdInfo2.TextLength > 0)
            {
                GestionInfantes frm = new GestionInfantes();
                frm.IdInfante1 = txtIdInfo2.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionInfantes frm = new GestionInfantes();
                frm.ShowDialog(this);
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_IdInf1.TextLength > 0)
            {
                GestionInformantes frm = new GestionInformantes();
                frm.IdInformante1 = txt_IdInf1.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionInformantes frm = new GestionInformantes();
                frm.ShowDialog(this);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID_Esposo.TextLength > 0)
            {
                GestionPadres frm = new GestionPadres();
                frm.IdPadre1 = txtID_Esposo.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionPadres frm = new GestionPadres();
                frm.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Madres
            if (txtIdEsposa.TextLength > 0)
            {
                GestionMadres frm = new GestionMadres();
                frm.IdMadre = txtIdEsposa.Text;
                frm.ShowDialog(this);
            }
            else
            {
                GestionMadres frm = new GestionMadres();
                frm.ShowDialog(this);
            }
        }


        //cerrar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //eventos
        private void cbxRespaldoPda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRespaldoPda.Checked)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartamentos.Items.Count > 0)
            {
                CargarMunicipios();
            }
        }

        //validaciones
        private Boolean esHoraValida()
        {
            Regex r = new Regex("([0-1][0-9]|2[0-3]):[0-5][0-9]");
            Boolean sw = true;
            if (!r.Match(txtHora.Text).Success)
            {
                sw = false;
            }
            return sw;
        }

        private void txbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) || (e.KeyChar == (char)Keys.Space))
            {
                Notificador.SetError(txbFolio, "Solo se permiten números");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }

        private void txbNumPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) || (e.KeyChar == (char)Keys.Space))
            {
                Notificador.SetError(txbNumPartida, "Solo se permiten números");
                e.Handled = true;
                return;
            }
            else
            {
                Notificador.Clear();
            }
        }





        //no tienen nada
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void txbFolio_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e){      }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbxMunicipio_SelectedIndexChanged(object sender, EventArgs e) { }

        
    }
}

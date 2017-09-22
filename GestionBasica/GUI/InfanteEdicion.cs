using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GestionBasica.GUI
{
    public partial class InfanteEdicion : Form
    {
        public InfanteEdicion()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtHora);
            sList.Add("e.j ocho horas veinte minutos del dia diez de enero de dos mil diesiocho");
            SetCueBanner(ref tList, sList);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> textbox, List<string> CueText)
        {
            for (int x = 0; x < textbox.Count; x++)
            {
                SendMessage(textbox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void Procesar()
        {
            CLS.Infante oUsuario = new CLS.Infante();

            oUsuario.IdInfante = txbIdInfante.Text;
            oUsuario.Hora1 = txtHora.Text;
            oUsuario.NombreCompleto1 = txtNombreCompleto.Text;
            oUsuario.LugarNac1 = txtLugarNac.Text;
            oUsuario.FechaNac1 = Convert.ToDateTime(dtpFecha.Value.ToString()).ToString("yyyy-MM-dd");

            if (ValidarDatos())
            {
                if (rbtnFemenino.Checked)
                {
                    oUsuario.Sexo1 = "F";
                }
                else
                {
                    oUsuario.Sexo1 = "M";
                }
                if (txbIdInfante.TextLength > 0)
                {
                    //Actualizando
                    try
                    {
                        if (oUsuario.Actualizar())
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
                        if (oUsuario.Insertar())
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
            if (txtNombreCompleto.TextLength == 0)
            {
                Notificador.SetError(txtNombreCompleto, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txtLugarNac.TextLength == 0)
            {
                Notificador.SetError(txtLugarNac, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (txtHora.TextLength == 0)
            {
                Notificador.SetError(txtHora, "Este campo no puede quedar vacío.");
                Validado = false;
            }
            if (!rbtnFemenino.Checked && !rbtnMasculino.Checked)
            {
                Notificador.SetError(rbtnFemenino, "Seleccione un género.");
                Validado = false;
            }

            return Validado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InfanteEdicion_Load(object sender, EventArgs e)
        {

        }
    }
}

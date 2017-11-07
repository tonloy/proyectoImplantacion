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
    public partial class DefuncionEdicion : Form
    {
        public DefuncionEdicion()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbxAsistencia_CheckStateChanged(object sender, EventArgs e)
        {
            if (!chbxAsistencia.Checked)
            {
                btnProfesional.Enabled = false;
            }else
            {
                btnProfesional.Enabled = true;
            }
        }

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
    }
}

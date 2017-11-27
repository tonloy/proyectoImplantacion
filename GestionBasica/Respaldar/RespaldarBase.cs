using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.Respaldar
{
    public partial class RespaldarBase : Form
    {
        String fecha = DateTime.Now.ToString("yyyy-MM-dd");
        public RespaldarBase()
        {
            InitializeComponent();
        }

        private void RespaldarBase_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folder.SelectedPath + @"\respaldo" + fecha + ".sql";
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtRuta.TextLength > 0)
            {
                try
                {
                    Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    cmd.StandardInput.WriteLine(@"cd C:\Program Files\MySQL\MySQL Server 5.7\bin\");
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.WriteLine("mysqldump -hlocalhost -P3306 -uroot -padmin --opt --routines --add-drop-database --databases registro_familiar>\"" + txtRuta.Text + "\"");
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();

                    MessageBox.Show("Respaldo realizado correctamente", "Respaldo correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRuta.Clear();
                }
                catch
                {
                    MessageBox.Show("No se pudo realizar el respaldo");
                }
            }else
            {
                MessageBox.Show("Seleccione una ruta");
                btnSeleccionar.PerformClick();
            }
        }
    }
}

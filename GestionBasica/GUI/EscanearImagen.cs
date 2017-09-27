using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace GestionBasica.GUI
{
    public partial class EscanearImagen : Form
    {
        WIA.DeviceInfo info;
        public EscanearImagen()
        {
            InitializeComponent();
        }

        private void EscanearImagen_Load(object sender, EventArgs e)
        {
            Devices.Items.Clear();
            var deviceManager = new DeviceManager();
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    return;
                }
                Devices.Items.Add(new CLS.Scanner(deviceManager.DeviceInfos[i]));
                info = deviceManager.DeviceInfos[i];
            }
            if (Devices.Items.Count == 0)
            {
                Devices.Items.Add("No hay dispositivos conectados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var device = Devices.SelectedItem as CLS.Scanner;
            if (device == null)
            {
                MessageBox.Show("Seleccione un dispositivo de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //get images from scanner
                List<Image> images = CLS.WIAScanner.Scan(info.DeviceID);
                foreach (Image image in images)
                {
                    
                    //save scanned image into specific folder
                    SaveFileDialog Guardar = new SaveFileDialog();
                    Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP|PNG|*.PNG";
                    Image Imagen = image;
                    Guardar.ShowDialog();
                    Imagen.Save(Guardar.FileName);
                    img.ImageLocation = Guardar.FileName;
                    img.Show();
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(img.ImageLocation==null){
                MessageBox.Show("Escanee una imagen primero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IImagen miInterfaz = this.Owner as IImagen;
                if (miInterfaz != null)
                {
                    miInterfaz.cambiarImagen(img.ImageLocation);
                }
                this.Dispose();
            }
        }
    }
}

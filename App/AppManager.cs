using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    class AppManager:ApplicationContext
    {

        public AppManager()
        {
            if (Splash())
            {
                if (Login())
                {
                    Principal frm = new Principal();
                    frm.ShowDialog();
                }
            }
        }

        private Boolean Splash()
        {
            Boolean comprobacion = true;
            Splash frm = new Splash();
            frm.ShowDialog();
            return comprobacion;
        }

        private Boolean Login()
        {
            Boolean verificado = false;
            Login frm = new Login();
            frm.ShowDialog();
            verificado = frm.Autorizado;
            return verificado;
        }
    }
}

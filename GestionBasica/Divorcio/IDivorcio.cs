using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.Divorcio
{
    public interface IDivorcio
    {
        void cambiarIdMatrimonio(String idInfante);
        void cambiarFolio(String infante);
        void cambiarNumPartida(String pda);
        void cambiarEsposo(String esposo);
        void cambiarEsposa(String esposa);
        void cambiarFechaMat(String fecha);
        void cambiarRegimen(String reg);
    }
}

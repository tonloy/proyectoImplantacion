using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.GUI
{
    interface IPadre
    {
        void cambiarIdPadre(String idPadre);
        void cambiarPadre(String padre);


        //madres
        void cambiarIdMadre(String idMadre);
        void cambiarMadre(String madre);

        //Informantes
        void cambiarIdInformantes(String idInformantes);
        void cambiarInformantes(String Informantes);



    }
}

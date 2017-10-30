using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Dui
    {
        public static string dui_letras(string dui)
        {
            String resultado = "";
            char[] letras = dui.ToArray();
            resultado = Conv.enletras(letras[0].ToString()) +" ";
            resultado += Conv.enletras(letras[1].ToString()) + " ";
            resultado += Conv.enletras(letras[2].ToString()) + " ";
            resultado += Conv.enletras(letras[3].ToString()) + " ";
            resultado += Conv.enletras(letras[4].ToString()) + " ";
            resultado += Conv.enletras(letras[5].ToString()) + " ";
            resultado += Conv.enletras(letras[6].ToString()) + " ";
            resultado += Conv.enletras(letras[7].ToString()) + " ";
            resultado += " guión ";
            resultado += Conv.enletras(letras[9].ToString());

            return resultado;

        }
    }
}

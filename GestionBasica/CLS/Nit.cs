using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Nit
    {
        public static string nit_letras(string nit)
        {
            String resultado = "";
            char[] letras = nit.ToArray();
            resultado = Conv.enletras(letras[0].ToString()) + " ";
            resultado += Conv.enletras(letras[1].ToString()) + " ";
            resultado += Conv.enletras(letras[2].ToString()) + " ";
            resultado += Conv.enletras(letras[3].ToString()) + " ";
            resultado += " guión ";
            resultado += Conv.enletras(letras[5].ToString()) + " ";
            resultado += Conv.enletras(letras[6].ToString()) + " ";
            resultado += Conv.enletras(letras[7].ToString()) + " ";
            resultado += Conv.enletras(letras[8].ToString()) + " ";
            resultado += Conv.enletras(letras[9].ToString()) + " ";
            resultado += Conv.enletras(letras[10].ToString()) + " ";
            resultado += " guión ";
            resultado += Conv.enletras(letras[12].ToString()) + " ";
            resultado += Conv.enletras(letras[13].ToString()) + " ";
            resultado += Conv.enletras(letras[14].ToString()) + " ";
            resultado += " guión ";
            resultado += Conv.enletras(letras[16].ToString()) + " ";

            return resultado;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Hora
    {
        public static string hora_letras(string hora)
        {
            String resultado,horas,minutos;
            String[] horasminutos=hora.Split(':');

            horas = Conv.enletras(horasminutos[0]);
            minutos = Conv.enletras(horasminutos[1]);
            resultado = horas + " horas " + minutos + " minutos";

            return resultado;

        }
        public static string fecha_letras(string fecha)
        {
            String resultado, dia, mes="",anio;
            String[] fechacompleta = fecha.Split('-');

            anio = Conv.enletras(fechacompleta[0]);
            dia = Conv.enletras(fechacompleta[2]);

            switch (fechacompleta[1])
            {
                case "01":
                    mes = "Enero";
                    break;
                case "02":
                    mes = "Febrero";
                    break;
                case "03":
                    mes = "Marzo";
                    break;
                case "04":
                    mes = "Abril";
                    break;
                case "05":
                    mes = "Mayo";
                    break;
                case "06":
                    mes = "Junio";
                    break;
                case "07":
                    mes = "Julio";
                    break;
                case "08":
                    mes = "Agosto";
                    break;
                case "09":
                    mes = "Septiembre";
                    break;
                case "10":
                    mes = "Octubre";
                    break;
                case "11":
                    mes = "Noviembre";
                    break;
                case "12":
                    mes = "Diciembre";
                    break;
            }

            resultado = dia + " de " + mes + " de "+anio;

            return resultado;

        }
    }
}

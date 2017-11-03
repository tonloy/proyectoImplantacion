using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    public class Infante 
    {
        //atributos
        private string idInfante;
        private string NombreCompleto;
        private string LugarNac;
        private string Sexo;
        private string Hora;
        private string FechaNac;
        private string Hora_letras;

        public string Hora_letras1
        {
            get { return Hora_letras; }
            set { Hora_letras = value; }
        }
        private string FechaNac_letras;

        public string FechaNac_letras1
        {
            get { return FechaNac_letras; }
            set { FechaNac_letras = value; }
        }

        //Propiedades
        public string IdInfante
        {
            get { return idInfante; }
            set { idInfante = value; }
        }

        public string NombreCompleto1
        {
            get { return NombreCompleto; }
            set { NombreCompleto = value; }
        }

        public string LugarNac1
        {
            get { return LugarNac; }
            set { LugarNac = value; }
        }

        public string Sexo1
        {
            get { return Sexo; }
            set { Sexo = value; }
        }

        public string Hora1
        {
            get { return Hora; }
            set { Hora = value; }
        }

        public string FechaNac1
        {
            get { return FechaNac; }
            set { FechaNac = value; }
        }


        //metodos
        public bool Insertar(Int32 revisado) {

            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            
            Sentencia.Append("INSERT INTO registro_familiar.padres (NombreCompleto, LugarNac, Sexo, Hora, FechaNac, Revisado,Hora_letras,FechaNac_letras,Nacionalidad) VALUES ( ");
            Sentencia.Append("'" + NombreCompleto + "', '" + LugarNac + "', '" + Sexo + "','" + Hora + "','" + FechaNac + "',"+revisado+",'"+Hora_letras1+"','"+FechaNac_letras1+"' ,129);  ");
            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            {
                if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                {
                    guardado = true;
                }
                else
                {
                    guardado = false;
                }
            }
            catch
            {
                guardado = false;
            }

            return guardado;
            
        }
        public bool Actualizar(Int32 pRevisado)
        {

            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("UPDATE registro_familiar.padres SET NombreCompleto='" + NombreCompleto + "',LugarNac='" + LugarNac + "',Sexo='" + Sexo + "', Hora='" + Hora + "',Revisado='" + pRevisado + "', FechaNac='" + FechaNac + "',Hora_letras='"+Hora_letras1+"',FechaNac_letras='"+FechaNac_letras1+"' WHERE idPadre='" + idInfante + "';");
            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            {
                if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                {
                    guardado = true;
                }
                else
                {
                    guardado = false;
                }
            }
            catch
            {
                guardado = false;
            }

            return guardado;

        }

    }
}

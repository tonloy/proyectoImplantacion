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
            
            Sentencia.Append("INSERT INTO registro_familiar.infantes (NombreCompleto, LugarNac, Sexo, Hora, FechaNac, Revisado) VALUES ( ");
            Sentencia.Append("'" + NombreCompleto + "', '" + LugarNac + "', '" + Sexo + "','" + Hora + "','" + FechaNac + "',"+revisado+" );  ");
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

            Sentencia.Append("UPDATE registro_familiar.infantes SET NombreCompleto='" + NombreCompleto + "',LugarNac='" + LugarNac + "',Sexo='" + Sexo + "', Hora='" + Hora + "',Revisado='" + pRevisado + "', FechaNac='" + FechaNac + "' WHERE idInfante='" + idInfante + "';");
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

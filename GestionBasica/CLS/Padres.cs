using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    public class Padres
    {   
        //atributos
        private string idPadre;
        private string NombreCompleto;
        private string ConocidoPor;
        private string Edad;
        private string Domicilio;
        private string Nacionalidad;
        private string DUI;
        private string idMunicipio;
        private string Profesion;
        private string Parentesco;
        private string Observaciones;
        private string Edad_letras;

        public string Edad_letras1
        {
            get { return Edad_letras; }
            set { Edad_letras = value; }
        }

        public string Observaciones1
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }

        public string Parentesco1
        {
            get { return Parentesco; }
            set { Parentesco = value; }
        }


        //prop
        public string Profesion1
        {
            get { return Profesion; }
            set { Profesion = value; }
        }

        public string IdMunicipio
        {
              get { return idMunicipio; }
              set { idMunicipio = value; }
        }

        public string DUI1
        {
            get { return DUI; }
            set { DUI = value; }
        }

         public string Nacionalidad1
        {
            get { return Nacionalidad; }
            set { Nacionalidad = value; }
        }

        public string Domicilio1
        {
            get { return Domicilio; }
            set { Domicilio = value; }
        }

        public string Edad1
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public string ConocidoPor1
        {
            get { return ConocidoPor; }
            set { ConocidoPor = value; }
        }

        public string NombreCompleto1
        {
            get { return NombreCompleto; }
            set { NombreCompleto = value; }
        }

        public string IdPadre
        {
            get { return idPadre; }
            set { idPadre = value; }
        }


        //me
        public bool Insertar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO registro_familiar.padres (NombreCompleto, ConocidoPor, Edad, Domicilio, Nacionalidad, DUI, idMunicipio, Profesion, idParentesco, Observaciones,Edad_letras) VALUES ( ");
            Sentencia.Append("'" + NombreCompleto + "', '" + ConocidoPor + "', '" + Edad + "','" + Domicilio + "','" + Nacionalidad + "','" + DUI + "','" + IdMunicipio + "','" + Profesion + "',"+Parentesco+",'"+Observaciones+"','"+Edad_letras+"' );  ");
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


        public Boolean Actualizar()
        {
            Boolean actualizado = false;
            StringBuilder Sentencia = new StringBuilder();
            
            Sentencia.Append("update registro_familiar.padres set NombreCompleto = '");
            Sentencia.Append(NombreCompleto1 + "',ConocidoPor='");
            Sentencia.Append(ConocidoPor1 + "',Profesion='");
            Sentencia.Append(Profesion1 + "',Edad=");
            Sentencia.Append(Edad + ",Domicilio='");
            Sentencia.Append(Domicilio + "',Nacionalidad=");
            Sentencia.Append(Nacionalidad + ",DUI='");
            Sentencia.Append(DUI + "',idMunicipio=");
            Sentencia.Append(idMunicipio + ",idParentesco="+Parentesco+",Observaciones='"+Observaciones+"',Edad_letras='"+Edad_letras+"' where idPadre=" + IdPadre + ";");

            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            {
                if (oOperacion.Insertar(Sentencia.ToString()) > 0)
                {
                    actualizado = true;
                }
                else
                {
                    actualizado = false;
                }
            }
            catch
            {
                actualizado = false;
            }

            return actualizado;
        }



    }
}

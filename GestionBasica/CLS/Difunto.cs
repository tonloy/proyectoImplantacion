using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Difunto
    {
        private string idPadre;
        private string NombreCompleto;
        private string ConocidoPor;
        private string Edad;
        private string Domicilio;
        private string Nacionalidad;
        private string DUI;
        private string idMunicipio;
        private string Profesion;
        private string Edad_letras;
        private string NumPartida;
        private string NumPartidaLetras;
        private string DUI_letras;
        private string Sexo;
        private string Revisado;
        private string Estado_familiar;

        public string Revisado1
        {
            get
            {
                return Revisado;
            }

            set
            {
                Revisado = value;
            }
        }

        public string Sexo1
        {
            get
            {
                return Sexo;
            }

            set
            {
                Sexo = value;
            }
        }

        public string DUI_letras1
        {
            get
            {
                return DUI_letras;
            }

            set
            {
                DUI_letras = value;
            }
        }

        public string NumPartidaLetras1
        {
            get
            {
                return NumPartidaLetras;
            }

            set
            {
                NumPartidaLetras = value;
            }
        }

        public string NumPartida1
        {
            get
            {
                return NumPartida;
            }

            set
            {
                NumPartida = value;
            }
        }

        public string Edad_letras1
        {
            get
            {
                return Edad_letras;
            }

            set
            {
                Edad_letras = value;
            }
        }

        public string Profesion1
        {
            get
            {
                return Profesion;
            }

            set
            {
                Profesion = value;
            }
        }

        public string IdMunicipio
        {
            get
            {
                return idMunicipio;
            }

            set
            {
                idMunicipio = value;
            }
        }

        public string DUI1
        {
            get
            {
                return DUI;
            }

            set
            {
                DUI = value;
            }
        }

        public string Nacionalidad1
        {
            get
            {
                return Nacionalidad;
            }

            set
            {
                Nacionalidad = value;
            }
        }

        public string Domicilio1
        {
            get
            {
                return Domicilio;
            }

            set
            {
                Domicilio = value;
            }
        }

        public string Edad1
        {
            get
            {
                return Edad;
            }

            set
            {
                Edad = value;
            }
        }

        public string ConocidoPor1
        {
            get
            {
                return ConocidoPor;
            }

            set
            {
                ConocidoPor = value;
            }
        }

        public string NombreCompleto1
        {
            get
            {
                return NombreCompleto;
            }

            set
            {
                NombreCompleto = value;
            }
        }

        public string IdPadre
        {
            get
            {
                return idPadre;
            }

            set
            {
                idPadre = value;
            }
        }

        public string Estado_familiar1
        {
            get
            {
                return Estado_familiar;
            }

            set
            {
                Estado_familiar = value;
            }
        }

        public bool Insertar(Int32 pRevisado)
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO registro_familiar.padres (NombreCompleto, ConocidoPor, Edad, Domicilio, Nacionalidad, DUI, idMunicipio, Profesion,Edad_letras, NumPartida, NumPartidaLetras,Dui_letras,Revisado,Sexo,Estado_familiar) VALUES ( ");
            Sentencia.Append("'" + NombreCompleto + "', '" + ConocidoPor + "', '" + Edad + "','" + Domicilio + "','" + Nacionalidad + "','" + DUI + "','" + IdMunicipio + "','" + Profesion + "','" + Edad_letras + "','" + NumPartida1 + "','" + NumPartidaLetras1 + "','" + DUI_letras1 + "',"+ pRevisado + ",'"+Sexo+"','"+Estado_familiar+"' );  ");
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

        public Boolean Actualizar(Int32 pRevisado)
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
            Sentencia.Append(idMunicipio + ",Edad_letras='" + Edad_letras + "',Sexo='" + Sexo + "',Estado_familiar='" + Estado_familiar + "',Dui_letras='" + DUI_letras1 + "',Revisado="+ pRevisado + " where idPadre=" + IdPadre + ";");

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

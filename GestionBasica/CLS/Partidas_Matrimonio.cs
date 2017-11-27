using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Partidas_Matrimonio
    {

        private string idpartida_matrimonio;
        private string NumPartida;
        private string folio;
        private string idEsposa;
        private string idEsposo;
        private string idPadre_esposa;
        private string idMadre_esposa;
        private string idPadre_esposo;
        private string idMadre_esposo;
        private string idFuncionario;
        private string idTestigo;
        private string idTestigo2;
        private string Lugar_matrimonio;
        private string Fecha_matrimonio;
        private string Hora_matrimonio;
        private string Apellido_elegido;
        private string Regimen_patrimonial;
        private string idTipo_partida;
        private string Imagen;
        private string folio_letras;
        private string anio_insercion_letras;
        private string Fecha_insercion;
        private string Hora_insercion;
        private string Fecha_insercion_letra;
        private string Hora_insercion_letra;
        private string Fecha_matrimonio_letra;
        private string detalle_hijos;



        public string Idpartida_matrimonio
        {
            get
            {
                return idpartida_matrimonio;
            }

            set
            {
                idpartida_matrimonio = value;
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

        public string Folio
        {
            get
            {
                return folio;
            }

            set
            {
                folio = value;
            }
        }

        public string IdEsposa
        {
            get
            {
                return idEsposa;
            }

            set
            {
                idEsposa = value;
            }
        }

        public string IdEsposo
        {
            get
            {
                return idEsposo;
            }

            set
            {
                idEsposo = value;
            }
        }

        public string IdPadre_esposa
        {
            get
            {
                return idPadre_esposa;
            }

            set
            {
                idPadre_esposa = value;
            }
        }

        public string IdMadre_esposa
        {
            get
            {
                return idMadre_esposa;
            }

            set
            {
                idMadre_esposa = value;
            }
        }

        public string IdPadre_esposo
        {
            get
            {
                return idPadre_esposo;
            }

            set
            {
                idPadre_esposo = value;
            }
        }

        public string IdMadre_esposo
        {
            get
            {
                return idMadre_esposo;
            }

            set
            {
                idMadre_esposo = value;
            }
        }

        public string IdFuncionario
        {
            get
            {
                return idFuncionario;
            }

            set
            {
                idFuncionario = value;
            }
        }

        public string IdTestigo
        {
            get
            {
                return idTestigo;
            }

            set
            {
                idTestigo = value;
            }
        }

        public string IdTestigo2
        {
            get
            {
                return idTestigo2;
            }

            set
            {
                idTestigo2 = value;
            }
        }

        public string Lugar_matrimonio1
        {
            get
            {
                return Lugar_matrimonio;
            }

            set
            {
                Lugar_matrimonio = value;
            }
        }

        public string Fecha_matrimonio1
        {
            get
            {
                return Fecha_matrimonio;
            }

            set
            {
                Fecha_matrimonio = value;
            }
        }

        public string Hora_matrimonio1
        {
            get
            {
                return Hora_matrimonio;
            }

            set
            {
                Hora_matrimonio = value;
            }
        }

        public string Apellido_elegido1
        {
            get
            {
                return Apellido_elegido;
            }

            set
            {
                Apellido_elegido = value;
            }
        }

        public string Regimen_patrimonial1
        {
            get
            {
                return Regimen_patrimonial;
            }

            set
            {
                Regimen_patrimonial = value;
            }
        }

        public string IdTipo_partida
        {
            get
            {
                return idTipo_partida;
            }

            set
            {
                idTipo_partida = value;
            }
        }

        public string Imagen1
        {
            get
            {
                return Imagen;
            }

            set
            {
                Imagen = value;
            }
        }

        public string Folio_letras
        {
            get
            {
                return folio_letras;
            }

            set
            {
                folio_letras = value;
            }
        }

        public string Anio_insercion_letras
        {
            get
            {
                return anio_insercion_letras;
            }

            set
            {
                anio_insercion_letras = value;
            }
        }

        public string Fecha_insercion1
        {
            get
            {
                return Fecha_insercion;
            }

            set
            {
                Fecha_insercion = value;
            }
        }

        public string Hora_insercion1
        {
            get
            {
                return Hora_insercion;
            }

            set
            {
                Hora_insercion = value;
            }
        }

        public string Fecha_insercion_letra1
        {
            get
            {
                return Fecha_insercion_letra;
            }

            set
            {
                Fecha_insercion_letra = value;
            }
        }

        public string Hora_insercion_letra1
        {
            get
            {
                return Hora_insercion_letra;
            }

            set
            {
                Hora_insercion_letra = value;
            }
        }

        public string Fecha_matrimonio_letra1
        {
            get
            {
                return Fecha_matrimonio_letra;
            }

            set
            {
                Fecha_matrimonio_letra = value;
            }
        }

        public string Detalle_hijos
        {
            get
            {
                return detalle_hijos;
            }

            set
            {
                detalle_hijos = value;
            }
        }

        public bool Insertar(Int32 revisado)
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO registro_familiar.partidas_matrimonio ( NumPartida, idEsposa, idEsposo, idPadre_esposa, idMadre_esposa, idPadre_esposo, idMadre_esposo, idFuncionario, idTestigo, Lugar_matrimonio, Fecha_matrimonio, Hora_matrimonio,  Apellido_elegido, Regimen_patrimonial, Imagen, idTipo_partida, idTestigo2, folio_letras, Hora_insercion, Hora_insercion_letra,  Fecha_matrimonio_letra, folio, detalle_hijos) VALUES ( ");
            Sentencia.Append("'" + NumPartida1 + "', '" + IdEsposa + "', '" + IdEsposo + "','" + IdPadre_esposa + "','" + IdMadre_esposa + "','" + IdPadre_esposo + "','" + IdMadre_esposo + "', '" + IdFuncionario + "'," + IdTestigo + ",'" + Lugar_matrimonio1 + "','" + Fecha_matrimonio1 + "','" + Hora_matrimonio1 + "','" + Apellido_elegido1 + "','" + Regimen_patrimonial1 + "','" + Imagen1 + "','2','" + IdTestigo2 + "', '" + Folio_letras + "', '" + Hora_insercion1 + "','" + Hora_insercion_letra1 + "','" + Fecha_matrimonio_letra1 + "','" + Folio + "','" + Detalle_hijos + "' );  ");
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
            //luga, hora y apellido
            Boolean actualizado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append(" UPDATE registro_familiar.partidas_matrimonio SET Lugar_matrimonio ='");
            Sentencia.Append(Lugar_matrimonio1 + "',Fecha_matrimonio='");
            Sentencia.Append(Fecha_matrimonio1 + "',Hora_matrimonio='");
            Sentencia.Append(Hora_insercion1 + "',Apellido_elegido='");
            Sentencia.Append(Apellido_elegido1 + "',Regimen_patrimonial='");
            Sentencia.Append(Regimen_patrimonial1 + "', Hora_insercion_letra='");
            Sentencia.Append(Hora_insercion_letra1 + "', Fecha_insercion_letra='" + Fecha_insercion_letra1 + "', detalle_hijos ='" + Detalle_hijos  + "' WHERE idpartida_matrimonio=" + idpartida_matrimonio + ";");

            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            { 
                if (oOperacion.Actualizar(Sentencia.ToString()) > 0)
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

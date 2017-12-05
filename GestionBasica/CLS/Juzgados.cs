using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Juzgados
    {

        private String idJuzgados;
        private String Nombre;
        private String idMunicipio;
        private String Direccion;

        public string IdJuzgados
        {
            get
            {
                return idJuzgados;
            }

            set
            {
                idJuzgados = value;
            }
        }

        public string Nombre1
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
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

        public string Direccion1
        {
            get
            {
                return Direccion;
            }

            set
            {
                Direccion = value;
            }
        }



        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO registro_familiar.juzgados( Nombre, idMunicipio, Direccion) VALUES('");
            Sentencia.Append(Nombre1 + "',");
            Sentencia.Append(IdMunicipio + ",'");
            Sentencia.Append(Direccion1 + "');");

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

        public Boolean Modificar()
        {
            Boolean modificado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("UPDATE registro_familiar.juzgados SET Nombre =");
            Sentencia.Append("'" + Nombre1 + "',idMunicipio=");
            Sentencia.Append("" + IdMunicipio + ",Direccion=");
            Sentencia.Append("'" + Direccion1 + "' where idJuzgados=");
            Sentencia.Append(IdJuzgados + ";");

            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            {
                if (oOperacion.Actualizar(Sentencia.ToString()) > 0)
                {
                    modificado = true;
                }
                else
                {
                    modificado = false;
                }
            }
            catch
            {
                modificado = false;
            }
            return modificado;
        }

        public Boolean Eliminar()
        {
            Boolean eliminado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("delete from juzgados where idJuzgados=" + IdJuzgados + ";");

            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            {
                if (oOperacion.Eliminar(Sentencia.ToString()) > 0)
                {
                    eliminado = true;
                }
                else
                {
                    eliminado = false;
                }
            }
            catch
            {
                eliminado = false;
            }
            return eliminado;
        }
    }
}

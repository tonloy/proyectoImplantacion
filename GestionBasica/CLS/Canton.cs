using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Canton
    {
        String _idCanton;
        String _idMunicipio;
        String _Canton;

        public string Canton1
        {
            get
            {
                return _Canton;
            }

            set
            {
                _Canton = value;
            }
        }

        public string IdMunicipio
        {
            get
            {
                return _idMunicipio;
            }

            set
            {
                _idMunicipio = value;
            }
        }

        public string IdCanton
        {
            get
            {
                return _idCanton;
            }

            set
            {
                _idCanton = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO cantones(idMunicipio,Canton) VALUES(");
            Sentencia.Append(_idMunicipio + ",'");
            Sentencia.Append(_Canton + "');");

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

            Sentencia.Append("UPDATE cantones set Canton=");
            Sentencia.Append("'" + _Canton + "',idMunicipio=");
            Sentencia.Append(_idMunicipio + " where idCanton=");
            Sentencia.Append(_idCanton + ";");

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

            Sentencia.Append("delete from cantones where idCanton=" + _idCanton + ";");

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

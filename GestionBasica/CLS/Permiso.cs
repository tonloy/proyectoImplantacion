using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Permiso
    {
        String _idPermiso;
        String _idOpcion;
        String _idGrupo;
        String _FechaCreacion;

        public String FechaCreacion
        {
            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        public String IdGrupo
        {
            get { return _idGrupo; }
            set { _idGrupo = value; }
        }

        public String IdOpcion
        {
            get { return _idOpcion; }
            set { _idOpcion = value; }
        }

        public String IdPermiso
        {
            get { return _idPermiso; }
            set { _idPermiso = value; }
        }
        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("insert into permisos(idRol,idOpcion,FechaCreacion) values(");
            Sentencia.Append(_idGrupo + ",");
            Sentencia.Append(_idOpcion + ",");
            Sentencia.Append("now());");
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
        public Boolean Eliminar()
        {
            Boolean eliminado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("delete from permisos where ");
            Sentencia.Append("idOpcion=" + _idOpcion + " and ");
            Sentencia.Append("idRol=" + _idGrupo + ";");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Usuario
    {

        String _idUsuario;
        String _Usuario;
        String _Credencial;
        String _IDRol;
        String _IDEmpleado;
        String _FechaCreacion;

        public String FechaCreacion
        {
            get { return _FechaCreacion; }
            set { _FechaCreacion = value; }
        }

        public String IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }

        public String IDRol
        {
            get { return _IDRol; }
            set { _IDRol = value; }
        }

        public String Credencial
        {
            get { return _Credencial; }
            set { _Credencial = value; }
        }

        public String Usuario1
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public String IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("insert into usuarios(Usuario,Credencial,IDEmpleado,IDRol,FechaCreacion) values(");
            Sentencia.Append("'" + _Usuario + "',");
            Sentencia.Append("md5('" + _Credencial + "'),");
            Sentencia.Append("" + _IDEmpleado + ",");
            Sentencia.Append("" + _IDRol + ",");
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

        public Boolean Actualizar()
        {
            Boolean actualizado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("update usuarios set Usuario='");
            Sentencia.Append(_Usuario + "',IDEmpleado=");
            Sentencia.Append(_IDEmpleado + ",IDRol=");
            Sentencia.Append(_IDRol + " where idUsuario=" + _idUsuario + ";");

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
        public Boolean ActualizarPassword()
        {
            Boolean actualizado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("update usuarios set Credencial=md5('");
            Sentencia.Append(_Credencial + "') where idUsuario=" + _idUsuario + ";");

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
        public Boolean Eliminar()
        {
            Boolean eliminado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("delete from usuarios where ");
            Sentencia.Append("idUsuario=" + _idUsuario + ";");
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

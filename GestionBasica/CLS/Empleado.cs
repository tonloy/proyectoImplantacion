using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Empleado
    {
        String _idEmpleado;
        String _rubricas;

        public String IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }
        String _NombreCompleto;

        public String NombreCompleto
        {
            get { return _NombreCompleto; }
            set { _NombreCompleto = value; }
        }
        String _idCargo;

        public String IdCargo
        {
            get { return _idCargo; }
            set { _idCargo = value; }
        }

        public string Rubricas
        {
            get
            {
                return _rubricas;
            }

            set
            {
                _rubricas = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO empleados(NombreCompleto,idCargo,Rubrica) VALUES(");
            Sentencia.Append("'" + _NombreCompleto + "',");
            Sentencia.Append(_idCargo+",'"+_rubricas+"');");

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

            Sentencia.Append("UPDATE empleados set NombreCompleto=");
            Sentencia.Append("'" + _NombreCompleto + "',idCargo=");
            Sentencia.Append(_idCargo + ",Rubrica='"+_rubricas+"' where idEmpleado=");
            Sentencia.Append(_idEmpleado + ";");

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

            Sentencia.Append("delete from empleados where idEmpleado=" + _idEmpleado + ";");

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

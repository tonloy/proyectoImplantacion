using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    public class Movimiento
    {
        String _idMovimientos;
        String _Fecha;
        String _Hora;
        String _idUsuario;
        String _Accion;

        public string Accion
        {
            get
            {
                return _Accion;
            }

            set
            {
                _Accion = value;
            }
        }

        public string IdUsuario
        {
            get
            {
                return _idUsuario;
            }

            set
            {
                _idUsuario = value;
            }
        }

        public string Hora
        {
            get
            {
                return _Hora;
            }

            set
            {
                _Hora = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public string IdMovimientos
        {
            get
            {
                return _idMovimientos;
            }

            set
            {
                _idMovimientos = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO movimientos(Fecha,Hora,idUsuario,Accion) VALUES(curdate(),current_time(),");
            Sentencia.Append(_idUsuario + ",'"+_Accion+"');");

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

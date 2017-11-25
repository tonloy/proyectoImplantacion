using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Tarifas
    {
        String _idCosto;
        String _monto;
        String _idTipoPartida;

        public string IdTipoPartida
        {
            get
            {
                return _idTipoPartida;
            }

            set
            {
                _idTipoPartida = value;
            }
        }

        public string Monto
        {
            get
            {
                return _monto;
            }

            set
            {
                _monto = value;
            }
        }

        public string IdCosto
        {
            get
            {
                return _idCosto;
            }

            set
            {
                _idCosto = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO costos(Monto,idTipo_partida) VALUES(");
            Sentencia.Append(_monto + ",");
            Sentencia.Append(_idTipoPartida + ");");

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

            Sentencia.Append("UPDATE costos set Monto=");
            Sentencia.Append(_monto + ",idTipo_partida=");
            Sentencia.Append(_idTipoPartida + " where idCosto=");
            Sentencia.Append(_idCosto + ";");

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
    }
}

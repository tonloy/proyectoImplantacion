using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Operaciones
    {
        String _idTransaccion;

        public String IdTransaccion
        {
            get { return _idTransaccion; }
            set { _idTransaccion = value; }
        }
        String _Tipo;

        public String Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }
        String _Fecha;

        public String Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        String _idPartida;

        public String IdPartida
        {
            get { return _idPartida; }
            set { _idPartida = value; }
        }
        String _idPartida_defuncion;

        public String IdPartida_defuncion
        {
            get { return _idPartida_defuncion; }
            set { _idPartida_defuncion = value; }
        }
        String _idPartida_matrimonio;

        public String IdPartida_matrimonio
        {
            get { return _idPartida_matrimonio; }
            set { _idPartida_matrimonio = value; }
        }
        String _idDivorcio;

        public String IdDivorcio
        {
            get { return _idDivorcio; }
            set { _idDivorcio = value; }
        }
        String _Costo;

        public String Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO empleados(NombreCompleto,idCargo) VALUES(");

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

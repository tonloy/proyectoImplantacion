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

        public Boolean Guardar(Int32 ope)
        {
            //1 nueva partida de nacimiento
            //2 imprimir partida de nacimiento
            //3 nueva partida de matrimonio
            //4 imprimir partida de matrimonio
            //5 nueva partida de divorcio
            //6 imprimir partida de divorcio
            //7 nueva partida de defuncion
            //8 imprimir partida de defuncion
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();
            switch (ope)
            {
                case 1:
                    Sentencia.Append("INSERT INTO operaciones(Tipo, idPartida, Costo) VALUES(");
                    Sentencia.Append("'Nueva partida de nacimiento',(SELECT idPartida FROM registro_familiar.partidas_nacimiento order by idPartida desc limit 1),0);");
                    break;
                case 2:
                    Sentencia.Append("INSERT INTO operaciones(Tipo, idPartida, Costo) VALUES(");
                    Sentencia.Append("'Impresión de partida de nacimiento'," + _idPartida + ",(SELECT Monto FROM registro_familiar.costos where idTipo_partida=1));");
                    break;
                case 3:
                    Sentencia.Append("INSERT INTO operaciones(Tipo, idPartida_matrimonio, Costo) VALUES(");
                    Sentencia.Append("'Nueva partida de matrimonio',(SELECT idpartida_matrimonio FROM registro_familiar.partidas_matrimonio order by idpartida_matrimonio desc limit 1),0);");
                    break;
                case 4:
                    Sentencia.Append("INSERT INTO operaciones(Tipo, idPartida_matrimonio, Costo) VALUES(");
                    Sentencia.Append("'Impresión de partida de Matrimonio'," + _idPartida + ",(SELECT Monto FROM registro_familiar.costos where idTipo_partida=2));");
                    break;
                case 5:
                    Sentencia.Append("INSERT INTO operaciones(Tipo, idDivorcio, Costo) VALUES(");
                    Sentencia.Append("'Nueva partida de divorcio',(SELECT idDivorcio FROM registro_familiar.divorcios order by idDivorcio desc limit 1),0);");
                    break;
                case 6:
                    Sentencia.Append("INSERT INTO operaciones(Tipo, idDivorcio, Costo) VALUES(");
                    Sentencia.Append("'Impresión de partida de divorcio'," + _idPartida + ",(SELECT Monto FROM registro_familiar.costos where idTipo_partida=4));");
                    break;
                case 7:
                    Sentencia.Append("INSERT INTO operaciones(Tipo, idPartida_defuncion, Costo) VALUES(");
                    Sentencia.Append("'Nueva partida de defunción',(SELECT idpartidas_defuncion FROM registro_familiar.partidas_defuncion order by idpartidas_defuncion desc limit 1),0);");
                    break;
                case 8:
                    Sentencia.Append("INSERT INTO operaciones(Tipo, idPartida_defuncion, Costo) VALUES(");
                    Sentencia.Append("'Impresión de partida de defunción'," + _idPartida + ",(SELECT Monto FROM registro_familiar.costos where idTipo_partida=3));");
                    break;
                default:
                    Sentencia.Append("INSERT INTO operaciones(Tipo, idPartida, Costo) VALUES(");
                    break;

            }            

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

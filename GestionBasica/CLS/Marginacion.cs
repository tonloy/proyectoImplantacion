using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Marginacion
    {
        SessionManager.MarginarPartida _Datos = SessionManager.MarginarPartida.Instancia;
        String _idMarginacion;
        String _NumPartida;
        String _Explicacion;
        String _idJefe;

        public String IdJefe
        {
            get { return _idJefe; }
            set { _idJefe = value; }
        }

        public String Explicacion
        {
            get { return _Explicacion; }
            set { _Explicacion = value; }
        }

        public String NumPartida
        {
            get { return _NumPartida; }
            set { _NumPartida = value; }
        }


        public String IdMarginacion
        {
            get { return _idMarginacion; }
            set { _idMarginacion = value; }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia1 = new StringBuilder();
            StringBuilder Sentencia2 = new StringBuilder();
            StringBuilder Sentencia3 = new StringBuilder();

            Sentencia1.Append("UPDATE partidas_nacimiento SET Hora_sentencia='"+_Datos.HoraSentencia+"', Fecha_sentencia='"+_Datos.FechaSentencia+"', idJuzgado='"+_Datos.IdJuzgado+"', Modificada='1' WHERE idPartida='"+_Datos.IdPartidaVieja+"';");

            Sentencia2.Append("INSERT INTO partidas_nacimiento(idMadre, idPadre, idInformante, idJefeRegistro, Tomo, idInfante, Libro, NumPartida, Ruta, idTipo_partida,Modificada,Tomo_letras,Libro_letras,NumPartida_letras,Anio_insercion_letras) VALUES(");
            Sentencia2.Append(_Datos.IdMadre + ",");
            Sentencia2.Append(_Datos.IdPadre + ",");
            Sentencia2.Append(_Datos.IdInformante + ",");
            Sentencia2.Append("(select idEmpleado from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo)" + ",");
            Sentencia2.Append(_Datos.Tomo + ",");
            Sentencia2.Append(_Datos.IdInfante + ",");
            Sentencia2.Append(_Datos.Libro + ",");
            Sentencia2.Append(_Datos.NumPartida + ",\'");
            Sentencia2.Append(_Datos.Ruta + "',");
            Sentencia2.Append("1,0,'" + _Datos.Tomo_letras + "','" + _Datos.Libro_letras + "','" + _Datos.NumPartida_letras + "','"+_Datos.AnioInsercionLetras+"');");

            Sentencia3.Append("INSERT INTO marginaciones(idPartida,Explicacion,idJefe) VALUES(");
            Sentencia3.Append(_NumPartida+",'");
            Sentencia3.Append(_Explicacion + "',");
            Sentencia3.Append("(select idEmpleado from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo));");
            

            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            {
                if (oOperacion.Transaccion(Sentencia1.ToString(), Sentencia2.ToString(), Sentencia3.ToString()) > 2)
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

        public Boolean GuardarDefuncion()
        {
            Boolean guardado = false;
            StringBuilder Sentencia1 = new StringBuilder();
            StringBuilder Sentencia2 = new StringBuilder();
            StringBuilder Sentencia3 = new StringBuilder();

            Sentencia1.Append("UPDATE partidas_defuncion SET Hora_sentencia='" + _Datos.HoraSentencia + "', Fecha_sentencia='" + _Datos.FechaSentencia + "', idJuzgado='" + _Datos.IdJuzgado + "', Modificada='1' WHERE idpartidas_defuncion='" + _Datos.IdPartidaVieja + "';");

            Sentencia2.Append("UPDATE padres SET Estado='Viva' where idPadre="+_Datos.IdInfante+";");
            
            Sentencia3.Append("INSERT INTO marginaciones(Explicacion,idJefe,idPartidaDef) VALUES('");
            Sentencia3.Append(_Explicacion + "',");
            Sentencia3.Append("(select idEmpleado from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo),"+_Datos.IdPartidaVieja+");");


            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            {
                if (oOperacion.Transaccion(Sentencia1.ToString(), Sentencia2.ToString(), Sentencia3.ToString()) > 2)
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.CLS
{
    class PartidaNac
    {
        String Fecha_insercion_letras;

        public String Fecha_insercion_letras1
        {
            get { return Fecha_insercion_letras; }
            set { Fecha_insercion_letras = value; }
        }
        String Anio_insercion_letras;

        public String Anio_insercion_letras1
        {
            get { return Anio_insercion_letras; }
            set { Anio_insercion_letras = value; }
        }

        String _Tomo_letras;

        public String Tomo_letras
        {
            get { return _Tomo_letras; }
            set { _Tomo_letras = value; }
        }
        String _Libro_letras;

        public String Libro_letras
        {
            get { return _Libro_letras; }
            set { _Libro_letras = value; }
        }
        String _NumPartida_letras;

        public String NumPartida_letras
        {
            get { return _NumPartida_letras; }
            set { _NumPartida_letras = value; }
        }

        String _idPartida;

        public String IdPartida
        {
            get { return _idPartida; }
            set { _idPartida = value; }
        }
        String _idMadre;

        public String IdMadre
        {
            get { return _idMadre; }
            set { _idMadre = value; }
        }
        String _idPadre;

        public String IdPadre
        {
            get { return _idPadre; }
            set { _idPadre = value; }
        }
        String _idInformante;

        public String IdInformante
        {
            get { return _idInformante; }
            set { _idInformante = value; }
        }
        String _idJefeRegistro;

        public String IdJefeRegistro
        {
            get { return _idJefeRegistro; }
            set { _idJefeRegistro = value; }
        }
        String _Tomo;

        public String Tomo
        {
            get { return _Tomo; }
            set { _Tomo = value; }
        }
        String _idInfante;

        public String IdInfante
        {
            get { return _idInfante; }
            set { _idInfante = value; }
        }
        String _Libro;

        public String Libro
        {
            get { return _Libro; }
            set { _Libro = value; }
        }
        String _NumPartida;

        public String NumPartida
        {
            get { return _NumPartida; }
            set { _NumPartida = value; }
        }
        String _Hora_sentencia;

        public String Hora_sentencia
        {
            get { return _Hora_sentencia; }
            set { _Hora_sentencia = value; }
        }
        String _Fecha_sentencia;

        public String Fecha_sentencia
        {
            get { return _Fecha_sentencia; }
            set { _Fecha_sentencia = value; }
        }
        String _idJuzgado;

        public String IdJuzgado
        {
            get { return _idJuzgado; }
            set { _idJuzgado = value; }
        }
        String _Ruta;

        public String Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }
        String _idTipo_partida;

        public String IdTipo_partida
        {
            get { return _idTipo_partida; }
            set { _idTipo_partida = value; }
        }
        String _Modificada;

        public String Modificada
        {
            get { return _Modificada; }
            set { _Modificada = value; }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO partidas_nacimiento(idMadre, idPadre, idInformante, idJefeRegistro, Tomo, idInfante, Libro, NumPartida, Ruta, idTipo_partida,Modificada,Tomo_letras,Libro_letras,NumPartida_letras,Anio_insercion_letras,Fecha_insercion_letras) VALUES(");
            Sentencia.Append(_idMadre + ",");
            Sentencia.Append(_idPadre + ",");
            Sentencia.Append(_idInformante + ",");
            Sentencia.Append("(select idEmpleado from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo)" + ",");
            Sentencia.Append(_Tomo + ",");
            Sentencia.Append(_idInfante + ",");
            Sentencia.Append(_Libro + ",");
            Sentencia.Append(_NumPartida + ",\'");
            Sentencia.Append(_Ruta + "',");
            Sentencia.Append("1,0,'"+_Tomo_letras+"','"+_Libro_letras+"','"+_NumPartida_letras+"','"+Anio_insercion_letras+"','"+Fecha_insercion_letras1+"');");

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

            Sentencia.Append("update registro_familiar.partidas_nacimiento set Ruta = '"+_Ruta+"'");
            Sentencia.Append(" where idPartida="+_idPartida);
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
    }
}

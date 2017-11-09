using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class PartidaDef
    {
        String idpartidas_defuncion;
        String NumPartida;
        String idFallecido;
        String idConyuge;
        String Lugar_fallecimiento;
        String Fecha_fallecimiento;
        String Hora_fallecimiento;
        String Causa_muerte;
        String Asistencia_medica;
        String idProfesional;
        String Sentencia_ruta;
        String idPadre;
        String idMadre;
        String idTipo_partida;
        String Imagen;
        String idTestigo1;
        String idTestigo2;
        String Libro;
        String Folio;
        String Libro_letras;
        String Folio_letras;
        String Fecha_insercion;
        String Fecha_insercion_letras;
        String NumPartida_letras;
        String idInformante;
        String idJefeRegistro;
        String Modificada;
        String Anio_insercion_letras;
        String Fecha_fallecimiento_letras;
        String Hora_fallecimiento_letras;

        public string Anio_insercion_letras1
        {
            get
            {
                return Anio_insercion_letras;
            }

            set
            {
                Anio_insercion_letras = value;
            }
        }

        public string Modificada1
        {
            get
            {
                return Modificada;
            }

            set
            {
                Modificada = value;
            }
        }

        public string IdJefeRegistro
        {
            get
            {
                return idJefeRegistro;
            }

            set
            {
                idJefeRegistro = value;
            }
        }

        public string IdInformante
        {
            get
            {
                return idInformante;
            }

            set
            {
                idInformante = value;
            }
        }

        public string NumPartida_letras1
        {
            get
            {
                return NumPartida_letras;
            }

            set
            {
                NumPartida_letras = value;
            }
        }

        public string Fecha_insercion_letras1
        {
            get
            {
                return Fecha_insercion_letras;
            }

            set
            {
                Fecha_insercion_letras = value;
            }
        }

        public string Fecha_insercion1
        {
            get
            {
                return Fecha_insercion;
            }

            set
            {
                Fecha_insercion = value;
            }
        }

        public string Folio_letras1
        {
            get
            {
                return Folio_letras;
            }

            set
            {
                Folio_letras = value;
            }
        }

        public string Libro_letras1
        {
            get
            {
                return Libro_letras;
            }

            set
            {
                Libro_letras = value;
            }
        }

        public string Folio1
        {
            get
            {
                return Folio;
            }

            set
            {
                Folio = value;
            }
        }

        public string Libro1
        {
            get
            {
                return Libro;
            }

            set
            {
                Libro = value;
            }
        }

        public string IdTestigo2
        {
            get
            {
                return idTestigo2;
            }

            set
            {
                idTestigo2 = value;
            }
        }

        public string IdTestigo1
        {
            get
            {
                return idTestigo1;
            }

            set
            {
                idTestigo1 = value;
            }
        }

        public string Imagen1
        {
            get
            {
                return Imagen;
            }

            set
            {
                Imagen = value;
            }
        }

        public string IdTipo_partida
        {
            get
            {
                return idTipo_partida;
            }

            set
            {
                idTipo_partida = value;
            }
        }

        public string IdMadre
        {
            get
            {
                return idMadre;
            }

            set
            {
                idMadre = value;
            }
        }

        public string IdPadre
        {
            get
            {
                return idPadre;
            }

            set
            {
                idPadre = value;
            }
        }

        public string Sentencia_ruta1
        {
            get
            {
                return Sentencia_ruta;
            }

            set
            {
                Sentencia_ruta = value;
            }
        }

        public string IdProfesional
        {
            get
            {
                return idProfesional;
            }

            set
            {
                idProfesional = value;
            }
        }

        public string Asistencia_medica1
        {
            get
            {
                return Asistencia_medica;
            }

            set
            {
                Asistencia_medica = value;
            }
        }

        public string Causa_muerte1
        {
            get
            {
                return Causa_muerte;
            }

            set
            {
                Causa_muerte = value;
            }
        }

        public string Hora_fallecimiento1
        {
            get
            {
                return Hora_fallecimiento;
            }

            set
            {
                Hora_fallecimiento = value;
            }
        }

        public string Fecha_fallecimiento1
        {
            get
            {
                return Fecha_fallecimiento;
            }

            set
            {
                Fecha_fallecimiento = value;
            }
        }

        public string Lugar_fallecimiento1
        {
            get
            {
                return Lugar_fallecimiento;
            }

            set
            {
                Lugar_fallecimiento = value;
            }
        }

        public string IdConyuge
        {
            get
            {
                return idConyuge;
            }

            set
            {
                idConyuge = value;
            }
        }

        public string IdFallecido
        {
            get
            {
                return idFallecido;
            }

            set
            {
                idFallecido = value;
            }
        }

        public string NumPartida1
        {
            get
            {
                return NumPartida;
            }

            set
            {
                NumPartida = value;
            }
        }

        public string Idpartidas_defuncion
        {
            get
            {
                return idpartidas_defuncion;
            }

            set
            {
                idpartidas_defuncion = value;
            }
        }

        public string Fecha_fallecimiento_letras1
        {
            get
            {
                return Fecha_fallecimiento_letras;
            }

            set
            {
                Fecha_fallecimiento_letras = value;
            }
        }

        public string Hora_fallecimiento_letras1
        {
            get
            {
                return Hora_fallecimiento_letras;
            }

            set
            {
                Hora_fallecimiento_letras = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO partidas_defuncion(NumPartida, idFallecido, idConyuge, Lugar_fallecimiento, Fecha_fallecimiento, Hora_fallecimiento, Causa_muerte, Asistencia_medica, idProfesional, idPadre, idMadre, idTipo_partida, Imagen, idTestigo1, idTestigo2, Libro, Folio, Libro_letras, Folio_letras, Fecha_insercion_letras, NumPartida_letras, idInformante, idJefeRegistro, Modificada, Anio_insercion_letras,Fecha_fallecimiento_letras,Hora_fallecimiento_letras) VALUES(");
            Sentencia.Append(NumPartida + ",");
            Sentencia.Append(idFallecido + ",");
            Sentencia.Append(idConyuge + ",");
            Sentencia.Append(Lugar_fallecimiento + ",'");
            Sentencia.Append(Fecha_fallecimiento + "','");
            Sentencia.Append(Hora_fallecimiento + "',");
            Sentencia.Append(Causa_muerte + ",'");
            Sentencia.Append(Asistencia_medica + "',");
            Sentencia.Append(idProfesional + ",");
            Sentencia.Append(idPadre + ",");
            Sentencia.Append(idMadre + ",");
            Sentencia.Append("3,\'");
            Sentencia.Append(Imagen + "',");
            Sentencia.Append(idTestigo1 + ",");
            Sentencia.Append(idTestigo2 + ",'");
            Sentencia.Append(Libro + "','");
            Sentencia.Append(Folio + "','");
            Sentencia.Append(Libro_letras + "','");
            Sentencia.Append(Folio_letras + "','");
            Sentencia.Append(Fecha_insercion_letras + "','");
            Sentencia.Append(NumPartida_letras + "',");
            Sentencia.Append(idInformante + ",");
            Sentencia.Append("(select idEmpleado from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo)" + ",");
            Sentencia.Append("0,'");
            Sentencia.Append(Anio_insercion_letras + "','"+Fecha_fallecimiento_letras1+"','"+Hora_fallecimiento_letras1+"');");

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

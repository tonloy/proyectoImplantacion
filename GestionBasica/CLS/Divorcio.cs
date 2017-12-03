using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Divorcio
    {
        String idDivorcio;
        String NumPartida;
        String idMatrimonio;
        String idJuzgado;
        String Fecha_sentencia;
        String Fecha_ejecutoriada;
        String idTipo_partida;
        String Imagen;
        String Libro;
        String Folio;
        String NumActa_letras;
        String Libro_letras;
        String Folio_letras;
        String Tutela;
        String NombreNotario;
        String Revisado;

        public string Revisado1
        {
            get
            {
                return Revisado;
            }

            set
            {
                Revisado = value;
            }
        }

        public string NombreNotario1
        {
            get
            {
                return NombreNotario;
            }

            set
            {
                NombreNotario = value;
            }
        }

        public string Tutela1
        {
            get
            {
                return Tutela;
            }

            set
            {
                Tutela = value;
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

        public string NumActa_letras1
        {
            get
            {
                return NumActa_letras;
            }

            set
            {
                NumActa_letras = value;
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

        public string Fecha_ejecutoriada1
        {
            get
            {
                return Fecha_ejecutoriada;
            }

            set
            {
                Fecha_ejecutoriada = value;
            }
        }

        public string Fecha_sentencia1
        {
            get
            {
                return Fecha_sentencia;
            }

            set
            {
                Fecha_sentencia = value;
            }
        }

        public string IdJuzgado
        {
            get
            {
                return idJuzgado;
            }

            set
            {
                idJuzgado = value;
            }
        }

        public string IdMatrimonio
        {
            get
            {
                return idMatrimonio;
            }

            set
            {
                idMatrimonio = value;
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

        public string IdDivorcio
        {
            get
            {
                return idDivorcio;
            }

            set
            {
                idDivorcio = value;
            }
        }

        public Boolean Guardar(int _revisado)
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO divorcios(NumPartida, idMatrimonio, idJuzgado, Fecha_sentencia, Fecha_ejecutoriada, idTipo_partida, Imagen, Libro, Folio, NumActa_letras, Libro_letras, Folio_letras, Tutela, NombreNotario, Revisado) VALUES(");
            Sentencia.Append(NumPartida + ",");
            Sentencia.Append(idMatrimonio + ",");
            Sentencia.Append(idJuzgado + ",'");
            Sentencia.Append(Fecha_sentencia + "','");
            Sentencia.Append(Fecha_ejecutoriada + "',");
            Sentencia.Append("4,'");
            Sentencia.Append(Imagen + "','");
            Sentencia.Append(Libro + "','");
            Sentencia.Append(Folio + "','");
            Sentencia.Append(NumActa_letras + "','");
            Sentencia.Append(Libro_letras + "','");
            Sentencia.Append(Folio_letras+"','");
            Sentencia.Append(Tutela + "','");
            Sentencia.Append(NombreNotario + "',");
            Sentencia.Append(_revisado + ");");

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

        public Boolean Modificar(int _revisado)
        {
            Boolean modificado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("UPDATE divorcios set NumPartida=");
            Sentencia.Append(NumPartida + ", idMatrimonio=");
            Sentencia.Append(idMatrimonio + ", idJuzgado=");
            Sentencia.Append(idJuzgado + ", Fecha_sentencia='");
            Sentencia.Append(Fecha_sentencia + "', Fecha_ejecutoriada='");
            Sentencia.Append(Fecha_ejecutoriada + "', Imagen='");
            Sentencia.Append(Imagen + "', Libro='");
            Sentencia.Append(Libro + "', Folio='");
            Sentencia.Append(Folio + "', NumActa_letras='");
            Sentencia.Append(NumActa_letras + "', Libro_letras='");
            Sentencia.Append(Libro_letras + "', Folio_letras='");
            Sentencia.Append(Folio_letras + "', Tutela='");
            Sentencia.Append(Tutela + "', NombreNotario='");
            Sentencia.Append(NombreNotario + "', Revisado=");
            Sentencia.Append(_revisado + " where idDivorcio="+idDivorcio+";");
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

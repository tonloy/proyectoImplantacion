using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager
{
    public sealed class MarginarPartida
    {
        private static volatile MarginarPartida _Instancia = null;
        private static object Bloqueador = new Object();

        String _idPartidaVieja;

        public String IdPartidaVieja
        {
            get { return _idPartidaVieja; }
            set { _idPartidaVieja = value; }
        }
        String _idJuzgado;

        public String IdJuzgado
        {
            get { return _idJuzgado; }
            set { _idJuzgado = value; }
        }
        String _fechaSentencia;

        public String FechaSentencia
        {
            get { return _fechaSentencia; }
            set { _fechaSentencia = value; }
        }
        String _horaSentencia;

        public String HoraSentencia
        {
            get { return _horaSentencia; }
            set { _horaSentencia = value; }
        }
        String _Folio;

        public String Folio
        {
            get { return _Folio; }
            set { _Folio = value; }
        }
        String _Libro;

        public String Libro
        {
            get { return _Libro; }
            set { _Libro = value; }
        }
        String _idInfante;

        public String IdInfante
        {
            get { return _idInfante; }
            set { _idInfante = value; }
        }
        String _Infante;

        public String Infante
        {
            get { return _Infante; }
            set { _Infante = value; }
        }
        String _idMadre;

        public String IdMadre
        {
            get { return _idMadre; }
            set { _idMadre = value; }
        }
        String _Madre;

        public String Madre
        {
            get { return _Madre; }
            set { _Madre = value; }
        }
        String _idPadre;

        public String IdPadre
        {
            get { return _idPadre; }
            set { _idPadre = value; }
        }
        String _Padre;

        public String Padre
        {
            get { return _Padre; }
            set { _Padre = value; }
        }
        String _idInformante;

        public String IdInformante
        {
            get { return _idInformante; }
            set { _idInformante = value; }
        }
        String _Informante;

        public String Informante
        {
            get { return _Informante; }
            set { _Informante = value; }
        }
        String _Ruta;

        public String Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }

        private MarginarPartida() { }

        public static MarginarPartida Instancia
        {
            get{
                if(_Instancia==null){
                    lock(Bloqueador){
                        if(_Instancia==null)
                            _Instancia=new MarginarPartida();
                    }
                }
                return MarginarPartida._Instancia;
            }
        }
    }
}

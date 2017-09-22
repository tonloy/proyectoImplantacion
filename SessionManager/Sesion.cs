using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager
{
    public sealed class Sesion
    {
        private static volatile Sesion _Instancia = null;
        private static object Bloqueador = new Object();

        String _Usuario;
        String _IdUsuario;
        String _Nombres;
        String _Apellidos;
        String _IDGrupo;
        String _Grupo;
        String _IDEmpleado;

        public String IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public String Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public String Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }

        public String IDGrupo
        {
            get { return _IDGrupo; }
            set { _IDGrupo = value; }
        }

        public String Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }

        public String IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }

        private Sesion() { }

        public static Sesion Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    lock (Bloqueador)
                    {
                        if (_Instancia == null)
                            _Instancia = new Sesion();
                    }
                }
                return Sesion._Instancia;
            }
        }
    }
}

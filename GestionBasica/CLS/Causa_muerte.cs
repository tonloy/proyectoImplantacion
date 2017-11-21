using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Causa_muerte
    {
        String _idCausa;
        String _Causa;

        public string IdCausa
        {
            get
            {
                return _idCausa;
            }

            set
            {
                _idCausa = value;
            }
        }

        public string Causa
        {
            get
            {
                return _Causa;
            }

            set
            {
                _Causa = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO causas_muerte(Causa) VALUES('");
            Sentencia.Append(_Causa + "');");

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

            Sentencia.Append("UPDATE causas_muerte set Causa=");
            Sentencia.Append("'" + _Causa + "' where idCausa=");
            Sentencia.Append(_idCausa + " ;");

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
        public Boolean Eliminar()
        {
            Boolean eliminado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("delete from causas_muerte where idCausa=" + _idCausa + ";");

            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            {
                if (oOperacion.Eliminar(Sentencia.ToString()) > 0)
                {
                    eliminado = true;
                }
                else
                {
                    eliminado = false;
                }
            }
            catch
            {
                eliminado = false;
            }
            return eliminado;
        }
    }
}

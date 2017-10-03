using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBasica.CLS
{
    class Marginacion
    {
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
    }
}

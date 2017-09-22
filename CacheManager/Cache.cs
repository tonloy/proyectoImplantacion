
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager
{
    public static class Cache
    {
        public static DataTable DATOS_USUARIO(String pUsuario, String pCredencial)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT a.idUsuario,a.Usuario,a.Credencial,a.idEmpleado,e.NombreCompleto,a.idRol,g.Rol FROM usuarios a,empleados e,roles g WHERE a.idEmpleado=e.idEmpleado AND a.idRol=g.idRol AND a.Usuario='" + pUsuario + "' AND a.Credencial=md5('" + pCredencial + "')";
            DataLayer1.OperacionBD oOperacion = new DataLayer1.OperacionBD();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }
    }
}

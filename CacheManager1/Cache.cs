using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager1
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

        public static DataTable TODAS_LAS_PARTIDAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idPartida,
             p.idMadre,
             ma.NombreCompleto as madre,
             p.idPadre,
             pa.NombreCompleto as padre,
             inf.idInformante,
             inf.NombreCompleto as informante,
             idJefeRegistro,
             Folio,
             i.idInfante,
             i.NombreCompleto as infante,
            i.FechaNac,
             Libro,
             NumPartida,
             Ruta,
             t.idTipo_partida,
             Modificada FROM
             partidas_nacimiento p,
             padres pa,
             padres ma,
             informantes inf,
             infantes i,
             empleados e,
             tipo_partidas t where p.idInfante=i.idInfante and p.idPadre=pa.idPadre and p.idMadre=ma.idPadre and p.idJefeRegistro=e.idEmpleado and p.idTipo_partida=t.idTipo_partida
             and p.idInformante=inf.idInformante;";
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

        public static DataTable TODAS_LAS_PARTIDAS(String fecha)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idPartida,
             p.idMadre,
             ma.NombreCompleto as madre,
             p.idPadre,
             pa.NombreCompleto as padre,
             inf.idInformante,
             inf.NombreCompleto as informante,
             idJefeRegistro,
             Folio,
             i.idInfante,
             i.NombreCompleto as infante,
            i.FechaNac,
             Libro,
             NumPartida,
             Ruta,
             t.idTipo_partida,
             Modificada FROM
             partidas_nacimiento p,
             padres pa,
             padres ma,
             informantes inf,
             infantes i,
             empleados e,
             tipo_partidas t where p.idInfante=i.idInfante and p.idPadre=pa.idPadre and p.idMadre=ma.idPadre and p.idJefeRegistro=e.idEmpleado and p.idTipo_partida=t.idTipo_partida
             and p.idInformante=inf.idInformante and (i.NombreCompleto like '%"+fecha+"%' or i.FechaNac like '%"+fecha+"%');";
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
        public static DataTable TODOS_LOS_INFANTES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT idInfante, NombreCompleto, LugarNac, Sexo, Hora, FechaNac FROM registro_familiar.infantes;";
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
        public static DataTable TODOS_LOS_PADRES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idPadre, NombreCompleto, ConocidoPor, Edad, Domicilio, Nacionalidad, DUI, p.idMunicipio,m.Municipio, Profesion 
                        FROM registro_familiar.padres p, municipios m
                        where p.idMunicipio = m.idMunicipio; ";
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
        public static DataTable TODOS_LOS_INFORMANTES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT idInformante, NombreCompleto, ConocidoPor, FechaInscripcion, Observaciones, DUI, i.idParentesco,p.Parentesco FROM registro_familiar.informantes i,parentescos p where i.idParentesco=p.idParentesco;";
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

        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT idEmpleado,NombreCompleto,Cargo,c.idCargo from Empleados e,Cargos c where e.idCargo=c.idCargo order by NombreCompleto asc";
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

        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT idUsuario, Usuario,Credencial,e.idEmpleado,NombreCompleto,r.idRol, Rol, u.FechaCreacion FROM usuarios u,empleados e,roles r where r.idRol=u.idRol and e.idEmpleado=u.idEmpleado order by Usuario asc;";
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

        public static DataTable TODOS_LOS_CARGOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT idCargo,Cargo from Cargos";
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

        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT idRol, Rol, FechaCreacion FROM roles;";
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

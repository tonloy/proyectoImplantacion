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
            Consulta = "SELECT a.idUsuario,a.Usuario,a.Credencial,a.idEmpleado,e.NombreCompleto,a.idRol,g.Rol FROM usuarios a,empleados e,roles g WHERE a.idEmpleado=e.idEmpleado AND a.idRol=g.idRol AND binary a.Usuario='" + pUsuario + "' AND a.Credencial=md5('" + pCredencial + "')";
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

        public static DataTable TODAS_LAS_PARTIDAS_DEFUNCION()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idpartidas_defuncion, 
                        p.NumPartida, 
                        idFallecido, 
                        fa.NombreCompleto as Fallecido,
                        fa.edad,
                        idConyuge, 
                        (select NombreCompleto from padres v where v.idPadre=idConyuge)as Conyuge,
                        Lugar_fallecimiento, 
                        m.Municipio,
                        Fecha_fallecimiento, 
                        Hora_fallecimiento, 
                        Causa_muerte,
                        (select Causa from causas_muerte where idCausa=Causa_muerte) as Causa, 
                        Asistencia_medica,
                        p.idPadre, 
                        (select NombreCompleto from padres where idPadre=p.idPadre) as Padre,
                        p.idMadre, 
                        (select NombreCompleto from padres where idPadre=p.idMadre) as Madre,
                        idProfesional,
                        (select NombreCompleto from padres where idPadre=p.idProfesional) as Profesional,
                        Imagen, 
                        idTestigo1, 
                        tes1.NombreCompleto as Testigo1,
                        idTestigo2, 
                        tes2.NombreCompleto as Testigo2,
                        t.idTipo_partida,
                        Libro, 
                        Folio, 
                        idInformante, 
                        inf.NombreCompleto as Informante,
                        idJefeRegistro,
                        Modificada FROM registro_familiar.partidas_defuncion p, padres fa,municipios m,
                        padres inf,padres tes1,padres tes2,tipo_partidas t,
                        empleados e where p.idFallecido=fa.idPadre and p.idInformante=inf.idPadre
                        and p.idJefeRegistro=e.idEmpleado and p.idTestigo1=tes1.idPadre
                        and p.idTestigo2=tes2.idPadre and p.idTipo_partida=t.idTipo_partida and p.Lugar_fallecimiento=m.idMunicipio and Modificada=0;";
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
             p.Ruta,
             p.idMadre,
             ma.NombreCompleto as madre,
             p.idPadre,
             pa.NombreCompleto as padre,
             inf.idPadre as IdInformante,
             inf.NombreCompleto as informante,
             idJefeRegistro,
             Tomo,
             i.idPadre as idInfante,
             i.NombreCompleto as infante,
            i.FechaNac,
             Libro,
             p.NumPartida,
             Ruta,
             t.idTipo_partida,
             Modificada FROM
             partidas_nacimiento p,
             padres pa,
             padres ma,
             padres inf,
             padres i,
             empleados e,
             tipo_partidas t where p.idInfante=i.idPadre and p.idPadre=pa.idPadre and p.idMadre=ma.idPadre and p.idJefeRegistro=e.idEmpleado and p.idTipo_partida=t.idTipo_partida
             and p.idInformante=inf.idPadre and Modificada=0;";
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

        public static DataTable TODAS_LAS_PARTIDAS(Int32 pidPartida)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idPartida, ma.idPadre as idMadre, pa.idPadre, inf.idPadre as idInformante, idJefeRegistro, Tomo_letras,
             i.idPadre as idInfante, Libro_letras, NumPartida_letras, Hora_sentencia, Fecha_sentencia, idJuzgado,
             Ruta, idTipo_partida, Modificada, p.Fecha_insercion_letras,Anio_insercion_letras as Anio_insercion,ma.NombreCompleto as Madre,pa.NombreCompleto as Padre,
             inf.NombreCompleto as Informante,i.NombreCompleto as Infante,i.Sexo, i.FechaNac_letras,i.Hora_letras,
             (select Municipio from municipios where idMunicipio=i.LugarNac) as LugarNac,
             (select Profesion from profesiones where idProfesion=ma.Profesion) as ProfesionMadre,(select Profesion from profesiones where idProfesion=pa.Profesion) as ProfesionPadre,
             (select concat(Municipio,(', '),Departamento) from municipios mu,departamentos de where mu.idDepartamento=de.idDepartamento and mu.idMunicipio=ma.idMunicipio) as MadreOrigen,
             (select concat(Municipio,(', '),Departamento) from municipios mu,departamentos de where mu.idDepartamento=de.idDepartamento and mu.idMunicipio=pa.idMunicipio) as PadreOrigen,
             (select Nacionalidad from paises where idPais=ma.Nacionalidad) as NacionalidadMadre,
             (select Nacionalidad from paises where idPais=pa.Nacionalidad) as NacionalidadPadre,
             (select Parentesco from parentescos where idParentesco=inf.idParentesco) as InformanteParen,
             ma.Dui_letras as DuiMadre,pa.Dui_letras as DuiPadre,inf.Dui_letras as DuiInformante,ma.Edad_letras as EdadMadre,pa.Edad_letras as EdadPadre,
             ma.Domicilio as DomicilioMadre, pa.Domicilio as DomicilioPadre,
             (select NombreCompleto from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo) as JefeRegistro FROM registro_familiar.partidas_nacimiento p, padres pa,
             padres ma,padres inf, padres i where p.idInfante=i.idPadre and
             p.idInformante=inf.idPadre and p.idPadre=pa.idPadre and p.idMadre=ma.idPadre and idPartida=" + pidPartida+";";
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
             inf.idPadre,
             inf.NombreCompleto as informante,
             idJefeRegistro,
             Tomo,
             i.idPadre as idInfante,
             i.NombreCompleto as infante,
            i.FechaNac,
             Libro,
             p.NumPartida,
             Ruta,
             t.idTipo_partida,
             Modificada FROM
             partidas_nacimiento p,
             padres pa,
             padres ma,
             padres inf,
             padres i,
             empleados e,
             tipo_partidas t where p.idInfante=i.idPadre and p.idPadre=pa.idPadre and p.idMadre=ma.idPadre and p.idJefeRegistro=e.idEmpleado and p.idTipo_partida=t.idTipo_partida
             and p.idInformante=inf.idPadre and Modificada=0 and (i.NombreCompleto like '%" + fecha + "%' or i.FechaNac like '%" + fecha + "%');";
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

        public static DataTable TODAS_LAS_PARTIDAS_DEFUNCION(String fecha)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idpartidas_defuncion, 
                        p.NumPartida, 
                        idFallecido, 
                        fa.NombreCompleto as Fallecido,
                        fa.edad,
                        idConyuge, 
                        (select NombreCompleto from padres v where v.idPadre=idConyuge)as Conyuge,
                        Lugar_fallecimiento, 
                        m.Municipio,
                        Fecha_fallecimiento, 
                        Hora_fallecimiento, 
                        Causa_muerte,
                        (select Causa from causas_muerte where idCausa=Causa_muerte) as Causa, 
                        Asistencia_medica,
                        p.idPadre, 
                        (select NombreCompleto from padres where idPadre=p.idPadre) as Padre,
                        p.idMadre, 
                        (select NombreCompleto from padres where idPadre=p.idMadre) as Madre,
                        idProfesional,
                        (select NombreCompleto from padres where idPadre=p.idProfesional) as Profesional,
                        Imagen, 
                        idTestigo1, 
                        tes1.NombreCompleto as Testigo1,
                        idTestigo2, 
                        tes2.NombreCompleto as Testigo2,
                        t.idTipo_partida,
                        Libro, 
                        Folio, 
                        idInformante, 
                        inf.NombreCompleto as Informante,
                        idJefeRegistro,
                        Modificada FROM registro_familiar.partidas_defuncion p, padres fa,municipios m,
                        padres inf,padres tes1,padres tes2,tipo_partidas t,
                        empleados e where p.idFallecido=fa.idPadre and p.idInformante=inf.idPadre
                        and p.idJefeRegistro=e.idEmpleado and p.idTestigo1=tes1.idPadre
                        and p.idTestigo2=tes2.idPadre and p.idTipo_partida=t.idTipo_partida and p.Lugar_fallecimiento=m.idMunicipio and Modificada=0 and Fecha_fallecimiento like '%" + fecha + "%';";
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
            Consulta = @"SELECT idPadre as idInfante, NombreCompleto, LugarNac, Sexo, Hora, FechaNac, Revisado,dep.Departamento,m.Municipio FROM registro_familiar.padres p, municipios m, departamentos dep
                        where p.LugarNac = m.idMunicipio and dep.idDepartamento=m.idDepartamento;";
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
        public static DataTable TODOS_LOS_PARENTESCOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT idParentesco, Parentesco FROM registro_familiar.parentescos;";
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
            Consulta = @"SELECT idPadre, NombreCompleto, ConocidoPor, Edad, Domicilio, pa.Nacionalidad, DUI, dep.Departamento, p.idMunicipio,m.Municipio, pr.Profesion,ps.Parentesco,p.Observaciones, p.NumPartida 
                        FROM registro_familiar.padres p, municipios m, departamentos dep, profesiones pr, paises pa,parentescos ps 
                        where p.idMunicipio = m.idMunicipio and dep.idDepartamento=m.idDepartamento and p.Nacionalidad=pa.idPais and pr.idProfesion=p.Profesion and ps.idParentesco=p.idParentesco; ";
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
        public static DataTable TODOS_LOS_JUZGADOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT * FROM registro_familiar.juzgados;";
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


        public static DataTable TODOS_LOS_MUNICIPIOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT * FROM registro_familiar.municipios;";
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

        public static DataTable TODOS_LOS_DEPARTAMENTOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT * FROM registro_familiar.departamentos;";
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

        public static DataTable TODOS_LOS_PROFESIONES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT * FROM registro_familiar.profesiones;";
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
        public static DataTable TODOS_LOS_PAISES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT * FROM registro_familiar.paises;";
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

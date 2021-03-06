﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager1
{
    public static class Cache
    {
        public static DataTable TODAS_LAS_PARTIDAS_DEFUNCION_MARGINADAS(String fecha)
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
                        c.Canton,
                        m.Municipio,                        
                        dep.Departamento,
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
                        Modificada FROM registro_familiar.partidas_defuncion p, padres fa,municipios m,cantones c,departamentos dep,
                        padres inf,padres tes1,padres tes2,tipo_partidas t,
                        empleados e where p.idFallecido=fa.idPadre and p.idInformante=inf.idPadre
                        and p.idJefeRegistro=e.idEmpleado and p.idTestigo1=tes1.idPadre
                        and p.idTestigo2=tes2.idPadre and p.idTipo_partida=t.idTipo_partida and p.Lugar_fallecimiento=c.idCanton and dep.idDepartamento=m.idDepartamento and c.idMunicipio=m.idMunicipio and Modificada=1 and Fecha_fallecimiento like '%" + fecha + "%';";
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

        public static DataTable TODAS_LAS_PARTIDAS_DEFUNCION_MARGINADAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idpartidas_defuncion, 
                        p.NumPartida, 
                        idFallecido, 
                        fa.NombreCompleto as Fallecido,
                        fa.edad,
                        fa.DUI as Dui_difunto,
                        idConyuge, 
                        (select NombreCompleto from padres v where v.idPadre=idConyuge)as Conyuge,
                        Lugar_fallecimiento, 
                        c.Canton,
                        m.Municipio,
                        dep.Departamento,
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
                        idJefeRegistro,p.Revisado,
                        Modificada FROM registro_familiar.partidas_defuncion p, padres fa,municipios m,departamentos dep,cantones c,
                        padres inf,padres tes1,padres tes2,tipo_partidas t,
                        empleados e where p.idFallecido=fa.idPadre and p.idInformante=inf.idPadre
                        and p.idJefeRegistro=e.idEmpleado and p.idTestigo1=tes1.idPadre
                        and p.idTestigo2=tes2.idPadre and p.idTipo_partida=t.idTipo_partida and p.Lugar_fallecimiento=c.idCanton and Modificada=1 and dep.idDepartamento=m.idDepartamento and c.idMunicipio=m.idMunicipio;";
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

        public static DataTable TODAS_LAS_PARTIDAS_MARGINADAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT distinct p.idPartida,
             p.Ruta,
             p.idMadre,
             (select NombreCompleto from padres where idPadre=p.idMadre) as madre,
             (select Edad from padres where idPadre=p.idMadre) as Dui_madre,
             p.idPadre,
             (select NombreCompleto from padres where idPadre=p.idPadre) as padre,
             (select Edad from padres where idPadre=p.idPadre) as Dui_padre,
             inf.idPadre as IdInformante,
             (select NombreCompleto from padres where idPadre=p.idInformante) as informante,
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
             padres inf,
             padres i,
             empleados e,
             tipo_partidas t,
             marginaciones ma where p.idInfante=i.idPadre and p.idJefeRegistro=e.idEmpleado and p.idTipo_partida=t.idTipo_partida
             and p.idInformante=inf.idPadre and ma.idPartida=p.idPartida;";
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

        public static DataTable TODAS_LAS_PARTIDAS_MARGINADAS(String fecha)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idPartida,
             p.idMadre,
             (select NombreCompleto from padres where idPadre=p.idMadre) as madre,
             (select DUI from padres where idPadre=p.idMadre) as Dui_madre,
             p.idPadre,
             (select NombreCompleto from padres where idPadre=p.idPadre) as padre,
             (select DUI from padres where idPadre=p.idPadre) as Dui_madre,
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
             padres inf,
             padres i,
             empleados e,
             tipo_partidas t where p.idInfante=i.idPadre and p.idJefeRegistro=e.idEmpleado and p.idTipo_partida=t.idTipo_partida
             and p.idInformante=inf.idPadre and Modificada=1 and (i.NombreCompleto like '%" + fecha + "%' or i.FechaNac like '%" + fecha + "%');";
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
                        fa.DUI as Dui_difunto,
                        idConyuge, 
                        (select NombreCompleto from padres v where v.idPadre=idConyuge)as Conyuge,
                        Lugar_fallecimiento, 
                        c.Canton,
                        m.Municipio,
                        dep.Departamento,
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
                        idJefeRegistro,p.Revisado,
                        Modificada FROM registro_familiar.partidas_defuncion p, padres fa,municipios m,departamentos dep,cantones c,
                        padres inf,padres tes1,padres tes2,tipo_partidas t,
                        empleados e where p.idFallecido=fa.idPadre and p.idInformante=inf.idPadre
                        and p.idJefeRegistro=e.idEmpleado and p.idTestigo1=tes1.idPadre
                        and p.idTestigo2=tes2.idPadre and p.idTipo_partida=t.idTipo_partida and p.Lugar_fallecimiento=c.idCanton and Modificada=0 and dep.idDepartamento=m.idDepartamento and c.idMunicipio=m.idMunicipio;";
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
             (select NombreCompleto from padres where idPadre=p.idMadre) as madre,
             (select Edad from padres where idPadre=p.idMadre) as Dui_madre,
             p.idPadre,
             (select NombreCompleto from padres where idPadre=p.idPadre) as padre,
             (select Edad from padres where idPadre=p.idPadre) as Dui_padre,
             inf.idPadre as IdInformante,
             (select NombreCompleto from padres where idPadre=p.idInformante) as informante,
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
             padres inf,
             padres i,
             empleados e,
             tipo_partidas t where p.idInfante=i.idPadre and p.idJefeRegistro=e.idEmpleado and p.idTipo_partida=t.idTipo_partida
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
            Consulta = @"SELECT idPartida, p.idMadre as idMadre, p.idPadre, inf.idPadre as idInformante, idJefeRegistro, Tomo_letras,
             i.idPadre as idInfante, Libro_letras, NumPartida_letras, Hora_sentencia, Fecha_sentencia, idJuzgado,
             Ruta, idTipo_partida, Modificada, p.Fecha_insercion_letras,Anio_insercion_letras as Anio_insercion,
             (select NombreCompleto from padres where idPadre=p.idMadre) as Madre,
             (select NombreCompleto from padres where idPadre=p.idPadre) as Padre,
             (select Rubrica from padres where idPadre=inf.idPadre) as InformanteRubrica,
             inf.NombreCompleto as Informante,i.NombreCompleto as Infante,i.Sexo, i.FechaNac_letras,i.Hora_letras,
             (select Municipio from municipios where idMunicipio=i.LugarNac) as LugarNac,
             (select s.Profesion from profesiones s,padres pv where idProfesion=pv.Profesion and pv.idPadre=p.idMadre) as ProfesionMadre,(select s.Profesion from profesiones s,padres px where idProfesion=px.Profesion and px.idPadre=p.idPadre) as ProfesionPadre,
             (select concat(Municipio,(', '),Departamento) from municipios mu,departamentos de,padres pd where mu.idDepartamento=de.idDepartamento and mu.idMunicipio=pd.idMunicipio and pd.idPadre=p.idMadre) as MadreOrigen,
             (select concat(Municipio,(', '),Departamento) from municipios mu,departamentos de,padres md where mu.idDepartamento=de.idDepartamento and mu.idMunicipio=md.idMunicipio and md.idPadre=p.idPadre) as PadreOrigen,
             (select sa.Nacionalidad from paises sa,padres ps where idPais=ps.Nacionalidad and ps.idPadre=p.idMadre) as NacionalidadMadre,
             (select sa.Nacionalidad from paises sa,padres pf where idPais=pf.Nacionalidad and pf.idPadre=p.idPadre) as NacionalidadPadre,
             (select Parentesco from parentescos where idParentesco=inf.idParentesco) as InformanteParen,
             (select Dui_letras from padres where idPadre=p.idMadre) as DuiMadre,(select Dui_letras from padres where idPadre=p.idPadre) as DuiPadre,inf.Dui_letras as DuiInformante,(select Edad_letras from padres where idPadre=p.idMadre) as EdadMadre,
             (select Edad_letras from padres where idPadre=p.idPadre) as EdadPadre,
             (select Domicilio from padres where idPadre=p.idMadre) as DomicilioMadre, (select Domicilio from padres where idPadre=p.idPadre) as DomicilioPadre,
             (select NombreCompleto from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo) as JefeRegistro,
             (select Rubrica from empleados where idEmpleado=p.idJefeRegistro) as Rubrica FROM registro_familiar.partidas_nacimiento p,
             padres inf, padres i where p.idInfante=i.idPadre and
             p.idInformante=inf.idPadre and idPartida=" + pidPartida + ";";
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

        public static DataTable TODAS_LAS_PARTIDAS2(Int32 pidPartida)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idPartida, p.idMadre as idMadre, p.idPadre, inf.idPadre as idInformante, idJefeRegistro, Tomo_letras,
             i.idPadre as idInfante, Libro_letras, NumPartida_letras, Hora_sentencia, Fecha_sentencia, idJuzgado,
             Ruta, idTipo_partida, Modificada, p.Fecha_insercion_letras,Anio_insercion_letras as Anio_insercion,
             (select NombreCompleto from padres where idPadre=p.idMadre) as Madre,
             (select NombreCompleto from padres where idPadre=p.idPadre) as Padre,
             (select Rubrica from padres where idPadre=inf.idPadre) as InformanteRubrica,
             inf.NombreCompleto as Informante,i.NombreCompleto as Infante,i.Sexo, i.FechaNac_letras,i.Hora_letras,
             (select Municipio from municipios where idMunicipio=i.LugarNac) as LugarNac,
             (select s.Profesion from profesiones s,padres pv where idProfesion=pv.Profesion and pv.idPadre=p.idMadre) as ProfesionMadre,(select s.Profesion from profesiones s,padres px where idProfesion=px.Profesion and px.idPadre=p.idPadre) as ProfesionPadre,
             (select concat(Municipio,(', '),Departamento) from municipios mu,departamentos de,padres pd where mu.idDepartamento=de.idDepartamento and mu.idMunicipio=pd.idMunicipio and pd.idPadre=p.idMadre) as MadreOrigen,
             (select concat(Municipio,(', '),Departamento) from municipios mu,departamentos de,padres md where mu.idDepartamento=de.idDepartamento and mu.idMunicipio=md.idMunicipio and md.idPadre=p.idPadre) as PadreOrigen,
             (select sa.Nacionalidad from paises sa,padres ps where idPais=ps.Nacionalidad and ps.idPadre=p.idMadre) as NacionalidadMadre,
             (select sa.Nacionalidad from paises sa,padres pf where idPais=pf.Nacionalidad and pf.idPadre=p.idPadre) as NacionalidadPadre,
             (select Parentesco from parentescos where idParentesco=inf.idParentesco) as InformanteParen,
             (select NumPartidaLetras from padres where idPadre=p.idMadre) as NitMadre,(select NumPartidaLetras from padres where idPadre=p.idPadre) as NitPadre,inf.Dui_letras as DuiInformante,(select Edad_letras from padres where idPadre=p.idMadre) as EdadMadre,
             (select Edad_letras from padres where idPadre=p.idPadre) as EdadPadre,
             (select Domicilio from padres where idPadre=p.idMadre) as DomicilioMadre, (select Domicilio from padres where idPadre=p.idPadre) as DomicilioPadre,
             (select NombreCompleto from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo) as JefeRegistro,
             (select Rubrica from empleados where idEmpleado=p.idJefeRegistro) as Rubrica FROM registro_familiar.partidas_nacimiento p,
             padres inf, padres i where p.idInfante=i.idPadre and
             p.idInformante=inf.idPadre and idPartida=" + pidPartida + ";";
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
             (select NombreCompleto from padres where idPadre=p.idMadre) as madre,
             (select DUI from padres where idPadre=p.idMadre) as Dui_madre,
             p.idPadre,
             (select NombreCompleto from padres where idPadre=p.idPadre) as padre,
             (select DUI from padres where idPadre=p.idPadre) as Dui_madre,
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
             padres inf,
             padres i,
             empleados e,
             tipo_partidas t where p.idInfante=i.idPadre and p.idJefeRegistro=e.idEmpleado and p.idTipo_partida=t.idTipo_partida
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

        public static DataTable PERMISOS_OTORGADOS(String pidGrupo)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT p.idOpcion,Opcion from permisos p,opciones o,roles g where o.idOpcion=p.idOpcion and p.idRol=g.idRol and p.idRol=" + pidGrupo + ";";
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

        public static DataTable TODAS_LAS_PARTIDAS_DEFUNCION_REPORTE(Int32 pPartida)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select NumPartida_letras,Libro_letras,Folio_letras,Anio_insercion_letras,
            (select NombreCompleto from padres where idPadre=de.idFallecido) as Fallecido,
            (select ConocidoPor from padres where idPadre=de.idFallecido) as ConocidoPor,
            (select Sexo from padres where idPadre=de.idFallecido) as Sexo,
            (select Edad_letras from padres where idPadre=de.idFallecido) as Edad_letras,
            (select pf.Profesion from padres p,profesiones pf where idPadre=de.idFallecido and pf.idProfesion=p.Profesion) as Profesion,
            (select Estado_familiar from padres where idPadre=de.idFallecido) as Estado_familiar,
            (select concat(m.Municipio,', ',d.Departamento) from padres p,municipios m,departamentos d where idPadre=de.idFallecido and p.idMunicipio=m.idMunicipio and m.idDepartamento=d.idDepartamento) as FallecidoOrigen,
            (select pa.Nacionalidad from padres p,paises pa where idPadre=de.idFallecido and p.Nacionalidad=pa.idPais) as Nacionalidad,
            (select Dui_letras from padres where idPadre=de.idFallecido) as Dui_letras,
            (select concat(c.Canton,', MUNICIPIO DE ',m.Municipio,', DEPARTAMENTO DE ',d.Departamento) from partidas_defuncion p, cantones c,municipios m,departamentos d where c.idCanton=p.Lugar_fallecimiento and c.idMunicipio=m.idMunicipio and m.idDepartamento=d.idDepartamento and p.idpartidas_defuncion=de.idpartidas_defuncion) as Lugar_fallecimiento,
            de.Hora_fallecimiento_letras,
            de.Fecha_fallecimiento_letras,
            de.Asistencia_medica as Asistencia,
            (select Causa from causas_muerte where idCausa=de.Causa_muerte) as Causa_muerte,
            (select NombreCompleto from padres where idPadre=de.idProfesional) as Profesional,
            (select pf.Profesion from padres p,profesiones pf where idPadre=de.idProfesional and p.Profesion=pf.idProfesion) as Profesional_cargo,
            (select NombreCompleto from padres where idPadre=de.idConyuge)as Conyuge,
            (select NombreCompleto from padres where idPadre=de.idMadre)as Madre,
            (select pf.Profesion from padres p,profesiones pf where idPadre=de.idMadre and p.Profesion=pf.idProfesion) as ProfesionMadre,
            (select NombreCompleto from padres where idPadre=de.idPadre)as Padre,
            (select pf.Profesion from padres p,profesiones pf where idPadre=de.idPadre and p.Profesion=pf.idProfesion) as ProfesionPadre,
            (select Domicilio from padres where idPadre=de.idMadre) as Domicilio_madre,
            (select Domicilio from padres where idPadre=de.idPadre) as Domicilio_padre,
            (select Estado from padres where idPadre=de.idMadre) as Estado_madre,
            (select Estado from padres where idPadre=de.idPadre) as Estado_padre,
            (select NombreCompleto from padres where idPadre=de.idInformante) as Informante,
            (select Dui_letras from padres where idPadre=de.idInformante) as Informante_dui,
            (select pa.Parentesco from padres p,parentescos pa where idPadre=de.idInformante and p.idParentesco=pa.idParentesco) as Parentesco_informante,
            de.Fecha_insercion_letras,
            (select NombreCompleto from padres where idPadre=de.idTestigo1) as Testigo1,
            (select Dui_letras from padres where idPadre=de.idTestigo1) as Testigo1_dui,
            (select NombreCompleto from padres where idPadre=de.idTestigo2) as Testigo2,
            (select Dui_letras from padres where idPadre=de.idTestigo2) as Testigo2_dui,
            (select NombreCompleto from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo) as JefeRegistro
 from partidas_defuncion de where idpartidas_defuncion="+pPartida+";";
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

        public static DataTable TODAS_LAS_PARTIDAS_DEFUNCION_REPORTE2(Int32 pPartida)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select NumPartida_letras,Libro_letras,Folio_letras,Anio_insercion_letras,
            (select NombreCompleto from padres where idPadre=de.idFallecido) as Fallecido,
            (select ConocidoPor from padres where idPadre=de.idFallecido) as ConocidoPor,
            (select Sexo from padres where idPadre=de.idFallecido) as Sexo,
            (select Edad_letras from padres where idPadre=de.idFallecido) as Edad_letras,
            (select pf.Profesion from padres p,profesiones pf where idPadre=de.idFallecido and pf.idProfesion=p.Profesion) as Profesion,
            (select Estado_familiar from padres where idPadre=de.idFallecido) as Estado_familiar,
            (select concat(m.Municipio,', ',d.Departamento) from padres p,municipios m,departamentos d where idPadre=de.idFallecido and p.idMunicipio=m.idMunicipio and m.idDepartamento=d.idDepartamento) as FallecidoOrigen,
            (select pa.Nacionalidad from padres p,paises pa where idPadre=de.idFallecido and p.Nacionalidad=pa.idPais) as Nacionalidad,
            (select NumPartidaLetras from padres where idPadre=de.idFallecido) as Nit_letras,
            (select concat(c.Canton,', MUNICIPIO DE ',m.Municipio,', DEPARTAMENTO DE ',d.Departamento) from partidas_defuncion p, cantones c,municipios m,departamentos d where c.idCanton=p.Lugar_fallecimiento and c.idMunicipio=m.idMunicipio and m.idDepartamento=d.idDepartamento and p.idpartidas_defuncion=de.idpartidas_defuncion) as Lugar_fallecimiento,
            de.Hora_fallecimiento_letras,
            de.Fecha_fallecimiento_letras,
            de.Asistencia_medica as Asistencia,
            (select Causa from causas_muerte where idCausa=de.Causa_muerte) as Causa_muerte,
            (select NombreCompleto from padres where idPadre=de.idProfesional) as Profesional,
            (select pf.Profesion from padres p,profesiones pf where idPadre=de.idProfesional and p.Profesion=pf.idProfesion) as Profesional_cargo,
            (select NombreCompleto from padres where idPadre=de.idConyuge)as Conyuge,
            (select NombreCompleto from padres where idPadre=de.idMadre)as Madre,
            (select pf.Profesion from padres p,profesiones pf where idPadre=de.idMadre and p.Profesion=pf.idProfesion) as ProfesionMadre,
            (select NombreCompleto from padres where idPadre=de.idPadre)as Padre,
            (select pf.Profesion from padres p,profesiones pf where idPadre=de.idPadre and p.Profesion=pf.idProfesion) as ProfesionPadre,
            (select Domicilio from padres where idPadre=de.idMadre) as Domicilio_madre,
            (select Domicilio from padres where idPadre=de.idPadre) as Domicilio_padre,
            (select Estado from padres where idPadre=de.idMadre) as Estado_madre,
            (select Estado from padres where idPadre=de.idPadre) as Estado_padre,
            (select NombreCompleto from padres where idPadre=de.idInformante) as Informante,
            (select Dui_letras from padres where idPadre=de.idInformante) as Informante_dui,
            (select pa.Parentesco from padres p,parentescos pa where idPadre=de.idInformante and p.idParentesco=pa.idParentesco) as Parentesco_informante,
            de.Fecha_insercion_letras,
            (select NombreCompleto from padres where idPadre=de.idTestigo1) as Testigo1,
            (select Dui_letras from padres where idPadre=de.idTestigo1) as Testigo1_dui,
            (select NombreCompleto from padres where idPadre=de.idTestigo2) as Testigo2,
            (select Dui_letras from padres where idPadre=de.idTestigo2) as Testigo2_dui,
            (select NombreCompleto from empleados e,cargos c where c.Cargo='Jefe de Registro Familiar' and e.idCargo=c.idCargo) as JefeRegistro
 from partidas_defuncion de where idpartidas_defuncion=" + pPartida + ";";
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
                        c.Canton,
                        m.Municipio,                        
                        dep.Departamento,
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
                        Modificada FROM registro_familiar.partidas_defuncion p, padres fa,municipios m,cantones c,departamentos dep,
                        padres inf,padres tes1,padres tes2,tipo_partidas t,
                        empleados e where p.idFallecido=fa.idPadre and p.idInformante=inf.idPadre
                        and p.idJefeRegistro=e.idEmpleado and p.idTestigo1=tes1.idPadre
                        and p.idTestigo2=tes2.idPadre and p.idTipo_partida=t.idTipo_partida and p.Lugar_fallecimiento=c.idCanton and dep.idDepartamento=m.idDepartamento and c.idMunicipio=m.idMunicipio and Modificada=0 and Fecha_fallecimiento like '%" + fecha + "%';";
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
            Consulta = @"SELECT idPadre, NombreCompleto, ConocidoPor, Edad, Domicilio, pa.Nacionalidad, DUI,p.NumPartida as Nit, dep.Departamento, p.idMunicipio,m.Municipio, pr.Profesion,ps.Parentesco,p.Observaciones, p.NumPartida,p.FechaNac,p.Rubrica  
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

        public static DataTable TODOS_LOS_PADRES1()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idPadre, NombreCompleto, ConocidoPor, Edad, p.Sexo, Domicilio, pa.Nacionalidad, DUI, NumPartida, dep.Departamento, p.idMunicipio,m.Municipio, pr.Profesion, p.NumPartida,p.Revisado,Estado_familiar 
                        FROM registro_familiar.padres p, municipios m, departamentos dep, profesiones pr, paises pa 
                        where p.idMunicipio = m.idMunicipio and dep.idDepartamento=m.idDepartamento and p.Nacionalidad=pa.idPais and pr.idProfesion=p.Profesion; ";
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
            Consulta = "SELECT idEmpleado,NombreCompleto,Cargo,c.idCargo,e.Rubrica from Empleados e,Cargos c where e.idCargo=c.idCargo order by NombreCompleto asc";
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

        public static DataTable TODOS_LOS_CANTONES()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select idCanton,Canton,Municipio,Departamento,c.idMunicipio from cantones c,municipios m,departamentos d where c.idMunicipio=m.idMunicipio and m.idDepartamento=d.idDepartamento;";
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

        public static DataTable TODOS_LOS_CANTONES1()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from cantones;";
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

        public static DataTable TODOS_LOS_CAUSAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT * from causas_muerte";
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

        public static DataTable TODOS_LOS_COSTOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT idCosto,Monto,Tipo_partida from Costos c, tipo_partidas t where c.idTipo_partida=t.idTipo_partida;";
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

        public static DataTable TODOS_LOS_MOVIMIENTOS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idMovimientos, cast(Fecha as character(10))as Fecha, Hora, (SELECT Usuario from usuarios where idUsuario=m.idUsuario) as Usuario,
                        Accion FROM registro_familiar.movimientos m; ";
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

        public static DataTable MarginacionPartidaNac(String pIdPartida)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select p.idPartida,NumPartida,Hora_sentencia,Fecha_sentencia,j.Nombre,m.Explicacion from partidas_nacimiento p,juzgados j,marginaciones m where p.idPartida="+pIdPartida+" and p.idJuzgado=j.idJuzgados and m.idPartida=p.idPartida;";
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

        public static DataTable MarginacionesNac(String pIdPartida)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select m.Explicacion,Fecha from marginaciones m where m.idPartida="+pIdPartida+";";
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

        public static DataTable MarginacionPartidaDef(String pIdPartida)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select p.idpartidas_defuncion,NumPartida,Hora_sentencia,Fecha_sentencia,j.Nombre,m.Explicacion from partidas_defuncion p,juzgados j,marginaciones m where p.idpartidas_defuncion="+pIdPartida+" and p.idJuzgado=j.idJuzgados and m.idPartidaDef=p.idpartidas_defuncion;";
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

        public static DataTable TODOS_LOS_TIPOS_PARTIDAS()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select * from tipo_partidas;";
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

        public static DataTable PERMISOS_DISPONIBLES(String pidGrupo)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select o.idOpcion,o.Opcion from opciones o where o.idOpcion not in(select p.idOpcion from permisos p where p.idRol=" + pidGrupo + ");";
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

        public static DataTable TODOS_LAS_CAUSAS_DE_MUERTE()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "SELECT * FROM registro_familiar.causas_muerte order by Causa;";
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
            Consulta = "SELECT * FROM registro_familiar.profesiones order by Profesion asc;";
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
            Consulta = "SELECT * FROM registro_familiar.paises order by Nacionalidad;";
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

        public static DataTable TODAS_PARTIDAS_MATRIMONIO()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select pda.idpartida_matrimonio,
                            pda.NumPartida,
                            pda.folio,
                            pda.idEsposa as 'idMujer',
                            p.NombreCompleto as 'Esposa',
                            pda.idEsposo as 'idHombre',
                            pa.NombreCompleto as 'Esposo',
                            pda.Apellido_elegido as 'ApellidoCasada',
                            pda.idTestigo as 'idtes1',
                            pad.NombreCompleto as 'Testigo',
                            pda.idTestigo2 as 'idtes2',
                            padr.NombreCompleto as 'Testigo2',
                            pda.idFuncionario as 'idfun',
                            pfun.NombreCompleto as 'nfuncionario',
                            pda.Hora_insercion,
                            pda.Imagen,
                            d.Departamento as 'depto',
                            pda.Lugar_matrimonio as 'Municipio', 
                            pda.idPadre_esposo as 'PH',
                            pda.idMadre_esposo as 'MH',
                            pda.idPadre_esposa as 'PM',
                            pda.idMadre_esposa as 'MM',
                            pda.Fecha_matrimonio,
                            pda.Revisado,
                            pda.Regimen_patrimonial,
                            pda.detalle_hijos
                            from partidas_matrimonio pda, padres p, padres pa, padres pad, padres padr,padres pfun, departamentos d
                            where pda.idEsposa = p.idPadre and pda.idEsposo = pa.idPadre
                            and pda.idTestigo = pad.idPadre and pda.idTestigo2 = padr.idPadre
                            and pda.idFuncionario = pfun.idPadre and (select idDepartamento from municipios where Municipio=pda.Lugar_matrimonio) = d.idDepartamento;";

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

        public static DataTable TODAS_PARTIDAS_DIVORCIO()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT idDivorcio, 
                        d.NumPartida, idMatrimonio, idJuzgado, Fecha_sentencia,
                        (select idEsposo from partidas_matrimonio where idpartida_matrimonio=d.idMatrimonio) as idEsposo,
                        (select idEsposa from partidas_matrimonio where idpartida_matrimonio=d.idMatrimonio) as idEsposa, 
                        (select NombreCompleto from padres where idPadre=(select idEsposo from partidas_matrimonio where idpartida_matrimonio=d.idMatrimonio)) as Hombre,
                        (select NombreCompleto from padres where idPadre=(select idEsposa from partidas_matrimonio where idpartida_matrimonio=d.idMatrimonio)) as Mujer,
                        (select Fecha_matrimonio from partidas_matrimonio where idpartida_matrimonio=d.idDivorcio)as Fecha_matrimonio,
                        d.Fecha_sentencia,
                        Fecha_ejecutoriada, d.idTipo_partida, d.Imagen, d.Libro, d.Folio, 
                        Tutela, (select Regimen_patrimonial from partidas_matrimonio where idpartida_matrimonio=d.idMatrimonio)as Regimen_patrimonial,
                        (select Nombre from juzgados where idJuzgados=d.idJuzgado)as Juzgado,
                        NombreNotario, d.Revisado FROM registro_familiar.divorcios d, partidas_matrimonio m
                         where d.idMatrimonio=m.idpartida_matrimonio;";

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

        public static DataTable ID_Papas_Conyuges(String idInfante)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select pnac.idPadre , pnac.idMadre from partidas_nacimiento pnac where pnac.idInfante="+idInfante+";";

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

        public static DataTable EstadoFamiliar_Conyugue(String idInfante)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = "select p.Estado_familiar from padres p where p.idPadre= " + idInfante + ";";

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
        
        public static DataTable EstadisticaNacimientos(String pFechaI,String pFechaF,String pUsuario)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select NombreCompleto as Empleado,
(select count(idPartida) from partidas_nacimiento where Fecha_insercion between '"+pFechaI+@"' and '"+pFechaF+@"') as Asientos,
(select count(idPartida) from partidas_nacimiento p,padres pa where p.idInfante = pa.idPadre and pa.Sexo = 'Femenino' and Fecha_insercion between '"+pFechaI+ @"' and '" + pFechaF + @"') as CantidadMujeres,
(select count(idPartida) from partidas_nacimiento p,padres pa where p.idInfante = pa.idPadre and pa.Sexo = 'Masculino' and Fecha_insercion between '" + pFechaI + @"' and '" + pFechaF + @"') as CantidadHombres,
(select count(idPartida) from partidas_nacimiento p,padres pa where p.idMadre = pa.idPadre and pa.Edad < 18 and Fecha_insercion between '" + pFechaI + @"' and '" + pFechaF + @"') as MadresMenores,
(select count(idPartida) from partidas_nacimiento p,padres pa where p.idPadre = pa.idPadre and pa.Edad < 18 and Fecha_insercion between '" + pFechaI + @"' and '" + pFechaF + @"') as PadresMenores,
(select count(idTransaccion) from operaciones where Tipo = 'Impresión de partida de nacimiento' and Fecha between '" + pFechaI + @"' and '" + pFechaF + @"')as Solicitudes,
(select(round(count(idTransaccion) * Costo, 2)) from operaciones where Tipo = 'Impresión de partida de nacimiento' and Fecha between '" + pFechaI + @"' and '" + pFechaF + @"')as Ingresos,
(select min(Fecha) from operaciones where (Tipo = 'Impresión de partida de nacimiento' or Tipo = 'Nueva partida de nacimiento') and Fecha between '" + pFechaI + @"' and '" + pFechaF + @"') as FechaInicio,
(select max(Fecha) from operaciones where (Tipo = 'Impresión de partida de nacimiento' or Tipo = 'Nueva partida de nacimiento') and Fecha between '" + pFechaI + @"' and '" + pFechaF + @"') as FechaFin
from empleados e,usuarios u where u.idEmpleado = e.idEmpleado and u.Usuario = '" + pUsuario+"'; ";

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

        public static DataTable Reporte_defunciones1(String pFechaI, String pFechaF)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT d.NumPartida,(select count(*)from partidas_defuncion where Fecha_fallecimiento between '"+pFechaI+@"' and '"+pFechaF+ @"')as Cantidad,
                        (select NombreCompleto from padres where idPadre=d.idFallecido)as Fallecido,
                        (select DUI from padres where idPadre=d.idFallecido)as Dui,
                        (select NumPartida from padres where idPadre=d.idFallecido)as Nit,
                        (SELECT TIMESTAMPDIFF(YEAR,FechaNac,CURDATE()) FROM padres where idPadre=d.idFallecido)as Edad,
                        d.Fecha_fallecimiento,
                        (select Causa from causas_muerte where idCausa=d.Causa_muerte) as Causa_muerte
                         FROM registro_familiar.partidas_defuncion d where d.Fecha_fallecimiento between '" + pFechaI + @"' and '" + pFechaF + @"';";

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

        public static DataTable Reporte_defunciones2(String pFechaI, String pFechaF,String pCausa)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT d.NumPartida,(select count(*)from partidas_defuncion where Fecha_fallecimiento between '" + pFechaI + "' and '" + pFechaF + "' and Causa_muerte=" + pCausa + @")as Cantidad,
                        (select NombreCompleto from padres where idPadre=d.idFallecido)as Fallecido,
                        (select DUI from padres where idPadre=d.idFallecido)as Dui,
                        (select NumPartida from padres where idPadre=d.idFallecido)as Nit,
                        (SELECT TIMESTAMPDIFF(YEAR,FechaNac,CURDATE()) FROM padres where idPadre=d.idFallecido)as Edad,
                        d.Fecha_fallecimiento,
                        (select Causa from causas_muerte where idCausa=d.Causa_muerte) as Causa_muerte
                         FROM registro_familiar.partidas_defuncion d where d.Fecha_fallecimiento between '" + pFechaI + @"' and '" + pFechaF + @"' and Causa_muerte="+pCausa+";";

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

        public static DataTable Reporte_Operaciones(String pFechaI, String pFechaF, String Tipo)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select (select count(*)from operaciones where Fecha between '"+pFechaI+@"' and '"+pFechaF+ @"' and Tipo = '"+Tipo+ @"') as Operaciones,
                        (select round((count(idTransaccion)*Costo),2) from operaciones where Tipo='" + Tipo + @"' and Fecha between '" + pFechaI + @"' and '" + pFechaF + @"')as Ingresos,
                        (select min(Fecha) from operaciones where Tipo = '" + Tipo + @"') as FechaInicio,
                        (select max(Fecha) from operaciones where Tipo = '" + Tipo + @"') as FechaFinal,
                        Tipo,Costo,
                        Fecha from operaciones where Tipo='" + Tipo + @"' and Fecha between '" + pFechaI + @"' and '" + pFechaF + @"';";

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


        public static DataTable REPORTE_PARTIDA_MATRIMONIO(Int32 idpartidaMatrimonio)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select
                        pmat.folio,
                        pmat.NumPartida,
                        pmat.Fecha_matrimonio_letra,
                        pmat.anio_insercion_letras as 'anio_insercion',
                        pmat.Hora_inse_entero as 'hora_insercion',
                        pMujer.NombreCompleto as 'NombreMujer',
                        pMujer.Edad_letras as 'Edad_letra_Mujer',
                        pMujer.Estado_familiar as 'EstadoCivilMujer',
                        pMujer.Estado_familiar_anterior as 'estado_fam_M_anterior',
                        paisM.Nacionalidad as 'NacionMujer',
                        profM.Profesion as 'ProfesionMujer',
                        munM.Municipio as 'MunicipioMujer',
                        pMujer.Dui_letras as 'Dui_letras_Mujer',
                        pPadreM.NombreCompleto as 'NombrePadreMujer',
                        pPadreM.Estado as 'Est_vida_pPadreM',
                        profPadreM.Profesion as 'profPADREmujer',
                        pMadreM.NombreCompleto as 'NombreMadreMujer',
                        pMadreM.Estado as 'Est_vida_pMadreM',
                        profMadreM.Profesion as 'profMADREmujer',
                        pMujer.Domicilio as 'DomicilioMadreMujer',
                        pMujer.Domicilio as 'DomicilioPadreMujer',
                        pHombre.NombreCompleto as 'NombreHombre',
                        pHombre.Edad_letras as 'Edad_letra_Hombre',
                        pHombre.Estado_familiar as 'EstadoCivilHombre',
                        pHombre.Estado_familiar_anterior as 'estado_fam_H_anterior',
                        paisH.Nacionalidad as 'NacionHombre',
                        profH.Profesion as 'ProfesionHombre',
                        munH.Municipio as 'MunicipioHombre',
                        pHombre.Dui_letras as 'Dui_letras_Hombre',
                        pPadreH.NombreCompleto as 'NombrePadreHombre',
                        pPadreH.Estado as 'Est_vida_pPadreH',
                        profPadreH.Profesion as 'profPADREhombre',
                        pMadreH.NombreCompleto as 'NombreMadreHombre',
                        pMadreH.Estado as 'Est_vida_pMadreH',
                        profMadreH.Profesion as 'profMADREhombre',
                        pHombre.Domicilio as 'DomicilioMadreHombre',
                        pHombre.Domicilio as 'DomicilioPadreHombre',
                        pTes1.NombreCompleto as 'nomTestigo1',
                        pTes1.Edad_letras_actual as 'Edad_letra_Tes1',
                        profT1.Profesion as 'profesion_Tes1',
                        pTes1.Domicilio as 'domicilio_Tes1',
                        pTes1.Dui_letras as 'dui_letras_tes1',
                        pTes2.NombreCompleto as 'nomTestigo2',
                        pTes2.Edad_letras_actual as 'Edad_letra_Tes2',
                        profT2.Profesion as 'profesion_Tes2',
                        pTes2.Domicilio as 'domicilio_Tes2',
                        pTes2.Dui_letras as 'dui_letras_tes2',
                        pFuncionario.NombreCompleto as 'nomFuncionario',
                        profFuncionario.Profesion as 'profFuncionario',
                        pmat.Apellido_elegido 'apellido_casada',
                        pmat.Regimen_patrimonial 'regimen_patrimonial',
                        pFuncionario.Rubrica as'rubrica_funcionario',
                        pHombre.Rubrica as'rubrica_Hombre',
                        pMujer.Rubrica as'rubrica_Mujer',
                        pTes1.Rubrica as'rubrica_Tes1',
                        pTes2.Rubrica as'rubrica_Tes2'

                        from
                        partidas_matrimonio pmat,
                        padres pPadreM, padres pMadreM, padres pPadreH, padres pMadreH,
                         padres pMujer, padres pHombre, padres pTes1, padres pTes2, padres pFuncionario,
                         municipios munM, municipios munH, paises paisH, paises paisM, profesiones profH,
                         profesiones profM, profesiones profT1, profesiones profT2,
                         profesiones profPadreH, profesiones profMadreH, profesiones profPadreM, profesiones profMadreM, profesiones profFuncionario


                        where
                        pmat.idEsposa = pMujer.idPadre
                        and pmat.idMadre_esposa= pMadreM.idPadre
                        and pmat.idPadre_esposa= pPadreM.idPadre
                        and pmat.idEsposo = pHombre.idPadre
                        and pmat.idPadre_esposo= pPadreH.idPadre
                        and pmat.idMadre_esposo= pMadreH.idPadre
                        and pmat.idEsposa = pMujer.idPadre
                        and pmat.idTestigo = pTes1.idPadre
                        and pmat.idTestigo2 = pTes2.idPadre
                        and pmat.idFuncionario = pFuncionario.idPadre
                        and munM.idMunicipio = pMujer.idMunicipio
                        and munH.idMunicipio = pHombre.idMunicipio
                        and pHombre.Nacionalidad = paisH.idPais
                        and pHombre.Profesion = profH.idProfesion
                        and pMujer.Nacionalidad = paisM.idPais
                        and pMujer.Profesion = profM.idProfesion
                        and pTes1.Profesion = profT1.idProfesion
                        and pTes2.Profesion = profT2.idProfesion
                        and pPadreH.Profesion = profPadreH.idProfesion
                        and pMadreH.Profesion = profMadreH.idProfesion
                        and pPadreM.Profesion = profPadreM.idProfesion
                        and pMadreM.Profesion = profMadreM.idProfesion
                        and pFuncionario.Profesion = profFuncionario.idProfesion
                        and pmat.idpartida_matrimonio = "+idpartidaMatrimonio+";";

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



        public static DataTable TODOS_LOS_JUZGADOS_hoy_si()
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"SELECT j.idJuzgados, j.Nombre, m.Municipio, Direccion 
                        FROM juzgados j, municipios m 
                        where j.idMunicipio = m.idMunicipio;";

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

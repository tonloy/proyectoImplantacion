﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBasica.CLS
{
    public class Informante
    {
        //atr
        private string idInformante;
        private string NombreCompleto;
        private string ConocidoPor;
        private string FechaInscripcion;
        private string Observaciones;
        private string DUI;
        private string idParentesco;
        private string _Profesion;

        public string Profesion
        {
            get { return _Profesion; }
            set { _Profesion = value; }
        }

        //pro
        public string IdInformante
        {
            get { return idInformante; }
            set { idInformante = value; }
        }

        public string NombreCompleto1
        {
            get { return NombreCompleto; }
            set { NombreCompleto = value; }
        }
        
        public string ConocidoPor1
        {
            get { return ConocidoPor; }
            set { ConocidoPor = value; }
        }

        public string FechaInscripcion1
        {
            get { return FechaInscripcion; }
              set { FechaInscripcion = value; }
        }

         public string Observaciones1
        {
             get { return Observaciones; }
             set { Observaciones = value; }
        }

        public string DUI1
        {
            get { return DUI; }
            set { DUI = value; }
        }

        public string IdParentesco
        {
              get { return idParentesco; }
              set { idParentesco = value; }
        }


        //met
        public bool Insertar() {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("INSERT INTO registro_familiar.informantes (NombreCompleto, ConocidoPor, FechaInscripcion, Observaciones, DUI, idParentesco) VALUES ( ");
            Sentencia.Append("'" + NombreCompleto + "', '" + ConocidoPor + "', now(),'" + Observaciones + "','" + DUI + "'," + idParentesco + ");  ");
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
            catch(Exception e)
            {
                guardado = false;
            }

            return guardado;        
        }
        public bool Actualizar()
        {
            Boolean guardado = false;
            StringBuilder Sentencia = new StringBuilder();

            Sentencia.Append("UPDATE informantes SET NombreCompleto='"+this.NombreCompleto+"', ConocidoPor='"+this.ConocidoPor+"', Observaciones='"+this.Observaciones+"' WHERE idInformante='"+this.idInformante+"';");
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

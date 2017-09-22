using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer
{
    public class OperacionBD:ConexionDB
    {
        public Int32 Insertar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Int32 Actualizar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        public Int32 Eliminar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }
        private Int32 EjecutarSentencia(String pSentencia)
        {
            Int32 NumeroFilasAfectadas = 0;

            if (base.Conectar())
            {
                MySqlCommand Comando = new MySqlCommand();
                Comando.Connection = base._CONEXION;
                Comando.CommandText = pSentencia;
                try
                {
                    NumeroFilasAfectadas = Comando.ExecuteNonQuery();
                }
                catch
                {
                    NumeroFilasAfectadas = 0;
                }
            }


            return NumeroFilasAfectadas;
        }
        public DataTable Consultar(String pConsulta)
        {
            return EjecutarConsulta(pConsulta);
        }
        private DataTable EjecutarConsulta(String pConsulta)
        {
            DataTable Resultado = new DataTable();
            try
            {
                if (base.Conectar())
                {
                    MySqlCommand Comando = new MySqlCommand();
                    MySqlDataAdapter Adaptador = new MySqlDataAdapter();
                    Comando.Connection = base._CONEXION;
                    Comando.CommandText = pConsulta;
                    Comando.CommandType = CommandType.Text;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);
                }
            }
            catch (Exception e)
            {
                Resultado = new DataTable();
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Resultado;
        }
    }
}

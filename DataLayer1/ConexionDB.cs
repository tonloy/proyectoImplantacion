using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer1
{
    public abstract class ConexionDB
    {
        protected MySqlConnection _CONEXION;

        protected Boolean Conectar()
        {
            Boolean Conectado = false;
            String cadenaconexion = "Server = localhost; Port = 3306; Database = registro_familiar; Uid = root; Pwd = admin;";
            _CONEXION = new MySqlConnection();
            _CONEXION.ConnectionString = cadenaconexion;
            try
            {
                _CONEXION.Open();
                Conectado = true;
            }
            catch
            {
                Conectado = false;
            }
            return Conectado;
        }

        protected void Desconectar()
        {
            try
            {
                if (_CONEXION.State == System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch
            {

            }
        }
    }
}

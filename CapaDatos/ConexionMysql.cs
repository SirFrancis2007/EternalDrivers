using CapaEntidad;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class ConexionMysql
    {
        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string puerto = "3306";
        static string usuario = "root";
        static string pass = "root";
        static string bd = "f1";

        string Conexionsql = "server=" + servidor + ";" + "port=" + puerto + ";" + "uid=" + usuario + ";" + "password=" + pass + ";" + "database=" + bd + ";";
        public MySqlConnection Conexion()
        {
            try
            {
                conexion.ConnectionString = Conexionsql;
                conexion.Open();

            }
            catch (Exception e)
            {
                conexion.Close();
            }

            return conexion;
        }
    }
}

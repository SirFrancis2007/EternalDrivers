using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DelEscuderiaDAO
    {
        public List<string> ObtenerEscuderias(MySqlConnection conexion)
        {
            List<string> escuderias = new List<string>();
            try
            {
                string query = "SELECT Escuderia FROM Escuderia;";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    escuderias.Add(reader["Escuderia"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las escuderías: " + ex.Message);
            }

            return escuderias;
        }

        public bool EliminarEscuderia(string nombreEscuderia, MySqlConnection conexion)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("spEliminarEscuderia", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEscuderia", nombreEscuderia);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                conexion.Dispose();
                Console.WriteLine("Error al eliminar la escudería: " + ex.Message);
                return false;
            }
        }
    }
}

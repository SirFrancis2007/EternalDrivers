using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MenuEscuderiaDAO
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
    }
}

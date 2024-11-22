using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MenuGranPremioDAO
    {
        public List<string> ObtenerGranPremios(MySqlConnection conexion)
        {
            List<string> granPremios = new List<string>();
            try
            {
                string query = "SELECT GranPremio FROM granpremio;";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    granPremios.Add(reader["GranPremio"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los Grandes Premios: " + ex.Message);
            }
            return granPremios;
        }
    }
}

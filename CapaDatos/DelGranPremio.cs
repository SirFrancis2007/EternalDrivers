using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DelGranPremio
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

        public bool EliminarGranPremio(string nombreGranPremio, MySqlConnection conexion)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("spGranPremio", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreEscuderia", nombreGranPremio);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el Gran Premio: " + ex.Message);
                return false;
            }
        }
    }
}

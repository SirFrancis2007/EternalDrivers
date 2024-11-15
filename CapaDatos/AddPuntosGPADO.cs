using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AddPuntosGPADO
    {
        public List<string> ObtenerPilotos(MySqlConnection conn)
        {
            List<string> pilotos = new List<string>();

            string query = "SELECT Nombre FROM Piloto";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pilotos.Add(reader["Nombre"].ToString());
            }

            return pilotos;
        }
    }
}

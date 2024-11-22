using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosEscuderia
    {
        public bool ObtenerDatosEscuderia(MySqlConnection conn, string nombreescuderia, out Dictionary<string, string> escuderiaData)
        {
            escuderiaData = new Dictionary<string, string>();

            try
            {
                string query = @"SELECT e.Escuderia, e.Pais, e.Jefedeequipo, m.Monoplaza, m.Potencia, m.Motor
                                FROM Escuderia e
                                JOIN Piloto p ON e.idEscuderia = p.Escuderia_idEscuderia
                                JOIN Monoplaza m ON e.idEscuderia = m.idEscuderia
                                WHERE e.Escuderia = @nombreescuderia";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombreescuderia", nombreescuderia);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    escuderiaData["Escuderia"] = reader["Escuderia"].ToString();
                    escuderiaData["Pais"] = reader["Pais"].ToString();
                    escuderiaData["JefeDeEquipo"] = reader["Jefedeequipo"].ToString();
                    escuderiaData["Monoplaza"] = reader["Monoplaza"].ToString();
                    escuderiaData["Potencia"] = reader["Potencia"].ToString();
                    escuderiaData["Motor"] = reader["Motor"].ToString();
                }

                reader.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<string> ObtenerCorredores(MySqlConnection conn, string nombreescuderia)
        {
            List<string> corredores = new List<string>();

            try
            {
                string query = @"SELECT Nombre 
                                    FROM piloto 
                                    JOIN Escuderia ON Piloto.Escuderia_idEscuderia = Escuderia.idEscuderia
                                    WHERE Escuderia = @nombreescuderia";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombreescuderia", nombreescuderia);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    corredores.Add(reader["Nombre"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                return [];
            }

            return corredores;
        }
    }
}

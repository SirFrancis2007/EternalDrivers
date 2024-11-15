using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DelAuxPilotoDAO
    {
        public List<string> ObtenerEscuderias(MySqlConnection conn)
        {
            List<string> escuderias = new List<string>();
            string query = "SELECT Escuderia FROM Escuderia";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    escuderias.Add(reader["Escuderia"].ToString());
                }
            }

            return escuderias;
        }

        public List<string> ObtenerPilotosPorEscuderia(MySqlConnection conn, string escuderia)
        {
            List<string> pilotos = new List<string>();
            string query = @"SELECT piloto.Nombre 
                     FROM piloto 
                     JOIN escuderia ON piloto.Escuderia_idEscuderia = escuderia.idEscuderia
                     WHERE escuderia.Escuderia = @escuderia";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@escuderia", escuderia);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pilotos.Add(reader["Nombre"].ToString());
                    }
                }
            }

            return pilotos;
        }

        public bool PuedeEliminarEscuderia(MySqlConnection conn, string nombreEscuderia)
        {
            string verificarQuery = "SELECT PuedeEliminarEscuderia((SELECT idEscuderia FROM Escuderia WHERE Escuderia = @nombreEscuderia))";
            using (MySqlCommand cmd = new MySqlCommand(verificarQuery, conn))
            {
                cmd.Parameters.AddWithValue("@nombreEscuderia", nombreEscuderia);
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
        }

        public bool EliminarPiloto(MySqlConnection conn, string nombrePiloto, string nombreEscuderia)
        {
            MySqlCommand cmd = new MySqlCommand("DelPiloto", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@xnombreEscuderia", nombreEscuderia);
            cmd.Parameters.AddWithValue("@xnombrepiloto", nombrePiloto);

            cmd.ExecuteNonQuery();
            return true;
        }
    }
}

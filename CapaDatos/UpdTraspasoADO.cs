using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class UpdTraspasoADO
    {
        public DataTable ObtenerPilotos(MySqlConnection conn)
        {
            string query = @"SELECT piloto.Nombre, piloto.Nacionalidad, escuderia.Escuderia
                             FROM piloto
                             JOIN escuderia ON piloto.Escuderia_idEscuderia = escuderia.idEscuderia
                             GROUP BY piloto.Nombre, piloto.Nacionalidad, escuderia.Escuderia;";

            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public List<Pilotos> ObtenerListaPilotos(MySqlConnection conn)
        {
            List<Pilotos> pilotos = new List<Pilotos>();
            string query = @"SELECT p.idPiloto, p.Nombre, e.Escuderia 
                     FROM Escuderia e
                     JOIN Piloto p ON e.idEscuderia = p.Escuderia_idEscuderia";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pilotos.Add(new Pilotos
                {
                    IDPiloto = (int)reader["idPiloto"],
                    Nombre = reader["Nombre"].ToString(),
                    Escuderia = reader["Escuderia"].ToString()
                });
            }

            reader.Close();
            return pilotos;
        }


        public int ObtenerEscuderiaActual(MySqlConnection conn, int idPiloto)
        {
            string query = @"SELECT Escuderia_idEscuderia FROM Piloto WHERE idPiloto = @idPiloto";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idPiloto", idPiloto);

            object result = cmd.ExecuteScalar();
            return Convert.ToInt32(result);
        }

        public void EjecutarTraspaso(MySqlConnection conn, int idPilotoA, int idPilotoB, int idEscuderiaA, int idEscuderiaB)
        {
            MySqlCommand cmd = new MySqlCommand("UpTraspasoPiloto", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("xidpilotoA", idPilotoA);
            cmd.Parameters.AddWithValue("xidpilotoB", idPilotoB);
            cmd.Parameters.AddWithValue("xidescuderiaA", idEscuderiaA);
            cmd.Parameters.AddWithValue("xidescuderiaB", idEscuderiaB);

            cmd.ExecuteNonQuery();
        }
    }
}

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
    public class AddPilotoDAO
    {
        public List<string> LlenarEscuderias(MySqlConnection conexion)
        {
            List<string> escuderias = new List<string>();
            string query = @"SELECT e.Escuderia
                            FROM Escuderia e
                            LEFT JOIN Piloto p ON e.idEscuderia = p.Escuderia_idEscuderia
                            GROUP BY e.idEscuderia, e.Escuderia
                            HAVING COUNT(p.idPiloto) < 2;
                            ";

            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    escuderias.Add(reader["Escuderia"].ToString());
                }
            }

            return escuderias;
        }

        public bool AgregarPiloto(MySqlConnection conexion, Pilotos piloto, int idEscuderia)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("AddPiloto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter outParam = new MySqlParameter("@xidpiloto", MySqlDbType.Int32);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);

                cmd.Parameters.AddWithValue("@xnombre", piloto.Nombre);
                cmd.Parameters.AddWithValue("@xnacionalidad", piloto.Nacionalidad);
                cmd.Parameters.AddWithValue("@xidescuderia", idEscuderia);

                cmd.ExecuteNonQuery();
                piloto.IDPiloto = (int)cmd.Parameters["@xidpiloto"].Value;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

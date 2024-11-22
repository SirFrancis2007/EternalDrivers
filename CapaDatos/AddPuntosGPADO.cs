using CapaEntidad;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Temporada;

namespace CapaDatos
{
    public class AddPuntosGPADO
    {
        public List<string> ObtenerPilotos(MySqlConnection conn)
        {
            List<string> pilotos = new List<string>();

            string query = "SELECT Nombre FROM Piloto";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pilotos.Add(reader["Nombre"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener pilotos: {ex.Message}");
            }

            return pilotos;
        }

        public bool InsertarResultadoCarrera(string nombrePiloto, int posicion, int puntos, MySqlConnection conexion, int idGranPremio)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("AddRtaCarrera", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new MySqlParameter("@xidResultadosCarrera", MySqlDbType.Int32));
                    cmd.Parameters["@xidResultadosCarrera"].Direction = ParameterDirection.Output;

                    int idPiloto = idpiloto(nombrePiloto, conexion); 

                    cmd.Parameters.AddWithValue("@xPosicion", posicion);
                    cmd.Parameters.AddWithValue("@xPuntos", puntos);
                    cmd.Parameters.AddWithValue("@xPiloto_idPiloto", idPiloto);
                    cmd.Parameters.AddWithValue("@xGranPremio_idGranPremio", idGranPremio); 

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al llamar al procedimiento almacenado: {ex.Message}");
                return false;
            }
        }

        public int idpiloto (string nombrePiloto, MySqlConnection conexion)
        {
            int idPiloto = -1;
            var query = @"Select idpiloto from piloto where piloto.Nombre = @nombrepiloto";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombrePiloto", nombrePiloto);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        idPiloto = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el ID del piloto: {ex.Message}");
            }


            return idPiloto;
        }
    }
}

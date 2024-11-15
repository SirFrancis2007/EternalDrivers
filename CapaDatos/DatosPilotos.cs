using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosPilotos
    {
        static public List<CapaEntidad.Pilotos> mtdPilotos(MySqlConnection conexion)
        {
            var Corredores = new List<Pilotos>();

            // Consulta para obtener los datos de la tabla Piloto
            string query = @"SELECT piloto.Nombre, piloto.Nacionalidad, escuderia.Escuderia, SUM(resultadoscarrera.Puntos) AS TotalPuntos
                                FROM piloto
                                JOIN escuderia ON piloto.Escuderia_idEscuderia = escuderia.idEscuderia
                                JOIN resultadoscarrera ON piloto.idPiloto = resultadoscarrera.Piloto_idPiloto
                                GROUP BY piloto.Nombre, piloto.Nacionalidad, escuderia.Escuderia;";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader reader = command.ExecuteReader();

                // Leer los resultados y añadirlos a la lista de pilotos
                while (reader.Read())
                {
                    CapaEntidad.Pilotos Corredor = new CapaEntidad.Pilotos();
                    Corredor.Nombre = reader["Nombre"].ToString();
                    Corredor.Nacionalidad = reader["Nacionalidad"].ToString();
                    Corredor.Escuderia = reader["Escuderia"].ToString();
                    Corredor.PuntosTotales = Convert.ToInt32(reader["TotalPuntos"]);
                    Corredores.Add(Corredor);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                conexion.Close();
            }
            return Corredores;
        }
    }
}

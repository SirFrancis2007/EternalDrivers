using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using MySql.Data.MySqlClient;
using static CapaEntidad.Temporada;

namespace CapaDatos
{
    public class DatosTemporada
    {
        MySqlConnection conexion = new MySqlConnection();
        public DatosTemporada()
        {
            mtdDatosTemporada(conexion);
            mtdMundialConstructores(conexion);
        }

        static public List<CapaEntidad.Temporada.Piloto> mtdDatosTemporada(MySqlConnection conexion)
        {
            var pilotos = new List<Piloto>();
            string query = @"SELECT 
                        piloto.Nombre AS Piloto, 
                        escuderia.Escuderia AS Escuderia, 
                        SUM(resultadoscarrera.Puntos) AS TotalPuntos
                     FROM piloto
                     JOIN escuderia ON piloto.Escuderia_idEscuderia = escuderia.idEscuderia
                     JOIN resultadoscarrera ON piloto.idPiloto = resultadoscarrera.Piloto_idPiloto
                     GROUP BY piloto.Nombre, escuderia.Escuderia
                     ORDER BY TotalPuntos DESC;";
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CapaEntidad.Temporada.Piloto piloto = new CapaEntidad.Temporada.Piloto
                    {
                        NombrePiloto = reader["Piloto"].ToString(),
                        EscuderiaPiloto = reader["Escuderia"].ToString(),
                        TotalPuntos = Convert.ToInt32(reader["TotalPuntos"])
                    };
                    pilotos.Add(piloto);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
            }

            return pilotos;
        }


        static public List<CapaEntidad.Temporada.Escuderia> mtdMundialConstructores(MySqlConnection conexion)
        {
            var escuderias = new List<CapaEntidad.Temporada.Escuderia>();
            string query = @"SELECT 
                                escuderia.Escuderia AS Escuderia, 
                                SUM(resultadoscarrera.Puntos) AS TotalPuntos
                             FROM piloto
                             JOIN escuderia ON piloto.Escuderia_idEscuderia = escuderia.idEscuderia
                             JOIN resultadoscarrera ON piloto.idPiloto = resultadoscarrera.Piloto_idPiloto
                             GROUP BY escuderia.Escuderia
                             ORDER BY TotalPuntos DESC;";

            try
            {
                MySqlCommand command = new MySqlCommand(query, conexion);
                MySqlDataReader reader = command.ExecuteReader();

                // Leer los resultados y añadirlos a la lista de pilotos
                while (reader.Read())
                {
                    CapaEntidad.Temporada.Escuderia escuderia = new CapaEntidad.Temporada.Escuderia();
                    escuderia.NombreEscuderia = reader["Escuderia"].ToString();
                    escuderia.TotalPuntos = reader.GetInt32("TotalPuntos");
                    escuderias.Add(escuderia);
                }

                reader.Close();
            }
            catch
            {
                conexion.Close();
            }

            return escuderias;
        }
    }
}

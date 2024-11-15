using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosGranPremio
    {
        public DataTable ObtenerResultadosCarrera(MySqlConnection conn, int idGranPremio)
        {
            string query = @"SELECT piloto.Nombre AS Piloto, escuderia.Escuderia AS Escuderia, resultadoscarrera.Posicion, resultadoscarrera.Puntos
                             FROM piloto
                             JOIN escuderia ON piloto.Escuderia_idEscuderia = escuderia.idEscuderia
                             JOIN resultadoscarrera ON piloto.idPiloto = resultadoscarrera.Piloto_idPiloto
                             JOIN granpremio ON resultadoscarrera.GranPremio_idGranPremio = granpremio.idGranPremio
                             WHERE granpremio.idGranPremio = @idGranPremio
                             ORDER BY resultadoscarrera.Posicion ASC;";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idGranPremio", idGranPremio);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public DataRow ObtenerDatosGranPremio(MySqlConnection conn, int idGranPremio)
        {
            string query = @"SELECT GranPremio, Pais, Longitud, Descripcion
                             FROM granpremio
                             WHERE idGranPremio = @idGranPremio";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idGranPremio", idGranPremio);

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}

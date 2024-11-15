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
    public class AddAuxPilotoDAO
    {
        public List<string> mtdEscuderia(MySqlConnection conexion)
        {
            List<string> escuderias = new List<string>();
            string query = @"SELECT escuderia.Escuderia
                             FROM Escuderia
                             JOIN Piloto ON piloto.Escuderia_idEscuderia = escuderia.idEscuderia
                             GROUP BY escuderia.Escuderia
                             HAVING COUNT(piloto.Nombre) < 2;";

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

        /*mtd que verifica que no exista ningun piltoo repetido*/
        protected bool VerificarExistenciaPiloto(MySqlConnection conexion, string nombreCompleto)
        {
            try
            {
                string queryVerificar = "SELECT VerificarPilotoExistente(@nombreCompleto)";
                using (MySqlCommand cmd = new MySqlCommand(queryVerificar, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                    return Convert.ToBoolean(cmd.ExecuteScalar());
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool mtdAddPiloto(MySqlConnection conexion, Pilotos piloto)
        {
            try
            {
                if (VerificarExistenciaPiloto(conexion, piloto.Nombre))
                {
                    return false;
                }

                MySqlCommand cmd = new MySqlCommand("AddPiloto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter outParam = new MySqlParameter("@xidpiloto", MySqlDbType.Int32);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);

                cmd.Parameters.AddWithValue("@xnombre", piloto.Nombre);
                cmd.Parameters.AddWithValue("@xnacionalidad", piloto.Nacionalidad);
                cmd.Parameters.AddWithValue("@xidescuderia", piloto.IdEscuderia);

                cmd.ExecuteNonQuery();
                piloto.IDPiloto = (int)cmd.Parameters["@xidpiloto"].Value;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int ObtenerIdEscuderia(MySqlConnection conexion, string escuderia)
        {
            string query = @"SELECT idescuderia FROM escuderia WHERE escuderia = @nombre";
            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@nombre", escuderia);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
    }
}

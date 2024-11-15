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
    public class AddMonoplazaDAO
    {
        public bool AgregarMonoplaza(MySqlConnection conexion, Monoplaza monoplaza)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("AddMonoplaza", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter outParam = new MySqlParameter("@xidmonoplaza", MySqlDbType.Int32);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);

                cmd.Parameters.AddWithValue("@xMonoplaza", monoplaza.Version);
                cmd.Parameters.AddWithValue("@xPotencia", monoplaza.HP);
                cmd.Parameters.AddWithValue("@xMotor", monoplaza.Motor);
                cmd.Parameters.AddWithValue("@xEscuderia", monoplaza.EscuderiaId);

                cmd.ExecuteNonQuery();

                monoplaza.Id = (int)cmd.Parameters["@xidmonoplaza"].Value;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string Escuderia(MySqlConnection conexion, int idescuderia)
        {
            try
            {
                string query = @"SELECT Escuderia FROM escuderia WHERE idEscuderia = @idEscuderia";
                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idEscuderia", idescuderia);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

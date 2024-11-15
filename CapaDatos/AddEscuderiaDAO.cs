using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Escuderia;

namespace CapaDatos
{
    public class AddEscuderiaDAO
    {
        public bool AgregarEscuderia(MySqlConnection conexion, Escuderia escuderia)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("AddEscuderia", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new MySqlParameter("@xescuderia", escuderia.Nombre));
                cmd.Parameters.Add(new MySqlParameter("@xpais", escuderia.Pais));
                cmd.Parameters.Add(new MySqlParameter("@xjefeequipo", escuderia.JefeEquipo));

                MySqlParameter outParam = new MySqlParameter("@xidescuderia", MySqlDbType.Int32);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);

                cmd.ExecuteNonQuery();
                escuderia.Id = (int)outParam.Value;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

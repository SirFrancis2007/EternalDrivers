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
    public class DatosMonoplazaDAO
    {
        public DataTable mtdDatosMonoplaza (MySqlConnection conexion)
        {
            var query = @"select Monoplaza, Potencia, Motor, Escuderia
                            from Monoplaza
                            join Escuderia using (idEscuderia)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
            catch
            {
                conexion.Close();
            }
            return new DataTable();
        }
    }
}

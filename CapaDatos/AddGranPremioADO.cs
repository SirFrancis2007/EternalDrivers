﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AddGranPremioADO
    {
        private MySqlConnection conexion;

        public AddGranPremioADO()
        {
            ConexionMysql conexionSql = new ConexionMysql();
            conexion = conexionSql.Conexion();
        }

        public int AgregarGranPremio(string nombre, string descripcion, float longitud, string pais)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("AddGP", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter outParam = new MySqlParameter("@xidGranPremio", MySqlDbType.Int32);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);

                cmd.Parameters.AddWithValue("@xGranPremio", nombre);
                cmd.Parameters.AddWithValue("@xDescripcion", descripcion);
                cmd.Parameters.AddWithValue("@xLongitud", longitud);
                cmd.Parameters.AddWithValue("@xPais", pais);

                cmd.ExecuteNonQuery();

                // Retornamos el id generado
                return Convert.ToInt32(outParam.Value);
            }
            catch
            {
                return -1; // Indicamos que hubo un error al agregar el Gran Premio
            }
        }

    }
}

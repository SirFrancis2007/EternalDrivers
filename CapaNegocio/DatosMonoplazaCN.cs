using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class DatosMonoplazaCN
    {
        private DatosMonoplazaDAO DatosMonoplazaDAO = new DatosMonoplazaDAO();

        public DataTable mtdDatosMonoplaza (MySqlConnection conexion)
        {
            return DatosMonoplazaDAO.mtdDatosMonoplaza(conexion);
        }
    }
}

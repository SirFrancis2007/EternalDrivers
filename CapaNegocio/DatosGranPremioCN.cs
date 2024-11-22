using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DatosGranPremioCN
    {
        private DatosGranPremio _granPremioDAO = new DatosGranPremio();

        public DataTable ObtenerResultadosCarrera(MySqlConnection conn, string nombreGranPremio)
        {
            return _granPremioDAO.ObtenerResultadosCarrera(conn, nombreGranPremio);
        }

        public DataRow ObtenerDatosGranPremio(MySqlConnection conn, string nombreGranPremio)
        {
            return _granPremioDAO.ObtenerDatosGranPremio(conn, nombreGranPremio);
        }
    }
}

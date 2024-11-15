using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DelGranPremioCN
    {
        private DelGranPremio granPremioData = new DelGranPremio();

        public List<string> ObtenerGranPremios(MySqlConnection conn)
        {
            return granPremioData.ObtenerGranPremios(conn);
        }

        public bool EliminarGranPremio(string nombreGranPremio, MySqlConnection conn)
        {
            return granPremioData.EliminarGranPremio(nombreGranPremio, conn);
        }
    }
}

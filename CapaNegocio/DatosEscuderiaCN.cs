using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DatosEscuderiaCN
    {
        private DatosEscuderia DatosEscuderia = new DatosEscuderia();
        public Dictionary<string, string> ObtenerDatosEscuderia(MySqlConnection conn, int idEscuderia)
        {
            DatosEscuderia.ObtenerDatosEscuderia(conn, idEscuderia, out var escuderiaData);
            return escuderiaData;
        }

        public List<string> ObtenerCorredores(MySqlConnection conn, int idEscuderia)
        {
            return DatosEscuderia.ObtenerCorredores(conn, idEscuderia);
        }
    }
}

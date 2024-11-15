using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DelEscuderiaCN
    {
        private DelEscuderiaDAO escuderiaData;

        public DelEscuderiaCN()
        {
            escuderiaData = new DelEscuderiaDAO();
        }

        public List<string> ObtenerEscuderias(MySqlConnection conn)
        {
            return escuderiaData.ObtenerEscuderias(conn);
        }

        public bool EliminarEscuderia(string nombreEscuderia, MySqlConnection conn)
        {
            return escuderiaData.EliminarEscuderia(nombreEscuderia, conn);
        }
    }
}

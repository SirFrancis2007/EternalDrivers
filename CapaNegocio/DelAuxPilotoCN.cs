using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DelAuxPilotoCN
    {
        private DelAuxPilotoDAO pilotoeliminado;

        public DelAuxPilotoCN()
        {
            pilotoeliminado = new DelAuxPilotoDAO();
        }

        public List<string> ObtenerEscuderias(MySqlConnection conn)
        {
            return pilotoeliminado.ObtenerEscuderias(conn);
        }

        public List<string> ObtenerPilotosPorEscuderia(MySqlConnection conn, string escuderia)
        {
            return pilotoeliminado.ObtenerPilotosPorEscuderia(conn, escuderia);
        }

        public bool EliminarPiloto(MySqlConnection conn, string nombrePiloto, string nombreEscuderia)
        {
            if (!pilotoeliminado.PuedeEliminarEscuderia(conn, nombreEscuderia))
            {
                return false;
            }

            return pilotoeliminado.EliminarPiloto(conn, nombrePiloto, nombreEscuderia);
        }
    }
}

using CapaDatos;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UpdTraspasoCN
    {
        private UpdTraspasoADO _traspaso = new UpdTraspasoADO();

        public DataTable ObtenerPilotos(MySqlConnection conn)
        {
            return _traspaso.ObtenerPilotos(conn);
        }

        public List<Pilotos> ObtenerListaPilotos(MySqlConnection conn)
        {
            return _traspaso.ObtenerListaPilotos(conn);
        }

        public void TraspasarPilotos(MySqlConnection conn, int idPilotoA, int idPilotoB)
        {
            int idEscuderiaA = _traspaso.ObtenerEscuderiaActual(conn, idPilotoA);
            int idEscuderiaB = _traspaso.ObtenerEscuderiaActual(conn, idPilotoB);

            _traspaso.EjecutarTraspaso(conn, idPilotoA, idPilotoB, idEscuderiaA, idEscuderiaB);
        }
    }
}

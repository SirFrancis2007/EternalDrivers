using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class AddAuxPilotoCN
    {
        private readonly AddAuxPilotoDAO pilotonuevo = new AddAuxPilotoDAO();

        public List<string> mtdEscuderiaCN(MySqlConnection conexion)
        {
            return pilotonuevo.mtdEscuderia(conexion);
        }

        public bool AgregarPiloto(MySqlConnection conexion, Pilotos piloto)
        {
            int idEscuderia = pilotonuevo.ObtenerIdEscuderia(conexion, piloto.Escuderia);
            if (idEscuderia == -1)
            {
                return false; // No se encontró la escudería
            }
            piloto.IdEscuderia = idEscuderia; // Asigna el ID de la escudería al piloto
            return pilotonuevo.mtdAddPiloto(conexion, piloto);
        }
    }
}

using CapaDatos;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class AddPilotosCN
    {
        private readonly AddPilotoDAO _addPilotosDAO = new AddPilotoDAO();

        public List<string> ObtenerEscuderiasDisponibles(MySqlConnection conexion)
        {
            return _addPilotosDAO.LlenarEscuderias(conexion);
        }

        public (bool success, string mensajeError) AgregarPilotos(MySqlConnection conexion, string nombre1, string nombre2, string pais1, string pais2, string nombreEscuderia)
        {
            // Obtiene el ID de la escudería basándose en el nombre de la escudería proporcionado.
            int idEscuderia = ObtenerIdEscuderia(conexion, nombreEscuderia);
            if (idEscuderia == -1)
            {
                return (false, "Escudería no encontrada");
            }

            Pilotos piloto1 = new Pilotos { Nombre = nombre1, Nacionalidad = pais1, IdEscuderia = idEscuderia };
            Pilotos piloto2 = new Pilotos { Nombre = nombre2, Nacionalidad = pais2, IdEscuderia = idEscuderia };

            if (_addPilotosDAO.AgregarPiloto(conexion, piloto1, idEscuderia) &&
                _addPilotosDAO.AgregarPiloto(conexion, piloto2, idEscuderia))
            {
                return (true, null);
            }
            else
            {
                return (false, "Error al agregar pilotos");
            }
        }

        public int ObtenerIdEscuderia(MySqlConnection conexion, string nombreEscuderia)
        {
            try
            {
                string query = @"SELECT idescuderia FROM escuderia WHERE escuderia = @nombre";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", nombreEscuderia);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch
            {
                return -1;
            }
        }
    }
}

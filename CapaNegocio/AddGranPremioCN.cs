using CapaDatos;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class AddGranPremioCN
    {
        private AddGranPremioADO granPremioDAO;
        private MySqlConnection conexion;

        public AddGranPremioCN()
        {
            granPremioDAO = new AddGranPremioADO();
        }

        public bool AgregarGranPremio(GranPremio granPremio)
        {
            return granPremioDAO.AgregarGranPremio(granPremio.Nombre, granPremio.Descripcion, granPremio.Longitud, granPremio.Pais, conexion);
        }
    }
}

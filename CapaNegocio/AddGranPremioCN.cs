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

        public AddGranPremioCN()
        {
            granPremioDAO = new AddGranPremioADO();
        }

        public bool AgregarGranPremio(GranPremio granPremio)
        {
            return granPremioDAO.AgregarGranPremio(granPremio.Id ,granPremio.Nombre, granPremio.Descripcion, granPremio.Longitud, granPremio.Pais);
        }
    }
}

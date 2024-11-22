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

        public bool AgregarGranPremio(GranPremio granPremio, out int idGranPremio)
        {
            idGranPremio = granPremioDAO.AgregarGranPremio(granPremio.Nombre, granPremio.Descripcion, granPremio.Longitud, granPremio.Pais);

            if (idGranPremio > 0)
            {
                granPremio.Id = idGranPremio; 
                return true;
            }

            return false; 
        }

    }
}

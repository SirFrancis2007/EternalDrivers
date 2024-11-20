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
            // Llamamos al método para agregar el Gran Premio y obtener el id generado
            int id = granPremioDAO.AgregarGranPremio(granPremio.Nombre, granPremio.Descripcion, granPremio.Longitud, granPremio.Pais);

            // Si la inserción fue exitosa (id debe ser mayor que 0), asignamos el id al objeto GranPremio
            if (id > 0)
            {
                granPremio.Id = id; // Asignamos el ID generado al objeto GranPremio
                return true;
            }

            return false; // Si el id es negativo, significa que hubo un error
        }

    }
}

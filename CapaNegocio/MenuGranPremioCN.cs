using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class MenuGranPremioCn
    {
        private MenuGranPremioDAO MenuGranPremioDAO = new MenuGranPremioDAO();
        
        public List<string> ObtenerGranPrmeioCN (MySqlConnection conexion)
        {
            return MenuGranPremioDAO.ObtenerGranPremios(conexion);
        }
    }
}

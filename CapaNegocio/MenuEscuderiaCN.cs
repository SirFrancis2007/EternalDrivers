using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class MenuEscuderiaCN
    {
        private MenuEscuderiaDAO menuEscuderiaDAO = new MenuEscuderiaDAO();
        public List<string> ObtenerEscuderiaCN (MySqlConnection conexion)
        {
            return menuEscuderiaDAO.ObtenerEscuderias(conexion);
        }
    }
}

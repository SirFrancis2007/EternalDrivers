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
    public class AddEscuderiaCN
    {
        private readonly AddEscuderiaDAO escuderiaDAO;

        public AddEscuderiaCN()
        {
            escuderiaDAO = new AddEscuderiaDAO();
        }

        public bool AgregarEscuderia(MySqlConnection conexion, Escuderia escuderia)
        {
            return escuderiaDAO.AgregarEscuderia(conexion, escuderia);
        }
    }
}

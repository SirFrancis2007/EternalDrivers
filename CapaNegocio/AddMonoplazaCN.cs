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
    public class AddMonoplazaCN
    {
        private readonly AddMonoplazaDAO _addMonoplazaADO = new AddMonoplazaDAO();

        public bool AgregarMonoplaza(MySqlConnection conexion, Monoplaza monoplaza)
        {
            return _addMonoplazaADO.AgregarMonoplaza(conexion, monoplaza);
        }

        public string ObtenerNombreEscuderia(MySqlConnection conexion, int idescuderia)
        {
            return _addMonoplazaADO.Escuderia(conexion, idescuderia);
        }
    }
}

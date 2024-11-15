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
    public class DatosPilotosCN
    {

        static internal List<Pilotos> mtdDatosPilotos(MySqlConnection conexion)
        {
            List<Pilotos> ListaDatoCorredores = new List<Pilotos>();
            try
            {
                ListaDatoCorredores = DatosPilotos.mtdPilotos(conexion);
            }
            catch (Exception ex)
            {
                conexion.Close();
            }

            return ListaDatoCorredores;
        }
    }
}

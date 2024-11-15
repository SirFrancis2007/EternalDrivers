using CapaDatos;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Temporada;

namespace CapaNegocio
{
    public class DatosTemporadaCN
    {
        private DatosTemporadaCN temporadaDAO;

        public DatosTemporadaCN()
        {
            ConexionMysql conexion = new ConexionMysql();
            MySqlConnection conn = conexion.Conexion();
            ObtenerDatosTemporada(conn);
            ObtenerMundialConstructores(conn);
        }

        static public List<Piloto> ObtenerDatosTemporada(MySqlConnection conexion)
        {

            List<Piloto> listaPilotos = new List<Piloto>();
            try
            {
                listaPilotos = DatosTemporada.mtdDatosTemporada(conexion);
            }
            catch (Exception ex)
            {
                conexion.Close();
            }
            return listaPilotos;
        }

        static public List<CapaEntidad.Temporada.Escuderia> ObtenerMundialConstructores(MySqlConnection conexion)
        {
            List<CapaEntidad.Temporada.Escuderia> listaEscuderias = new List<CapaEntidad.Temporada.Escuderia>();
            try
            {
                listaEscuderias = DatosTemporada.mtdMundialConstructores(conexion);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el mundial de constructores: " + ex.Message);
            }
            conexion.Close();

            return listaEscuderias;
        }
    }
}

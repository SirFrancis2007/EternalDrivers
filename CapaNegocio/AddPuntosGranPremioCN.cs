﻿using CapaDatos;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class AddPuntosGranPremioCN
    {
        private AddPuntosGPADO resultadoDatos = new AddPuntosGPADO();
        private Dictionary<int, int> puntosPorPosicion = new Dictionary<int, int>
        {
            { 1, 26 }, { 2, 18 }, { 3, 15 }, { 4, 12 }, { 5, 10 },
            { 6, 8 }, { 7, 6 }, { 8, 4 }, { 9, 2 }, { 10, 1 }
        };

        public List<string> ObtenerPilotos(MySqlConnection conn)
        {
            return resultadoDatos.ObtenerPilotos(conn);
        }

        public Pilotos AsignarPuntos(string nombrePiloto, int posicion)
        {
            int puntos = puntosPorPosicion.ContainsKey(posicion) ? puntosPorPosicion[posicion] : 0;
            return new Pilotos
            {
                Nombre = nombrePiloto,
                Posicion = posicion,
                PuntosTotales = puntos
            };
        }
    }
}

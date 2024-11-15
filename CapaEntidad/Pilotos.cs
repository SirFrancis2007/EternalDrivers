using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pilotos
    {
        public int IDPiloto { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public string Escuderia { get; set; }
        public int PuntosTotales { get; set; }
        public int IdEscuderia { get; set; }
        public int Posicion { get; set; }

    }
}

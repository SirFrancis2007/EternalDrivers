namespace CapaEntidad
{
    public class Temporada
    {
        public class Piloto
        {
            public string NombrePiloto { get; set; }
            public string EscuderiaPiloto { get; set; }
            public int TotalPuntos { get; set; }
        }

        public class Escuderia
        {
            public string NombreEscuderia { get; set; }
            public int TotalPuntos { get; set; }
        }
    }
}

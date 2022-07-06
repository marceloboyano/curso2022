using System;
using System.Collections.Generic;

namespace ejercicio.Models
{
    public partial class VideoJuego
    {
        public int VideoJuegoId { get; set; }
        public string Titulo { get; set; } = null!;
        public double HorasEstimadas { get; set; }
        public string Genero { get; set; } = null!;
        public string Compañia { get; set; } = null!;
    }
}

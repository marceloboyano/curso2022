using System;
using System.Collections.Generic;

namespace ejercicio.Models
{
    public partial class Series
    {
        public int SerieId { get; set; }
        public string Titulo { get; set; } = null!;
        public int NumeroTemporadas { get; set; }
        public string Genero { get; set; } = null!;
        public string Creador { get; set; } = null!;
    }
}

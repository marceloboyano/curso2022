namespace challenge.QueryFilters
{
    public class PeliculasQueryFilters
    {

        public string? Titulo { get; set; }
        public int? GeneroID { get; set; }
        public string? Orden { get; set; }
        /// <summary>
        /// Indicar true para traer todos los campos
        /// </summary>
        public bool Detalles { get; set; }

    }
}

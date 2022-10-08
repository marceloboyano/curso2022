namespace challenge.QueryFilters
{
    public class PeliculasQueryFilters
    {
        /// <summary>
        /// Buscar por por Titulo 
        /// </summary>
        public string? Titulo { get; set; }
        /// <summary>
        /// Buscar por Genero
        /// </summary>
        public int? GeneroID { get; set; }
        /// <summary>
        /// Deberá indicar ASC o DESC para buscar en orden ascendente o descendente
        /// </summary>
        public string? Orden { get; set; }
        /// <summary>
        /// Indicar true para traer todos los campos
        /// </summary>
        public bool Detalles { get; set; }

    }
}

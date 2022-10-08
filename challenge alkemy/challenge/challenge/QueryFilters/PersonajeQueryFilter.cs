namespace challenge.QueryFilters
{
    public class PersonajeQueryFilter
    {
        /// <summary>
        /// Buscar por por Nombre 
        /// </summary>
        public string? Nombre { get; set; }
        /// <summary>
        /// Buscar por por Edad 
        /// </summary>
        public int? Edad { get; set; }
        /// <summary>
        /// Buscar por por Pelicula 
        /// </summary>
        public int? PeliculaID { get; set; }
        /// <summary>
        /// Indicar true para traer todos los campos
        /// </summary>
        public bool Detalles { get; set; }


    }
}

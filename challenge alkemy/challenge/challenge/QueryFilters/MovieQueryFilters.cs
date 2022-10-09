namespace challenge.QueryFilters
{
    public class MovieQueryFilters
    {
        /// <summary>
        /// Buscar por por Titulo 
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Buscar por Genero
        /// </summary>
        public int? GenderID { get; set; }
        /// <summary>
        /// Deberá indicar ASC o DESC para buscar en orden ascendente o descendente
        /// </summary>
        public string? Order { get; set; }
        /// <summary>
        /// Indicar true para traer todos los campos
        /// </summary>
        public bool Details { get; set; }

    }
}

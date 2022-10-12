using System.ComponentModel.DataAnnotations;

namespace challenge.QueryFilters
{
    public class CharacterQueryFilter
    {
        /// <summary>
        /// Buscar por por Nombre 
        /// </summary>        
        public string? Name { get; set; }
        /// <summary>
        /// Buscar por por Edad 
        /// </summary>
        public int? Age { get; set; }
        /// <summary>
        /// Buscar por por Pelicula 
        /// </summary>
        public int? MovieID { get; set; }
        /// <summary>
        /// Indicar true para traer todos los campos
        /// </summary>
        public bool Details { get; set; }


    }
}

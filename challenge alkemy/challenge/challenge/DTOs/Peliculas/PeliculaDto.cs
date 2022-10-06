namespace challenge.DTOs.Peliculas
{
    public class PeliculaDTO
    {
        public record PeliculaForShowDTO(string Imagen, string Titulo, DateTime FechaCreacion);
        public record PeliculaForUpateDTO(string Titulo, DateTime FechaCreacion, int Calificacion, string Imagen);
        // public record PeliculaForCreation
        // public record PeliculaForUpdate
        // .. Es conveniente ir creando un dto por separado para cada caso particular, asi cada modificación no afecta a todas las operaciones
        // y solamente usas las propiedades que te interesan para cada caso
    }
}

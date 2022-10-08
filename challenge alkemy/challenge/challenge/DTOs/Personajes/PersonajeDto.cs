namespace challenge.DTOs.Personajes
{

    public class PersonajeDto
    {
        public record PersonajeForShowDTO(string Nombre, string Imagen);
        public record PersonajeForUpdateDTO(string? Nombre, decimal? Peso, string? Historia, string? Imagen);
        public record PersonajeForCreationDTO(string Nombre, decimal Peso, string Historia, string Imagen);
    }
}

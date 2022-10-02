namespace challenge.Controllers
{
    internal class PeliculaDTO
    {
        private object imagen;
        private object titulo;
        private object fechaCreacion;

        public PeliculaDTO(object imagen, object titulo, object fechaCreacion)
        {
            this.imagen = imagen;
            this.titulo = titulo;
            this.fechaCreacion = fechaCreacion;
        }
    }
}
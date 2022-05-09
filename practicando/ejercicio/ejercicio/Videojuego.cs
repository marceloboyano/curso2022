




using ejercicio;

namespace ejercicio1
{
    public class VideoJuego : IEntregable
    {

        private bool entregado;
        public string Titulo { get; set; }
        public double HorasEstimadas { get; set; } = 10;
        public string Genero { get; set; }
        public string Compañia { get; set; }

        
        public VideoJuego()
        { }
        public VideoJuego(string _titulo, double _horasEstimadas)
        {
            Titulo = _titulo;
            HorasEstimadas = _horasEstimadas;
        }
        public VideoJuego(string _titulo, double _horasEstimadas, string _genero, string _compañia) : this(_titulo, _horasEstimadas)
        {
            Genero = _genero;
            Compañia = _compañia;
        }

        public override string ToString() => $"Títlo: {Titulo}, Genero: {Genero}, Compañía: {Compañia}, Horas Estimadas: {HorasEstimadas} ";

      public  int contador;
          public  bool IsEntregado()
            {
                return entregado;
            }

           public void Entregar()
            {
                contador++;
                entregado = true;
            }
            public void Devolver()
            {
                entregado = false;
            }
     
           public bool CompareTo(object a)
        {
           
            return ((Serie)a).NumeroTemporadas == this.HorasEstimadas;
        }
    }
}

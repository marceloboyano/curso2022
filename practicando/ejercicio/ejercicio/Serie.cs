

namespace ejercicio
{
    public class Serie: IEntregable
    {
        //private string titulo;
        //private int numeroTemporadas = 3;
        //private bool entregado;
        //private string genero;
        //private string creador;

        private bool entregado; // Lo dejamos como atributo simple debido a que no se requiere ni getter ni setter. El default=false no es necesario porque todo booleano se inicializa como false

        // Acostumbrate a trabajar siempre con propiedades en C#. Siempre que necesiten un accesor o un setter tienen que ser la primera opción
        // El estandar de microsoft establece que tienen que ser PascalCase
        public string Titulo { get; set; }
        public int NumeroTemporadas { get; set; } = 3; // Default
        public string Genero { get; set; }
        public string Creador { get; set; }


        // Existe el atajo init desde C# 9 que te genera los constructores automaticamente
        //public string Titulo { get; init; }
        //public int NumeroTemporadas { get; init; } = 3; // Default
        //public string Genero { get; init; }
        //public string Creador { get; init; }

        // El estandar de microsoft establece que tienen que ser PascalCase
        // No se suele utilizar 'this' para las propiedades de clase en C#, eso es más cosa de Java. En C# se suele diferenciar atributos de clase agregandoles un guion bajo. Ejemplo: _atributo=atributo
        // https://docs.microsoft.com/es-es/dotnet/csharp/fundamentals/coding-style/coding-conventions
        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
            : this(titulo, creador)
        {
            Genero = genero;
            NumeroTemporadas = numeroTemporadas;

            // Para no reescribir código en este punto llamamos al otro constructor VER this más arriba
            //Titulo = titulo;
            //Creador = creador;
        }

        public Serie(string titulo, string creador) // Esto es raro de ver en C#, C# ofrece atajos para inicializar de esta manera https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
        {
            Titulo = titulo;
            Creador = creador;
        }
        public Serie()
        {
        }

    public override string ToString() => $"titulo: {Titulo} numero de temporadas: {NumeroTemporadas}  genero: {Genero} creador: {Creador}";


       public int contador;
           public bool IsEntregado() {
                return entregado; }

           public  void Entregar()
            {
                entregado = true;
                contador++;
            }
           public  void Devolver()
            {
                entregado = false;
            }
     


       



    }


}

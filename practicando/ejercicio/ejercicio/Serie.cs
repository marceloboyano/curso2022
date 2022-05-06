/*Crearemos una clase llamada Serie con las siguientes caracteristicas: Sus atributos son titulo, numero de t
 * emporadas, entregado, genero y creador.
 * Por defecto, el numero de temporadas es de 3 temporadas y entregado false.
 * El resto de atributos serán valores por defecto según el tipo de atributo. 
 * Los constructores que se implementaran serán:
 * Un constructor por defecto.
 * Un constructor con el titulo y creador.
 * El resto por defecto. Un constructor con todos los atributos, excepto de entregado.
 * Los metodos que se implementara serán:
 * Métodos get de todos los atributos, excepto de entregado.
 * Metodos set de todos los atributos, excepto entregado. Sobreescribe los metodos toString. */

// Acostumbrate a usar Pascal Case para los nombres de clases y propiedades y Camel Case para las variables y atributos
Serie walkingDead = new Serie("peterpan",4,"accion","travolta");
Console.WriteLine(walkingDead.ToString());
Console.WriteLine("titulo: " + walkingDead.Titulo + " numero de temporadas: " + walkingDead.NumeroTemporadas+ " genero: "+ walkingDead.Genero+" creador: "+ walkingDead.Creador);

// El estandar de microsoft establece que tienen que ser PascalCase
public class Serie
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

    // El estandar de microsoft establece que tienen que ser PascalCase
    // No se suele utilizar 'this' para las propiedades de clase en C#, eso es más cosa de Java. En C# se suele diferenciar atributos de clase agregandoles un guion bajo. Ejemplo: _atributo=atributo
    // https://docs.microsoft.com/es-es/dotnet/csharp/fundamentals/coding-style/coding-conventions
    public Serie(string titulo, int numeroTemporadas, string genero, string creador) 
        : this(titulo,creador)
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

    //public string Titulo { get => titulo; set => titulo = value; }
    //public int NumeroTemporadas { get => numeroTemporadas; set => numeroTemporadas = value; }
    //public string Genero { get => genero; set => genero = value; }
    //public string Creador { get => creador; set => creador = value; }

    public override string ToString() => $"titulo: {Titulo} numero de temporadas: {NumeroTemporadas}  genero: {Genero} creador: {Creador}";



}





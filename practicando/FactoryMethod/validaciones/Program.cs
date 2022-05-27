


using FizzBuzz;

int inferior;
int superior;
bool validI;
bool validS;

Console.Write("Ingrese el limite inferior de tipo entero: ");
validI = int.TryParse(Console.ReadLine(), out inferior);
Console.Write("Ingrese el limite Superior de tipo entero: ");
validS = int.TryParse(Console.ReadLine(), out superior);


static void Show(string v)
{
    Console.WriteLine(v);
}

Action<string> Output = Show;


// No necesitamos instancia, porque el m�todo que utilizamos es EST�TICO --> buscar qu� significa
// El mismo caso sucede con Console.WriteLine (nunca instanciamos --> new Console()... s�lo usamos el m�todo)
//FizzBuzzFabrica Fito = new FizzBuzzFabrica(inferior, superior);


var fizzbuzz = FizzBuzzFabrica.ObtenerInstancia("FiZZBuzzConsola", inferior, superior);
fizzbuzz.execute();

var fizzbuzzArchivo = FizzBuzzFabrica.ObtenerInstancia("FizzBuzzArchivo", inferior, superior);
fizzbuzzArchivo.execute();




using FizzBuzz;

int inferior;
int superior;
bool validI;
bool validS;

Console.Write("Ingrese el limite inferior de tipo entero: ");
validI = int.TryParse(Console.ReadLine(), out inferior);
Console.Write("Ingrese el limite Superior de tipo entero: ");
validS = int.TryParse(Console.ReadLine(), out superior);





// No necesitamos instancia, porque el m�todo que utilizamos es EST�TICO --> buscar qu� significa
// El mismo caso sucede con Console.WriteLine (nunca instanciamos --> new Console()... s�lo usamos el m�todo)
//FizzBuzzFabrica Fito = new FizzBuzzFabrica(inferior, superior);


var fizzbuzz = FizzBuzzFabrica<FizzBuzzHttp>.ObtenerInstancia(inferior, superior);
fizzbuzz.execute();
//var fizzbuzz = FizzBuzzFabrica<FizzBuzzConsola>.ObtenerInstancia(inferior, superior);
//fizzbuzz.execute();

//var fizzbuzzArchivo = FizzBuzzFabrica<FizzBuzzArchivo>.ObtenerInstancia(inferior, superior);
//fizzbuzzArchivo.execute();

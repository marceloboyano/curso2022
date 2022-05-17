


using validaciones;

int inferior;
int superior;
bool validI;
bool validS;

Console.Write("Ingrese el limite inferior de tipo entero: ");
validI = int.TryParse(Console.ReadLine(), out inferior);
Console.Write("Ingrese el limite Superior de tipo entero: ");
validS = int.TryParse(Console.ReadLine(), out superior);

if (!(!validI || !validS || !validS && validI))
{
    FizzBuzz Fito = new FizzBuzz(inferior, superior);
   
    
}

Console.WriteLine("No ha ingresado valores enteros en los limites");




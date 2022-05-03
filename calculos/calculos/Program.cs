Console.Clear();

Console.WriteLine("Este programa calcula la superficie de un rectangulo");
Console.WriteLine();

Console.WriteLine("Ingrese la Base del Rectangulo");
double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectangulo");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = baseRectangulo * alturaRectangulo;
 Console.WriteLine("La superficie del rectangulo es: ");
Console.WriteLine(superficieRectangulo);

bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    //Mostramos el mensaje solamente si es mayor a diez
    Console.WriteLine("La superficie del rectangulo es mayor a diez");
}

Console.ReadKey(); 
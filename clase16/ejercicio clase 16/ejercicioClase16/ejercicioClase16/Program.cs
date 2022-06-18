//Diseñe la siguiente jerarquía para las clases:

//Cuadrilátero.
//Trapecio.
//Rectángulo.
//Cuadrado.

//Use la clase Cuadrilátero como la clase base de la jerarquía, que debe ser abstracta.

//Los datos privados de la clase base deben ser las coordenadas x-y de los cuatro vértices de la figura y debe contener un método abstracto para calcular el área.

//Agregue un constructor a cada clase para inicializar sus datos e invoque el constructor de la clase base desde el constructor de cada clase derivada.

//Escriba un programa que instancie objetos de cada una de las clases y calcule el área correspondiente. Investigue las fórmulas para calcular el área de cada figura.


using ejercicioClase16.Modelos;
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\t╔════════════════════════════════════════════════════════════════════════╗ ");
Console.WriteLine("\t║   Bienvenido!! vamos a calcular el área de una figura cuadrilatera     ║ ");
Console.WriteLine("\t║   1- CUADRADO                                                          ║ ");
Console.WriteLine("\t║   2- RECTANGULO                                                        ║ ");
Console.WriteLine("\t║   3- TRAPECIO                                                          ║ ");
Console.WriteLine("\t╚════════════════════════════════════════════════════════════════════════╝ ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("OPCION: ");
var opcion = int.Parse(Console.ReadLine());
Console.WriteLine("══════════════════════════════════════════════════════════════════════════════════");
Console.WriteLine("Ingrese las cordenadas x,y de cada uno de los vertices de su figura");
Console.Write("Vertice Nº1 x: ");
var x = int.Parse(Console.ReadLine());
Console.Write("Vertice Nº1 y: ");
var y = int.Parse(Console.ReadLine());
var v1 = new[] { x, y };
Console.WriteLine();
Console.Write("Vertice Nº2 x: ");
x = int.Parse(Console.ReadLine());
Console.Write("Vertice Nº2 y: ");
y = int.Parse(Console.ReadLine());
var v2 = new[] { x, y };
Console.WriteLine();
Console.Write("Vertice Nº3 x: ");
x = int.Parse(Console.ReadLine());
Console.Write("Vertice Nº3 y: ");
y = int.Parse(Console.ReadLine());
var v3 = new[] { x, y };
Console.WriteLine();
Console.Write("Vertice Nº4 x: ");
x = int.Parse(Console.ReadLine());
Console.Write("Vertice Nº4 y: ");
y = int.Parse(Console.ReadLine());
var v4 = new[] { x, y };
Console.WriteLine("══════════════════════════════════════════════════════════════════════════════════");
switch (opcion)
{
    case 1:
        var cuadrado = new Cuadrado(v1, v2, v3, v4);
        Console.Write("El area de su Cuadrado es: " + cuadrado.CalcularArea());
        break;
    case 2:
        var rectangulo = new Rectangulo(v1, v2, v3, v4);
        Console.Write("El area de su Rectangulo es: " + rectangulo.CalcularArea());
        break;
    case 3:
        var trapecio = new Trapecio(v1, v2, v3, v4);
        Console.Write("El area de su Trapecio es: " + trapecio.CalcularArea());
        break;
    default:
        Console.WriteLine("Opcion Incorrecta");
        break;
}

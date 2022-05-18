
string[] cars = { "Ford", "Fiat", "BMW", "Toyota" };

Console.WriteLine(cars[0]);

string[] frutas = new string[4];

frutas[0] = "Pera";
frutas[1] = "Manzana";
frutas[2] = "Banana";
frutas[2] = "Kiwi";


Console.WriteLine(frutas[2]);
Console.WriteLine(frutas[3]);// devuelve vacio por ser definido como string -NO ES NULL-

int [] numeros = new int[5];
Console.WriteLine($"el array tiene: {numeros.Length} posiciones");

//Console.WriteLine("Ingrese los valores de la matriz");

//Ints[0] =  int.Parse(Console.ReadLine());
//Ints[1] = int.Parse(Console.ReadLine());
//Ints[2] = int.Parse(Console.ReadLine());
//Ints[3] = int.Parse(Console.ReadLine());
//Ints[4] = int.Parse(Console.ReadLine());

for (int i = 0;i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el numero: {i+1} ");
    numeros[i] = int.Parse(Console.ReadLine());
}
int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

Console.WriteLine("Los valores son:");
for (int i = 0; i < numeros.Length; i++)
{

    Console.Write(numeros[i]+",");
    
}
Console.WriteLine("La suma de todos los valores es: " + suma);

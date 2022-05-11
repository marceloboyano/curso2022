
string condicion = "S";

while (condicion == "S")
{
    Console.Clear();
    Console.Write("Ingrese su nombre:");
    string nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre}");
    Console.Write("Desea Continuar - S/N: ");
    condicion = Console.ReadLine().ToUpper();
}
if (condicion == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opcion no valida");
}
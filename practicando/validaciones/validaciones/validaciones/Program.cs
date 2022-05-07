


int inferior;
int superior;
bool validI;
bool validS;

Console.Write("Ingrese el limite inferior de tipo entero: ");
 validI = int.TryParse(Console.ReadLine(), out inferior);
if (!validI)
{
    Console.WriteLine("No ha ingresado un numero entero");
    return;
} 
Console.Write("Ingrese el limite Superior de tipo entero: ");
 validS = int.TryParse(Console.ReadLine(), out superior);
if (!validS)
{
    Console.WriteLine("No ha ingresado un numero entero:");
    return;

}
if (inferior < 0 && superior < 0)
{
    Console.Write("Los limites ingresados son incorrectos, no pueden ser ni 0 ni un numeros negativo:" +inferior +","+superior);
    return;
}
if (superior < inferior)
{
    Console.Write("El limite superior no puede ser menor que el limite inferior:" + inferior + "," + superior);
    return;
}



for (int i = inferior; i <= superior; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("FIZZ");
        if (i % 5 == 0)
        {
            Console.WriteLine("FIZZBUZZ");
        }

    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine("numero: " + i);
    }
}




int inferior;
int superior;
bool validI;
bool validS;

Console.Write("Ingrese el limite inferior de tipo entero: ");
validI = int.TryParse(Console.ReadLine(), out inferior);

Console.Write("Ingrese el limite Superior de tipo entero: ");
validS = int.TryParse(Console.ReadLine(), out superior);
Validaciones(inferior, superior, validI, validS);
Fizzbuzz(inferior,superior);


 void Validaciones(int inferior, int superior, bool validI, bool validS)
{

    if (!validI)
    {
        Console.WriteLine("No ha ingresado un numero entero");
        return;
    }

    if (!validS)
    {
        Console.WriteLine("No ha ingresado un numero entero:");
        return;

    }
    if (inferior < 0 && superior < 0)
    {
        Console.Write("Los limites ingresados son incorrectos, no pueden ser ni 0 ni un numeros negativo:" + inferior + "," + superior);
        return;
    }
    if (superior < inferior)
    {
        Console.Write("El limite superior no puede ser menor que el limite inferior:" + inferior + "," + superior);
        return;
    }

}
void Fizzbuzz(int inferior, int superior)
{
    for (int i = inferior; i <= superior; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FIZZBUZZ");

        }
        else if (i % 5 != 0 && i % 3 != 0)
        {
            Console.WriteLine("numero: " + i);
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("BUZZ");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("FIZZ");
        }

    }
}
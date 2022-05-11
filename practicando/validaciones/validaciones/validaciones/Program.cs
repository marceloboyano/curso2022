


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

Fizzbuzz(inferior,superior);


 bool Validaciones(int inferior, int superior)
{


    if (inferior < 0)
    {      
        return false;
    }
    else if (superior < 0)
    {
        return false;
    }

    if (superior < inferior)
    {
      return false;
    }
    if(inferior > 10000)
    {
        return false;
    }else if (superior > 10000)
    {
        return false;
    }
    return true;


}
void Fizzbuzz(int inferior, int superior)
{

    if ((Validaciones(inferior, superior))) 
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
    }else
    {
        Console.WriteLine("Los Datos ingresados son incorrectos." +
            "\n* No se puede ingresar numeros negativos" +
            " \n* El limite superior no puede ser menor que el limite inferior" +
            " \n* los limites no pueden ser mayores que 10mil");
    }
    
}

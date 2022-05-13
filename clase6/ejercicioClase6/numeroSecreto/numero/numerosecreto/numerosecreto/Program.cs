int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1,21);
int numeroIngresado;
int contador = 0;
do
{
    Console.Write("Ingrese un número del 1 al 20 e intente adivinar el que eligió la computadora: ");
    numeroIngresado = int.Parse(Console.ReadLine());
    contador++;
    if (numeroIngresado <= numeroSecreto)
    {
        if (numeroIngresado < numeroSecreto)
        {
            Console.WriteLine("EL número ingresado es menor al numero secreto. Vuelva a intentarlo");
        }
        else
        {
            Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: [{ numeroSecreto}] \nLo has logrado en [{contador} intentos!!]");
        }
    }
    else
    {
        Console.WriteLine("EL número ingresado es mayor al numero secreto. Vuelva a intentarlo");
    }
} while(numeroIngresado != numeroSecreto);
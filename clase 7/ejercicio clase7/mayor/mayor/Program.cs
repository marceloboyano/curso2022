

using System.Text;

bool valid;

int mayor = 0;
int menor = 0;
double promedio;
double suma = 0;
StringBuilder mensajeNumerosIngresados = new StringBuilder();
mensajeNumerosIngresados.AppendLine("");

Console.WriteLine("Ingrese los 10 numeros que formaran el array");
int[] numeros = new int[10];
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el valor: {i + 1}");
    valid = int.TryParse(Console.ReadLine(), out numeros[i]);

    //Hago unas validaciones para que no ingrese cualquier cosa
    if (valid == false || numeros[i] < 0)
    {
        Console.WriteLine("Los numeros del array deben ser enteros positivos. \nPresione cualquier tecla para Salir");
        Console.ReadKey();
        return;
    }

    mensajeNumerosIngresados.AppendLine($"{numeros[i]}, ");

    // Sobreescribo los ceros la primera vez por si es negativo
    if (i == 0)
    {
        mayor = numeros[i];
        menor = numeros[i];
    }

    suma += numeros[i];
    
    promedio = Math.Round(suma / numeros.Length);

    if (i > 0)
    {
        if (numeros[i] > mayor) mayor = numeros[i];
        if (numeros[i] < menor) menor = numeros[i];
    }

    if(i >= numeros.Length - 1)
    {
        Console.Write("Mostrando los numeros del array ingresados: ");
        Console.WriteLine(mensajeNumerosIngresados.ToString());

        Console.WriteLine($"\n La suma de todos los números ingresados es : {suma} " +
            $"\n El numero mayor del array es: {mayor} " +
            $"\n el numero menor del array es: {menor} " +
            $"\n El promedio de todos los numeros del array es: {promedio} ");
    }
}

// lo pongo asi para que se entienda 



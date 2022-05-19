

bool valid;
Console.WriteLine("Ingrese los 10 numeros que formaran el array");
int[] numeros = new int[10];
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el valor: {i + 1}");
    valid = int.TryParse(Console.ReadLine(), out numeros[i]);

    //Hago unas validaciones para que no ingrese cualquier cosa
    if (valid == false || numeros[i] < 0)
    {
       Console.WriteLine("Los numeros del array deben ser enteros positivos. Deberá volver a ingresar. \nPresione cualquier tecla para Continuar");
       Console.ReadKey();
        i--;
    }
}
//le asigno el primer valor del array a menor y mayor
int mayor = numeros[0];
int menor = numeros[0];
//pongo suma como double porque al sacar el promedio debe haber un numero double
//porque sino las operaciones entre enteros devuelven enteros
double suma = 0;

Console.Write("Mostrando los numeros del array ingresados: ");
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
    if (numeros[i] > mayor) mayor = numeros[i];
    if (numeros[i] < menor) menor = numeros[i];
    Console.Write($"{numeros[i]}, ");

}
//ahora si lo redondeo al promedio
double promedio = Math.Round(suma / numeros.Length);

// lo pongo asi para que se entienda 
Console.WriteLine($"\n La suma de todos los números ingresados es : {suma} " +
    $"\n El numero mayor del array es: {mayor} " +
    $"\n el numero menor del array es: {menor} " +
    $"\n El promedio de todos los numeros del array es: {promedio} ");



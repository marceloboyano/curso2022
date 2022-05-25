//// ***************************************************se dispone de un array de n numero aleatorios (usar la clase random)
////    diseñar un programa que permita insertar un valor x en el lugar k-esimo del array como maximo 100

//Console.WriteLine("Ingrese el tamaño deseado para el listado");
//int n = int.Parse(Console.ReadLine());
//int [] miVector = new int[n];

//Random aleatorio = new Random();

//for (int i = 0; i < miVector.Length; i++)
//{
//    miVector[i] = aleatorio.Next(100);
//}
//var contador = 0;

//foreach (var item in miVector)
//{
//    contador++;
//    Console.WriteLine(contador + ": " + item + " ");
//}

//Console.WriteLine();
//Console.WriteLine("Ingrese posición a modificar: ");
//var k = int.Parse(Console.ReadLine());

//if (k > miVector.Length  || k < 0)
//{
//    Console.WriteLine("Indice incorrecto");
//}
//else
//{
//    Console.WriteLine("Ingrese nuevo valor: ");
//    miVector[k-1] = int.Parse(Console.ReadLine());
//    contador = 0;
//    foreach (var item in miVector)
//    {
//        contador++;
//        Console.WriteLine(contador + ": " + item + " ");
//    }
//}


// ****************************************************crear un array de los 100 primeros numeros primos que existen

int[] primos = new int[100];


int posicion = 0;
int aux = 0;
int numero = 1;
while (posicion < 100)
{
    aux = 0;
    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            aux++;
        }

    }
    if (aux == 2)
    {
        primos[posicion] = numero;
        posicion++;

    }
    numero++;


}
foreach (var item in primos)
{
    Console.WriteLine(item);
}
Console.ReadKey();

//Ejercicio

//Crear un programa que cumpla con los siguientes pasos

//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios
bool validFilas;
bool validColumnas;
int filas;
int columnas;

//Validaciones de tipo de Dato en las filas y columnas
do
{
    Console.Write("Ingrese el númuero de columnas: ");
    validColumnas = int.TryParse(Console.ReadLine(), out columnas);
    Console.Write("Ingrese el número de filas: ");
    validFilas = int.TryParse(Console.ReadLine(), out filas);

    if (!validColumnas || !validFilas || columnas <= 0 || filas <= 0)
    {
        Console.Write("El número de filas o columnas es incorrecto. Deben ser un números enteros positivos. \nPresione una tecla para continuar: ");
        Console.ReadKey();
        Console.Clear();
    }

}while (!validColumnas || !validFilas || columnas <= 0 || filas <= 0);

double suma;
double promedio;
double[] promedios = new double[columnas];
int[,] numeros = new int[filas, columnas];

// Esto no es necesario para este ejercicio ya que contamos con este dato en filas y columnas ingresadas por el usuario pero en caso de no tenerlo se hace así
// Incluso hay otra forma de obtener filas y columnas con numeros.GGetLength(0) para las filas y numeros.GGetLength(1) para las columnas que es mas corto que el que nos enseñaron
////Cantidad de filas
int lengthFilas = numeros.GetUpperBound(0) + 1;


////Cantidad de Columnas
int lengthColumnas = numeros.GetUpperBound(1) + 1;


//Ingreso los Elementos de la matriz
for (int i = 0; i < lengthColumnas; i++)
{
    suma = 0;
    Console.WriteLine();
    Console.WriteLine($"Columna N° {i + 1} ");
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.WriteLine($"Ingrese el elemento de Fila N°{j+1} ");
        // hago las validaciones usando la misma variable de la entrada para no crear nuevas
        validFilas = int.TryParse(Console.ReadLine(), out numeros[j, i]);
        if (!validFilas || numeros[j, i] < 0)
        {
            Console.WriteLine("El elemento ingresado es incorrecto. Debe ser un N° entero positivo.");
            j--;
        }
        else
        {
            suma += numeros[j, i];
        }
    }
    promedio = suma / filas;
    // lo redondeo porque usualmente los promedios se redondean hacia arriba
    promedios[i] = Math.Round(promedio);
    
}

//Muestro la Matriz
for (int i = 0; i < lengthColumnas; i++)
    {
    Console.WriteLine("=====================================================");
    Console.WriteLine();
    Console.WriteLine($"Columna N° {i + 1} ");


   for (int j = 0; j < lengthFilas; j++)
    {
        Console.Write($"Fila N°{j + 1} = ");
        Console.WriteLine(numeros[j, i]);
    }
    Console.Write($"Promedio de la Columna Redondeado N°{i + 1} = ");
    Console.WriteLine(promedios[i]);
}









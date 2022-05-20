

//Console.WriteLine("Ingrese las notas de cada alumno");

//Console.WriteLine("Ingrese la cantidad de alumnos");

////ingresamos el tamaño del vector
//int cantidadAlumnos = int.Parse(Console.ReadLine()); 

////tipo [] nombre = new tipo [tamaño]
//int [] notas = new int [cantidadAlumnos];

////recorremos el vector para cargar
//for (int i = 0; i < notas.Length; i++)
//{
//    Console.WriteLine($"Nota del alumno N°{i + 1}: ");
//    notas[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine();
//Console.WriteLine("========================================================================");
//Console.WriteLine();
//for (int i = 0; i < notas.Length; i++)
//{
// Console.WriteLine($"La nota del alumno N° {i+1}: {notas[i]} ");
//}


//tipo [,] nombre = new tipo[tamañofilas,tamañoColumnas]
Console.WriteLine("Ingrese las notas de los examenes");
//determina las columnas
Console.WriteLine("Ingrese la cantidad de alumnos");
//determina las filas
int cantidadAlumnos = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de notas por alumno");
int cantidadNotas = int.Parse(Console.ReadLine());  

int[,] notas = new int[cantidadNotas, cantidadAlumnos];

//Cantidad de filas
int lengthFilas = notas.GetUpperBound(0) + 1;

//Cantidad de Columnas
int lengthColumnas = notas.GetUpperBound(1) + 1;

//recorremos columnas
for (int i = 0; i < lengthColumnas; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N°: {i + 1}: ");

    //recorremos filas
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.WriteLine($"Cargue la nota N° {j+1}: ");
        notas[j, i] = int.Parse(Console.ReadLine());
    }

}

for (int i = 0; i < lengthColumnas; i++)
{
    Console.WriteLine("=====================================================");
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N°: {i + 1}: ");

    //recorremos filas
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.Write($"Cargue la nota N° {j+1}: ");
        Console.WriteLine(notas[j, i]);     
    }

}
Console.WriteLine(notas[2,0]);// nota 3 del alumno 1



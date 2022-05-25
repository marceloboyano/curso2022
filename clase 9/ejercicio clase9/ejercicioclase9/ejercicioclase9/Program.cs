//Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente
//1)      Pedir al usuario la longitud de un vector
//2)      Crear el vector del tamaño ingresado.
//3)      Llenar el mismo con datos aleatorios
//4)      Mostrar el vector por pantalla
//5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo,
//el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido,
//el vector debe quedar así: 50, 40, 30, 20, 10.Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
//6)      Mostrar el vector nuevamente.
bool valid;
int tamaño;
do
{
    Console.WriteLine("Ingrese la longitud que desea que tenga su lista");
    valid = int.TryParse(Console.ReadLine(), out tamaño);
    if (!valid || tamaño <= 0)
    {
        Console.WriteLine("La longitud ingresada es incorrecta. Debe ser un numero entero positivo distintos de 0. \n Presione cualquier tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }

} while (!valid || tamaño <=0);

int[] vector = new int[tamaño];

Random elemento = new Random();

//lleno los datos del vector y los muestro

Console.Write("Los elementos de la lista son: ");
for (int i = 0; i < vector.Length; i++)
{
    vector[i] = elemento.Next(1000);//datos aleatorias del 1 al 1000 para que no de numeros demasiados altos
    Console.Write(vector[i] + " ");

}
Console.WriteLine();
var aux1 = 0;
//Seguramente habrá formas de asignación mas eficaces pero esta es la que se me ocurrio a mi 
for (int i = 0; i < vector.Length / 2; i++) //el tamaño maximo del for lo determine asi xq al asignar el primer elemento al ultimo y el ultimo al primero se reduce el recorrido a la mitad 
{
    aux1 = vector[i];   
    vector[i] = vector[(tamaño - 1) - i]; // una forma que se me ocurrio para posicionarme en la ultima posicion e ir recorriendo de atras tambien se puede usar vector.length -1 -i pero queda mas largo
    vector[(tamaño - 1) - i] = aux1;
}
Console.Write("Elementos en orden invertido: ");
foreach (var item in vector)
{
    Console.Write(item + " ");
}

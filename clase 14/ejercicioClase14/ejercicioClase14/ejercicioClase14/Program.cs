/*Ejercicio de cartas españolas orientado a objetos:

Cada carta tiene un número entre 1 y 12 (el 8 y el 9 no los incluimos) y un palo (espadas, bastos, oros y copas)
La baraja estará compuesta por un conjunto de cartas, 40 exactamente.

Las operaciones que podrá realizar la baraja son:

Barajar():
  Cambia de posición todas las cartas aleatoriamente.

SiguienteCarta():
  Devuelve la siguiente carta que está en la baraja, cuando no haya más o se haya llegado al final, se indica al usuario que no hay más cartas.

CartasDisponibles():
  Indica el número de cartas que aún puede repartir

DarCartas(int cantidad):
  Dado un número de cartas que nos pidan, le devolveremos ese número de cartas (piensa que puedes devolver). En caso de que haya menos cartas que las pedidas, 
no devolveremos nada pero debemos indicárselo al usuario.

CartasMonton():
  Mostramos aquellas cartas que ya han salido, si no ha salido ninguna indicárselo al usuario.

MostrarBaraja():
  Muestra todas las cartas hasta el final. Es decir, si se saca una carta y luego se llama al método, este no mostrara esa primera carta.


Escribir un programa que dentro de un bucle vaya mostrando las opciones que querramos, por ejemplo

1 - Barajar
2 - Mostrar siguiente carta
3 - Mostrar cartas disponibles
4 - Dar cartas
5 - Mostrar cartas del monton
6 - Mostrar baraja
7 - Salir */



using ejercicioClase14;

Baraja baraja = new Baraja();
// Relleno la baraja con 40 naipes de 4 palos que son las "i" y el numero de las cartas la "j" 
for (int i = 0; i < 4; i++)
{
    for (int j = 1; j <= 12; j++)
    {
        switch (i)
        {
            case 0:
                if (j == 8 || j == 9) break;               
                baraja.Naipes.Add(new Carta(j, "espadas"));
                
                break;
            case 1:
                if (j == 8 || j == 9) break;                
                baraja.Naipes.Add(new Carta(j, "bastos"));               
                break;
            case 2:
                if (j == 8 || j == 9) break;              
                baraja.Naipes.Add(new Carta(j, "oros"));
                
                break;
            default:
                if (j == 8 || j == 9) break;             
                baraja.Naipes.Add(new Carta(j, "copas"));
                break;
        }

    }
}






baraja.Barajar();
var opcion =0;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\t╔════════════════════════════════════════════════════════════════════════╗ ");
Console.WriteLine("\t║                  Bienvenido al Juego de las Cartas                     ║ ");
Console.WriteLine("\t║            Las Cartas ya han sido Barajadas aleatoriamente             ║ ");
Console.WriteLine("\t║     Ingrese alguna de las siguientes opciones para empezar a jugar     ║ ");
Console.WriteLine("\t╚════════════════════════════════════════════════════════════════════════╝ ");
do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("           1 - Barajar");
    Console.WriteLine("           2 - Mostrar siguiente carta");
    Console.WriteLine("           3 - Mostrar cartas disponibles");
    Console.WriteLine("           4 - Dar cartas");
    Console.WriteLine("           5 - Mostrar cartas del monton");
    Console.WriteLine("           6 - Mostrar baraja");
    Console.WriteLine("           7 - Salir");
    Console.Write("\n   La opción ingresada es: ");
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (opcion)
    {
        case 1:
            baraja.Barajar();                     
            Console.WriteLine("   Las cartas han sido barajadas\n");
            break;
        case 2:
            baraja.SiguienteCarta();          
            break;
        case 3:
           baraja.CartasDisponibles();          
            break;
        case 4:
            Console.Write("   Ingrese la cantidad de cartas que desea dar: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine();
            baraja.DarCartas(cantidad);            
            break;
        case 5:
            Console.WriteLine("   Las cartas que ya han salido son: ");
            baraja.CartasMonton();
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine("   Las cartas que hay en la baraja son: ");
            baraja.MostrarBaraja();
            Console.WriteLine();
            break;
        case 7:
            Console.WriteLine("   Gracias por jugar");
            break;
        default:
            Console.WriteLine("  Opción incorrecta. Ingrese de nuevo");
            Console.WriteLine();
            break;
    }

    
} while (opcion != 7);


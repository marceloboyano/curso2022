

//borra la pantalla
Console.Clear();
//pedimos al usuario que introduzca su nombre
Console.WriteLine("Hola, Escriba su Nombre");

//leemos el nombre del usuario
string nombre;
nombre = Console.ReadLine();

//pedimos al usuario que introduzca su apellido
Console.WriteLine("Ahora por favor ingrese su apellido");

string apellido = Console.ReadLine();

//mostramos el nombre
Console.Write("Hola " + nombre);
Console.WriteLine(", Este es mi segundo programa");

Console.WriteLine("Pulse una tecla para finalizar");
Console.ReadKey();

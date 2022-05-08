/*Crearemos una clase llamada Serie con las siguientes caracteristicas: Sus atributos son titulo, numero de t
 * emporadas, entregado, genero y creador.
 * Por defecto, el numero de temporadas es de 3 temporadas y entregado false.
 * El resto de atributos serán valores por defecto según el tipo de atributo. 
 * Los constructores que se implementaran serán:
 * Un constructor por defecto.
 * Un constructor con el titulo y creador.
 * El resto por defecto. Un constructor con todos los atributos, excepto de entregado.
 * Los metodos que se implementara serán:
 * Métodos get de todos los atributos, excepto de entregado.
 * Metodos set de todos los atributos, excepto entregado. Sobreescribe los metodos toString.
 * 
 * Metodo compareTo(Object a) compara las horas estimadas en los videojuegos y en las series el numero de temporadas. 
 * Como parametro que tenga un objeto, no es necesario que implementes la interfaz Compareble.
 * Recuerada el uso de los casting de objetos. Implementa los antrior metodos en las clases Videojuego y serie.
 * Ahora creo una aplicacion ejcutable y realiza lo siguiente:
 * Crea dos arrays, uno de series y otro de videojuegos con 5 posiciones cada uno.
 * crea un objeto en cada posicion del array con los valores que desees puedes usar distintos constructores.
 * entrega algunos videojuegos y series con el metodo entregar()
 * cuenta cuantas series y videojuegos hay entregados 
 * al contarlos, devuelvelos
 * por ultimo indica el videojuego que tiene mas horas estimadas y la serie con mas temporadas
 * muestralos en pantalla con toda su informa cion ( usa el metodo to string)
 
 
 */

using ejercicio;
using ejercicio1;

//Serie walkingDead = new Serie("peterpan",4,"accion","travolta");
//Console.WriteLine(walkingDead.ToString());
//Console.WriteLine("titulo: " + walkingDead.Titulo + " numero de temporadas: " + walkingDead.NumeroTemporadas+ " genero: "+ walkingDead.Genero+" creador: "+ walkingDead.Creador);
//VideoJuego UnrealGoty99 = new VideoJuego("Unreal Tournament", 20, "shooter", "Engine Games");
//walkingDead.Entregar();
//walkingDead.Devolver();
//UnrealGoty99.Entregar();

 object [] arr1 = new object [5];
 object[] arr2 = new object[5];
arr1[0] = new Serie("peterpan", 4, "accion", "travolta");
arr1[1] = new Serie();
arr1[2] = new Serie("Walking Dead", 10, "Zombies", "Spielber");
arr1[3] = new Serie("Los simpson","nose");
arr1[4] = new Serie("los simuladores", 5, "suspenso", "mucari");

arr2[0] = new VideoJuego("Resident evil", 2, "accion", "alguien");
arr2[1] = new VideoJuego();
arr2[2] = new VideoJuego("Unreal Tournament", 20, "shooter", "Engine Games");
arr2[3] = new VideoJuego("Minecraft", 40);
arr2[4] = new VideoJuego();


interface IEntregable
{
    bool IsEntregado ();
    void Entregar();
    void Devolver();
   // double CompareTo(Serie obj1,VideoJuego obj2);
    
}
 

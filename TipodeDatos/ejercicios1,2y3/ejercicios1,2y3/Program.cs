//ejercicio 1

Console.WriteLine("Ingrese un Nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese un apellido");
string apellido = Console.ReadLine();
Console.WriteLine("ingrese su edad");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("SABE programar");
string programa = Console.ReadLine();
Console.WriteLine("Su nombre es " + nombre + " y su apellido es " + apellido + " usted tiene " + edad + " años de edad y " + programa + "  programa ");

//ejercicio2
class coche
{

    int puertas;
    int ruedas;
    string marca;
    int itv;
}
class mesa
{

    double peso;
    double largo;
    string materiala;
    string color;


}
ejercicio 3
int numero = 18;
if (numero >= 18) Console.WriteLine(numero);
char letra = 'a';
if (letra == 'a') Console.WriteLine(letra);  
if (letra == 'a' && numero >= 18) Console.WriteLine("ambas condiciones son verdaderas");
if (letra == 'a' || numero >= 19) Console.WriteLine("una de las dos es verdadera");





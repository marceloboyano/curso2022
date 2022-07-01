

using clase20.clases;

var p = new Persona()
{
    Nombre = "Juan",
    Apellido = "Perez",
};

var p1 = new Persona();
p1.Nombre = "Juan";
p1.Apellido = "Perez";

var p3 = new Proveedor("Juan", "Perez");
var pr = new Proveedor("Juan", "Perez");

var miArray = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine(pr.calcularCredito());

var miTexto = "cuantas palabras tiene este texto?";
var miTexto2 = "cuantas-palabras-tiene-este-texto?";
Console.WriteLine(miTexto.ContarPalabras());
Console.WriteLine(miTexto.ContarPalabras());

//Tipo anonimo
var auto1 = new
{
    Marca = "Ford",
    Modelo = "Mustang",
    Anio = "1969",
};

Console.WriteLine(auto1.Modelo);
Console.WriteLine(auto1.Marca);

var pr2 = new
{
    pr.Nombre,
    pr.Apellido,
    TipoProveedor = "Limpieza",
};
Console.WriteLine("**************************************************");
Console.WriteLine(pr2.Nombre);
Console.WriteLine(pr2.Apellido);
Console.WriteLine(pr2.TipoProveedor);

//expresiones lambda
//ejemplo 1
int[] numeros = { 1, 2, 3, 4, 5 };
int numerosImpares = numeros.Count(n=> n % 2 == 1);

Console.WriteLine(numerosImpares);

//ejemplo 2
List<Persona> misClientes = new List<Persona>();
misClientes.Add(new Persona { Apellido = "Perez", Nombre = "Juan" });
misClientes.Add(new Persona { Apellido = "de tal", Nombre = "gualn" });

//Ienumerable<Persona> juanes= misClientes.Where(cadaCliente cadaCliente => cadaCliente.Nombre =="Juan")

var juanes = misClientes.Where(cadaCliente => cadaCliente.Nombre == "Juan");

foreach (var item in juanes)
{
    Console.WriteLine(item.Nombre);
}
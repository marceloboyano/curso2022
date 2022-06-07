

using clase13.Modelo;

//var persona1 = new Persona()
//{
//    NombreCompeto = "Ezequiel Etchecoin",
//    NumeroDocumento = "12312",
//    Edad = 30,
//    EstaCasado = true,
//};

var persona1 = new Persona("Ezequiel Etchecoin", "12312",30,true);
var person2 = new Persona{NombreCompeto = "Carlos Moscoso"};

Console.WriteLine(persona1.ObtenerSaludo());
Console.WriteLine(persona1.ObtenerSaludo("Carlos"));

//esta clase tambien se incorpora desde el namespace clase13.Modelo
var miOcupacion = new Ocupacion();

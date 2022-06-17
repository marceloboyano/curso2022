

using cartesianasPolares.FactoryMethod;
using cartesianasPolares.Modelos;

// usando herencia
var punto1 = new PuntoCartesiano(5, 7);
var punto2 = new PuntoPolar(30, 23);



// usando factory method
var punto3 = PuntoFabrica<PuntoCartesiano>.ObtenerInstancia(30, 5);
var punto4 = PuntoFabrica<PuntoPolar>.ObtenerInstancia(30, 5);
//Console.WriteLine(punto1.ToString());
//Console.WriteLine("*******************************************");
//Console.WriteLine(punto2.ToString());
//Console.WriteLine("*******************************************");
//Console.WriteLine(punto3.ToString());
//Console.WriteLine("*******************************************");
//Console.WriteLine(punto4.ToString());

// Factory Static Method

var punto5 = OtroPunto.CrearPuntoCartesiano(30, 5);
var punto6 = OtroPunto.CrearPuntoPolar(30, 5);

Console.WriteLine(punto5);
Console.WriteLine(punto6);



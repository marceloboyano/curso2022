// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Datos Numericos
byte numero_byte = 0;
int numero_integer = 0;
long numero_long = 0;
double numero_double = 0.2;
float numero_float = 0;
const string constanteTexto = "esto es un texto constante";

//Datos Logicos
bool datoBool = false;
bool datoBool1 = true;

//Datos de texto 
string datoString = "texto de prueba numero uno";
Console.WriteLine(datoString);
datoString = "texto modificado";

//instruccion de salida
Console.WriteLine(datoString);
Console.WriteLine(numero_integer);
Console.WriteLine("ingrese un valor");

//instruccion de entrada
string datoString111 = Console.ReadLine();
  int convertido =  Convert.ToInt32(datoString111);
Console.WriteLine(convertido);
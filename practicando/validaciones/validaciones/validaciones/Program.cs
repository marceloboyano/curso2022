


using validaciones;

int inferior;
int superior;
bool validI;
bool validS;

Console.Write("Ingrese el limite inferior de tipo entero: ");
validI = int.TryParse(Console.ReadLine(), out inferior);
Console.Write("Ingrese el limite Superior de tipo entero: ");
validS = int.TryParse(Console.ReadLine(), out superior);


//if (!(!validI || !validS || !validS && validI))
//{

//    FizzBuzz Fito = new FizzBuzz(inferior, superior);
//    Fito.Execute();


//}
//else
//{
//  Console.WriteLine("No ha ingresado valores enteros en los limites");
//}


 static void Show(string v,StreamWriter sw)
{
    Console.WriteLine(v);
}


static void Imprime(string v, StreamWriter sw)
{
  
    sw.WriteLine(v);
   
}
Action<string, StreamWriter> Output = Show;
StreamWriter sw = new StreamWriter("Test.txt");

FizzBuzz Fito = new FizzBuzz(inferior, superior, Output, sw);
Fito.Execute();


Output = Imprime;
FizzBuzz Fito1 = new FizzBuzz(inferior, superior, Output, sw);
Fito1.Execute();
sw.Close();





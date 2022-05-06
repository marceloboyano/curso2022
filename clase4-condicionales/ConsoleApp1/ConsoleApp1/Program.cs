//Ejemplo de condicional if

//Console.WriteLine("Ingrese su edad: ");// le pedimos al usuario que ingrese su edad
//int edad = Convert.ToInt32(Console.ReadLine());// obtenemos la edad por teclado

////Console.WriteLine("Ingrese su equipo de futbol: ");
////string equipo = Console.ReadLine();
//Console.WriteLine("La edad ingresada es: " + edad);

////if (edad < 18 && equipo == "River")//evaluamos la edad y equipo
//if(edad <18)
//{
//    //Instrucciones si se cumple
//    Console.WriteLine("Usted es menor de edad.");
//}
//else
//{
//    //Instrucciones si no se cumple la condicion evaluada
//    Console.WriteLine("Usted es mayor de edad.");
//}

//Ejemplo if-else if-else- else
//Console.Write("Ingrese la edad: ");
//int edad = Convert.ToInt32(Console.ReadLine());
//if (edad < 0 || edad > 100)
//{
//    Console.WriteLine("La edad no es valida.");
//}
//else if(edad < 12)
//{
//    Console.WriteLine("Va a la primaria");
//} else if (edad < 18)
//{
//    Console.WriteLine("Va al secundario");
//} else if(edad < 28)
//{
//    Console.WriteLine("Va a la facultad");

//}else
//{
//    Console.WriteLine("A trabajar");
//}

//Ejemplo del Switch
Console.WriteLine("Ingrese el primer numero: ");
double numero1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("1- suma");
Console.WriteLine("2- resta");
Console.WriteLine("3- multiplicacion");
Console.WriteLine("4- division");
Console.WriteLine("Ingrese la operacion a realizar");
string operacion = Console.ReadLine();
double resultado =0;
switch (operacion)
{
    case "1":
        Console.WriteLine("Sumando...");
        resultado = numero1 + numero2;     
        break;
    case "2":
        Console.WriteLine("Restando...");
        resultado = numero1 - numero2;
        break;
    case "3":
        Console.WriteLine("multiplicando...");
        resultado = numero1 * numero2;
        break;
    case "4" when numero2 != 0:
        Console.WriteLine("dividiendo...");
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("opcion no valida");
        break;
}
Console.WriteLine("El resultado es: "+resultado);
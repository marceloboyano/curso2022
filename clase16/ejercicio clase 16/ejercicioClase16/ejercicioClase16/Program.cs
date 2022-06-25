//Diseñe la siguiente jerarquía para las clases:

//Cuadrilátero.
//Trapecio.
//Rectángulo.
//Cuadrado.

//Use la clase Cuadrilátero como la clase base de la jerarquía, que debe ser abstracta.

//Los datos privados de la clase base deben ser las coordenadas x-y de los cuatro vértices de la figura y debe contener un método abstracto para calcular el área.

//Agregue un constructor a cada clase para inicializar sus datos e invoque el constructor de la clase base desde el constructor de cada clase derivada.

//Escriba un programa que instancie objetos de cada una de las clases y calcule el área correspondiente. Investigue las fórmulas para calcular el área de cada figura.


using ejercicioClase16.Modelos;
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\t╔════════════════════════════════════════════════════════════════════════╗ ");
Console.WriteLine("\t║   Bienvenido!! Vamos a calcular el área de una figura cuadrilatera     ║ ");
Console.WriteLine("\t║                   Podran ser estas tres figuras                        ║ ");
Console.WriteLine("\t║                CUADRADO      RECTANGULO     TRAPECIO                   ║ ");
Console.WriteLine("\t╚════════════════════════════════════════════════════════════════════════╝ ");
Console.ForegroundColor = ConsoleColor.Green;



Console.WriteLine("══════════════════════════════════════════════════════════════════════════════════");
Console.WriteLine("Ingrese las cordenadas x,y de cada uno de los vertices de su figura");
Console.Write("Vertice Nº1 x: ");
var x = int.Parse(Console.ReadLine());
Console.Write("Vertice Nº1 y: ");
var y = int.Parse(Console.ReadLine());
var v1 = new[] { x, y };
Console.WriteLine();
Console.Write("Vertice Nº2 x: ");
x = int.Parse(Console.ReadLine());
Console.Write("Vertice Nº2 y: ");
y = int.Parse(Console.ReadLine());
var v2 = new[] { x, y };
Console.WriteLine();
Console.Write("Vertice Nº3 x: ");
x = int.Parse(Console.ReadLine());
Console.Write("Vertice Nº3 y: ");
y = int.Parse(Console.ReadLine());
var v3 = new[] { x, y };
Console.WriteLine();
Console.Write("Vertice Nº4 x: ");
x = int.Parse(Console.ReadLine());
Console.Write("Vertice Nº4 y: ");
y = int.Parse(Console.ReadLine());
var v4 = new[] { x, y };
Console.WriteLine("══════════════════════════════════════════════════════════════════════════════════");

// Determino segun los puntos ingresados si es un cuadrado rectangulo o trapecio
if (EsCuadrado(v1, v2, v3, v4) == true)
{
    var cuadrado = new Cuadrado(v1, v2, v3, v4);
    Console.WriteLine("Los vertices ingresados corresponden con un Cuadrado ");
    Console.Write("El area de su Cuadrado es: " + cuadrado.CalcularArea());
}
else if (EsRectangulo(v1, v2, v3, v4) == true)

{
    var rectangulo = new Rectangulo(v1, v2, v3, v4);
    Console.WriteLine("Los vertices ingresados corresponden con un Rectangulo ");
    Console.Write("El area de su Rectangulo es: " + rectangulo.CalcularArea());
}
else
{
    //si no es cuadrado ni rectangulo es un trrapecio
    var trapecio = new Trapecio(v1, v2, v3, v4);
    Console.WriteLine("Los vertices ingresados corresponden con un Trapecio ");
    Console.Write("El area de su Trapecio es: " + trapecio.CalcularArea());
}


 bool EsCuadrado(int[] Vertice1, int[] Vertice2, int[] Vertice3, int[] Vertice4)
{
    // calculo la distancia entre los puntos si es un cuadrado todas deben ser iguales
    var diagonalAB = Math.Sqrt(Math.Pow((Vertice1[0] - Vertice2[0]), 2) + Math.Pow((Vertice1[1] - Vertice2[1]), 2));
    var diagonalBC = Math.Sqrt(Math.Pow((Vertice2[0] - Vertice3[0]), 2) + Math.Pow((Vertice2[1] - Vertice3[1]), 2));
    var diagonalCD = Math.Sqrt(Math.Pow((Vertice3[0] - Vertice4[0]), 2) + Math.Pow((Vertice3[1] - Vertice4[1]), 2));
    var diagonalDA = Math.Sqrt(Math.Pow((Vertice4[0] - Vertice1[0]), 2) + Math.Pow((Vertice4[1] - Vertice1[1]), 2));
    //CALCULO la pendiente de los puntos cuya multiplicacion debe dar -1 para saber si es 90 grados
    //hago un CAST 
    var pendienteAB = (double)(Vertice2[1] - Vertice1[1]) / (double)(Vertice2[0] - Vertice1[0]);
    var pendienteBC = (double)(Vertice3[1] - Vertice2[1]) / (double)(Vertice3[0] - Vertice2[0]);
    var pendienteCD = (double)(Vertice4[1] - Vertice3[1]) / (double)(Vertice4[0] - Vertice3[0]);
    var pendienteDA = (double)(Vertice1[1] - Vertice4[1]) / (double)(Vertice1[0] - Vertice4[0]);
    if (diagonalAB == diagonalBC && diagonalBC == diagonalCD && diagonalCD == diagonalDA)  
        {
        //existen algunos casos que la pendiente tiende a infinito pero es un cuadrado o rectangulo ej. (3,1) (6,1) (6,4) (3,4) asi lo soluciono
            if(pendienteAB  == double.PositiveInfinity || pendienteBC  == double.PositiveInfinity || pendienteCD == double.PositiveInfinity || pendienteDA  == double.PositiveInfinity)
              {
            return true;
              }
        }
    if (diagonalAB == diagonalBC && diagonalBC == diagonalCD && diagonalCD == diagonalDA && pendienteAB* pendienteBC == -1
        && pendienteBC * pendienteCD == -1 && pendienteCD * pendienteDA == -1 && pendienteDA * pendienteAB == -1)        
    {
        return true;
    }
    else
    {
        return false;
    }

}
bool EsRectangulo(int[] Vertice1, int[] Vertice2, int[] Vertice3, int[] Vertice4)
{


    // calculo la distancia entre los puntos si es un rectangulo no deben ser todas iguales
    var diagonalAB = Math.Sqrt(Math.Pow((Vertice1[0] - Vertice2[0]), 2) + Math.Pow((Vertice1[1] - Vertice2[1]), 2));
    var diagonalBC = Math.Sqrt(Math.Pow((Vertice2[0] - Vertice3[0]), 2) + Math.Pow((Vertice2[1] - Vertice3[1]), 2));
    var diagonalCD = Math.Sqrt(Math.Pow((Vertice3[0] - Vertice4[0]), 2) + Math.Pow((Vertice3[1] - Vertice4[1]), 2));
    var diagonalDA = Math.Sqrt(Math.Pow((Vertice4[0] - Vertice1[0]), 2) + Math.Pow((Vertice4[1] - Vertice1[1]), 2));
    //CALCULO la pendiente de los puntos si cumple esto es un rectangulo
    //AB y BC son porpendiculares
    //BC y CD son porpendiculares
    //CD y AD son porpendiculares
    var pendienteAB = (double)(Vertice2[1] - Vertice1[1]) / (double)(Vertice2[0] - Vertice1[0]);
    var pendienteBC = (double)(Vertice3[1] - Vertice2[1]) / (double)(Vertice3[0] - Vertice2[0]);
    var pendienteCD = (double)(Vertice4[1] - Vertice3[1]) / (double)(Vertice4[0] - Vertice3[0]);
    var pendienteDA = (double)(Vertice1[1] - Vertice4[1]) / (double)(Vertice1[0] - Vertice4[0]);
    var rec = false;

    //veo si tiene 2 lados largos iguales y 2 lados cortos iguales //
    //si llego hasta aca nunca van a ser los 4 lados iguales
    if (diagonalAB == diagonalBC && diagonalCD == diagonalDA)
    {
        if (pendienteAB == double.PositiveInfinity || pendienteBC == double.PositiveInfinity || pendienteCD == double.PositiveInfinity || pendienteDA == double.PositiveInfinity)
        {
            return true;
        }
        rec = true;
    }else if(diagonalAB == diagonalCD && diagonalBC==diagonalDA)
    {
        if (pendienteAB == double.PositiveInfinity || pendienteBC == double.PositiveInfinity || pendienteCD == double.PositiveInfinity || pendienteDA == double.PositiveInfinity)
        {
            return true;
        }
        rec = true;
    }else if (diagonalAB == diagonalDA && diagonalBC==diagonalCD)
    {
        if (pendienteAB == double.PositiveInfinity || pendienteBC == double.PositiveInfinity || pendienteCD == double.PositiveInfinity || pendienteDA == double.PositiveInfinity)
        {
            return true;
        }
        rec = true;
    } 

    if ( pendienteAB * pendienteBC == -1 && pendienteBC * pendienteCD == -1 && pendienteCD * pendienteDA == -1  && rec == true)
    {
        if (pendienteAB == double.PositiveInfinity || pendienteBC == double.PositiveInfinity || pendienteCD == double.PositiveInfinity || pendienteDA == double.PositiveInfinity)
        {
            return true;
        }
        return true;
    }
    else
    {
        return false;
    }

}
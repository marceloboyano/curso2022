
//Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

//Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
//7)    Mostrar el carton por pantalla

int[,] carton = new int[3, 9];

Random elemento = new Random();

int aux2;
int contColumnas = 0;



// no me salio el ejercicio solo armo el carton con las filas correctas me falta la condicion para las columnas 
for (int i = 0; i < 3; i++)
{

    int contFilas = 0;
    do
    {
        for (int j = 0; j < 9; j++)
        {
            aux2 = elemento.Next(1, 3);

            if (contFilas < 5)    //condicion para que sean 5 elementos x fila
            {

                if (aux2 == 1)
                {
                    if (carton[i, j] == 0)   // condicion para que no se sobreescriba los elementos
                    {
                        contFilas++;
                        switch (j)
                        {

                            case 0: carton[i, j] = elemento.Next(1, 9); break;
                            case 1: carton[i, j] = elemento.Next(10, 20); break;
                            case 2: carton[i, j] = elemento.Next(20, 30); break;
                            case 3: carton[i, j] = elemento.Next(30, 40); break;
                            case 4: carton[i, j] = elemento.Next(40, 50); break;
                            case 5: carton[i, j] = elemento.Next(50, 60); break;
                            case 6: carton[i, j] = elemento.Next(60, 70); break;
                            case 7: carton[i, j] = elemento.Next(70, 80); break;
                            default: carton[i, j] = elemento.Next(80, 91); break;
                        }
                    }
                }
            }
            else
            {

                break;

            }

        }
    } while (contFilas < 5);      // no sale del while hasta que sean 5 x fila  


}
  




for (int i = 0; i < 3; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 9; j++)
    {

        Console.Write(carton[i, j] + "   ");
    }
}



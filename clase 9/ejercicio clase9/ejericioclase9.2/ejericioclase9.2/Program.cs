Random elemento = new Random();
char condicion;
do
{
    int[] vector1 = new int[9];
    int[] vector2 = new int[9];
    int[] vector3 = new int[9];
    int aux2;
    int aux1;
    int contFilas = 0;
    do
    {
        for (int i = 0; i < 9; i++)
        {
            aux2 = elemento.Next(1, 3);

            if (contFilas < 5)    //condicion para que sean 5 elementos x fila
            {

                if (aux2 == 1)
                {
                    if (vector1[i] == 0)   // condicion para que no se sobreescriba los elementos
                    {
                        contFilas++;
                        switch (i)
                        {
                            case 0: vector1[i] = elemento.Next(1, 9); break;
                            case 1: vector1[i] = elemento.Next(10, 20); break;
                            case 2: vector1[i] = elemento.Next(20, 30); break;
                            case 3: vector1[i] = elemento.Next(30, 40); break;
                            case 4: vector1[i] = elemento.Next(40, 50); break;
                            case 5: vector1[i] = elemento.Next(50, 60); break;
                            case 6: vector1[i] = elemento.Next(60, 70); break;
                            case 7: vector1[i] = elemento.Next(70, 80); break;
                            default: vector1[i] = elemento.Next(80, 91); break;
                        }
                    }
                }
            }
            else
            {
                break;
            }

        }
    } while (contFilas < 5);

    contFilas = 0;

    do
    {
        for (int i = 0; i < 9; i++)
        {
            aux2 = elemento.Next(1, 3);

            if (contFilas < 5)    //condicion para que sean 5 elementos x fila
            {

                if (aux2 == 1)
                {
                    if (vector2[i] == 0 )   // condicion para que no se sobreescriba los elementos
                    {
                        
                        switch (i)
                        {

                            case 0:
                               
                                    aux1 = elemento.Next(1, 9);
                                if (aux1 != vector1[i] && vector1[i] < aux1)
                                {
                                    vector2[i] = aux1;
                                    contFilas++;
                                }
                                        break;
                              
                                
                            case 1:                                
                                    aux1 = elemento.Next(10, 20);
                                if (aux1 != vector1[i] && vector1[i] < aux1)
                                {
                                    vector2[i] = aux1;
                                    contFilas++;
                                }
                                break;

                            case 2:
                                     aux1 = elemento.Next(20, 30);
                                if (aux1 != vector1[i] && vector1[i] < aux1)
                                {
                                    vector2[i] = aux1;
                                    contFilas++;
                                }
                                break;

                            case 3:
                                     aux1 = elemento.Next(30, 40);
                                if (aux1 != vector1[i] && vector1[i] < aux1)
                                {
                                    vector2[i] = aux1;
                                    contFilas++;
                                }
                                break;

                            case 4:
                                     aux1 = elemento.Next(40, 50);
                                if (aux1 != vector1[i] && vector1[i] < aux1)
                                {
                                    vector2[i] = aux1;
                                    contFilas++;
                                }
                                break;

                            case 5:
                                    aux1 = elemento.Next(50, 60);
                                if (aux1 != vector1[i] && vector1[i] < aux1)
                                {
                                    vector2[i] = aux1;
                                    contFilas++;
                                }
                                break;

                            case 6:
                                     aux1 = elemento.Next(60, 70);
                                if (aux1 != vector1[i] && vector1[i] < aux1)
                                {
                                    vector2[i] = aux1;
                                    contFilas++;
                                }
                                break;

                            case 7:
                                     aux1 = elemento.Next(70, 80);
                                if (aux1 != vector1[i] && vector1[i] < aux1)
                                {
                                    vector2[i] = aux1;
                                    contFilas++;
                                }
                                break;

                            default:
                                     aux1 = elemento.Next(80, 91);
                                if (aux1 != vector1[i] && vector1[i] < aux1)
                                {
                                    vector2[i] = aux1;
                                    contFilas++;
                                }
                                break;
                        }
                    }
                }
            }
            else
            {

                break;

            }

        }
    } while (contFilas < 5);

    contFilas = 0;
    //utilizo un for para agregar valor cuando hay dos 0 seguidos
    for (int i = 0; i < 9; i++)
    {
       
        if (contFilas < 5)    //condicion para que sean 5 elementos x fila
        {
            if (vector1[i] == 0 && vector2[i] == 0)
            {
                
                    contFilas++;
                    switch (i)
                    {

                        case 0: vector3[i] = elemento.Next(1, 9); break;
                        case 1: vector3[i] = elemento.Next(10, 20); break;
                        case 2: vector3[i] = elemento.Next(20, 30); break;
                        case 3: vector3[i] = elemento.Next(30, 40); break;
                        case 4: vector3[i] = elemento.Next(40, 50); break;
                        case 5: vector3[i] = elemento.Next(50, 60); break;
                        case 6: vector3[i] = elemento.Next(60, 70); break;
                        case 7: vector3[i] = elemento.Next(70, 80); break;
                        default: vector3[i] = elemento.Next(80, 91); break;
                    }
                
            }

        }
        else
        {
            break;
        }
    }

    do
    {
        for (int i = 0; i < 9; i++)
        {
            aux2 = elemento.Next(1, 3);

            if (contFilas < 5)    //condicion para que sean 5 elementos x fila
            {   
                if(vector1[i] == 0 || vector2[i] == 0)
                {
                    if (aux2 == 1)
                    {
                        if (vector3[i] == 0)   // condicion para que no se sobreescriba los elementos
                        {

                            switch (i)
                            {

                                case 0:

                                    aux1 = elemento.Next(1, 9);
                                    if (aux1 != vector1[i] && aux1 != vector2[i] && vector1[i] < aux1 && vector2[i] < aux1)
                                    {
                                        vector3[i] = aux1;
                                        contFilas++;
                                    }
                                    break;


                                case 1:
                                    aux1 = elemento.Next(10, 20);
                                    if (aux1 != vector1[i] && aux1 != vector2[i] && vector1[i] < aux1 && vector2[i] < aux1)
                                    {
                                        vector3[i] = aux1;
                                        contFilas++;
                                    }
                                    break;

                                case 2:
                                    aux1 = elemento.Next(20, 30);
                                    if (aux1 != vector1[i] && aux1 != vector2[i] && vector1[i] < aux1 && vector2[i] < aux1)
                                    {
                                        vector3[i] = aux1;
                                        contFilas++;
                                    }
                                    break;

                                case 3:
                                    aux1 = elemento.Next(30, 40);
                                    if (aux1 != vector1[i] && aux1 != vector2[i] && vector1[i] < aux1 && vector2[i] < aux1)
                                    {
                                        vector3[i] = aux1;
                                        contFilas++;
                                    }
                                    break;

                                case 4:
                                    aux1 = elemento.Next(40, 50);
                                    if (aux1 != vector1[i] && aux1 != vector2[i] && vector1[i] < aux1 && vector2[i] < aux1)
                                    {
                                        vector3[i] = aux1;
                                        contFilas++;
                                    }
                                    break;

                                case 5:
                                    aux1 = elemento.Next(50, 60);
                                    if (aux1 != vector1[i] && aux1 != vector2[i] && vector1[i] < aux1 && vector2[i] < aux1)
                                    {
                                        vector3[i] = aux1;
                                        contFilas++;
                                    }
                                    break;

                                case 6:
                                    aux1 = elemento.Next(60, 70);
                                    if (aux1 != vector1[i] && aux1 != vector2[i] && vector1[i] < aux1 && vector2[i] < aux1)
                                    {
                                        vector3[i] = aux1;
                                        contFilas++;
                                    }
                                    break;

                                case 7:
                                    aux1 = elemento.Next(70, 80);
                                    if (aux1 != vector1[i] && aux1 != vector2[i] && vector1[i] < aux1 && vector2[i] < aux1)
                                    {
                                        vector3[i] = aux1;
                                        contFilas++;
                                    }
                                    break;

                                default:
                                    aux1 = elemento.Next(80, 91);
                                    if (aux1 != vector1[i] && aux1 != vector2[i] && vector1[i] < aux1 && vector2[i] < aux1)
                                    {
                                        vector3[i] = aux1;
                                        contFilas++;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            else
            {

                break;

            }
        }
        
    } while (contFilas < 5);

    // para imprimir mas coqueto con recuadro
    Console.WriteLine("---------------------------");
    for (int i = 0; i < 9; i++)
    {

        if (vector1[i] == 0)
        {
            Console.Write($"{(vector1[i] == 0 ? "  |" : " ")}");
        }
        else
        { 
            Console.Write(vector1[i].ToString("00") + "|");
        }
    }
    Console.WriteLine(); 
    for (int i = 0; i < 9; i++)
    {
        if (vector2[i] == 0)
        {
            Console.Write($"{(vector2[i] == 0 ? "  |" : " ")}");
        }
        else
        {
            Console.Write(vector2[i].ToString("00") + "|");
        }
    }
    Console.WriteLine();
   
    for (int i = 0; i < 9; i++)
    {
        if (vector3[i] == 0)
        {
            Console.Write($"{(vector3[i] == 0 ? "  |" : " ")}"); //para que no imprima el 0 cuestion visual
        }
        else
        {
            Console.Write(vector3[i].ToString("00") + "|");
        }
    }
    Console.WriteLine();
    Console.WriteLine("---------------------------");
    Console.WriteLine("Desea generar otro carton: S/N");
    condicion = char.Parse(Console.ReadLine().ToUpper());
       
} while (condicion == 'S');
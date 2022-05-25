using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace FizzBuzz
{
    public class FizzBuzzConsola: IFizzBuzz
    {
        public void execute()
        {

            if (!FizzBuzzFabrica.Validaciones(Inferior, Superior))
            {
                Output("Los Datos ingresados son incorrectos." +
                   "\n* No se puede ingresar numeros negativos" +
                   " \n* El limite superior no puede ser menor que el limite inferior" +
                   " \n* los limites no pueden ser mayores que 10mil");
                return;
            }

            for (int i = Inferior; i <= Superior; i++)
            {
                if (i % 3 != 0 || i % 5 != 0)
                {
                    if (i % 5 == 0 || i % 3 == 0)
                    {
                        if (i % 5 != 0)
                        {

                            Output("FIZZ");

                        }
                        else
                        {
                            Output("BUZZ");
                        }
                    }
                    else
                    {
                        Output("numero: " + i);
                    }
                }
                else
                {
                    Output("FIZZBUZZ");

                }

            }


        }
    }
}



namespace validaciones
{
    public class FizzBuzz
    {

        public int Inferior { get; set; }
        public int Superior { get; set; }
        public FizzBuzz() { }

        public FizzBuzz(int _inferior, int _superior)
        {
            Inferior = _inferior;
            Superior = _superior;
        }

        public void Execute()
        {

            if (!Validaciones(Inferior, Superior))
            {
                Console.WriteLine("Los Datos ingresados son incorrectos." +
                    "\n* No se puede ingresar numeros negativos" +
                    " \n* El limite superior no puede ser menor que el limite inferior" +
                    " \n* los limites no pueden ser mayores que 10mil");
            }
            else
            {
                for (int i = Inferior; i <= Superior; i++)
                {
                    if (i % 3 != 0 || i % 5 != 0)
                    {
                        if (i % 5 == 0 || i % 3 == 0)
                        {
                            if (i % 5 != 0)
                            {
                                                             
                                Console.WriteLine("FIZZ");
                                
                            }
                            else
                            {
                                Console.WriteLine("BUZZ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("numero: " + i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("FIZZBUZZ");

                    }

                }
            }

        }

      
        public bool Validaciones(int inferior, int superior)
        {


            if (inferior < 0 || superior < 0 || superior < inferior || superior > 10000 || inferior > 10000)
            {
                return false;
            }
            return true;


        }

    }
}



namespace validaciones
{
    public class FizzBuzz
    {

        public int Inferior { get; set; }
        public int Superior { get; set; }
        public EnviarMensaje Output { get; set; }
    public FizzBuzz() { }

        public FizzBuzz(int _inferior, int _superior, EnviarMensaje _output)
        {
            Inferior = _inferior;
            Superior = _superior;
            Output = _output;
        }

        public void Execute()
        {

            if (!Validaciones(Inferior, Superior))
            {
                 Console.WriteLine("Los Datos ingresados son incorrectos." +
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


        static bool Validaciones(int inferior, int superior) => !(inferior < 0 || superior < 0 || superior < inferior || superior > 10000 || inferior > 10000);
       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // La hago abstract para que no se pueda instanciar directamente, sólo se pueden instanciar sus clases hijas.
    // En las clases abstractas definimos las implementaciones que queremos que todos los child usen.
    // Las validaciones, la ejecución, y las propiedades se definen acá, porque no varían para las clases hijas
    public abstract class FizzBuzzBase : IFizzBuzz
    {
        // Las propiedades las ponemos protected porque queremos ENCAPSULARLAS. Es decir que no puedan ser manipuladas
        // desde el exterior, sólo que varíen en base a las reglas de la clase base y las clases hijas.
        protected int Inferior { get; set; }
        protected int Superior { get; set; }
        protected Action<string> Output { get; set; }


        public FizzBuzzBase(Action<string> output )
        {
            Output = output;
        }

        public void execute()
        {

            if (validaciones(Inferior, Superior))
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


        // Cuando la línea se hace muy larga es mejor ir separando en lineas distintas las condiciones
        public bool validaciones(int inferior, int superior) => inferior < 0 
            || superior < 0 
            || superior < inferior 
            || superior > 10000 || inferior > 10000;

        public void setParameters(int inferior, int superior)
        {
            this.Inferior = inferior;
            this.Superior = superior;
        }
    }
}

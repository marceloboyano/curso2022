using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // La unica responsabilidad de esta clase es crear nuevas instancias de FizzBuzz. 
    // No debe llevar ninguna lógica más que esa.
    public class FizzBuzzFabrica<TFizzBuzz> 
        where TFizzBuzz : IFizzBuzz, new() // Constraint para que el compilador sepa que ocupamos la interfaz y vamos a construir nuevas instancias de T en la clase
    {

        public static TFizzBuzz ObtenerInstancia(int inferior, int superior)
        {
            var fizzbuzzInstance = new TFizzBuzz();
            fizzbuzzInstance.setParameters(inferior, superior);

            return fizzbuzzInstance;
        }
       
    }
    //public class FizzBuzzFabrica
    //{

    //    public static IFizzBuzz ObtenerInstancia(string tipo, int inferior, int superior)
    //    {
    //        if (tipo == "FiZZBuzzConsola")
    //        {
    //          return new FizzBuzzConsola(inferior, superior);

    //        }

    //        if (tipo == "FizzBuzzArchivo")
    //        {
    //            return new FizzBuzzArchivo(inferior, superior);

    //        }

    //        // Retorna el valor por defecto... En este caso null
    //        return default;
    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    // La unica responsabilidad de esta clase es crear nuevas instancias de FizzBuzz. 
    // No debe llevar ninguna lógica más que esa.
    public class FizzBuzzFabrica
    {

        public static IFizzBuzz ObtenerInstancia(string tipo, int inferior, int superior)
        {
            if (tipo == "FiZZBuzzConsola")
            {
              return new FizzBuzzConsola(inferior, superior);
                
            }

            if (tipo == "FizzBuzzArchivo")
            {
                return new FizzBuzzArchivo(inferior, superior);

            }

            // Retorna el valor por defecto... En este caso null
            return default;
        }
    }
}

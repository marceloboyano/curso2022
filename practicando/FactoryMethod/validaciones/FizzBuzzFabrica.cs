using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzFabrica
    {
       
            public int Inferior { get; set; }
            public int Superior { get; set; }
            public Action<string> Output { get; set; }
            public FizzBuzzFabrica() { }

            public FizzBuzzFabrica(int _inferior, int _superior, Action<string> _output)
            {
                Inferior = _inferior;
                Superior = _superior;
                Output = _output;

            }


           public static bool Validaciones(int inferior, int superior) => !(inferior < 0 || superior < 0 || superior < inferior || superior > 10000 || inferior > 10000);


        



        public static IFizzBuzz ObtenerInstancia(string tipo)
        {
            if (tipo == "FiZZBuzzConsola")
            {
              return new FizzBuzzConsola();
                
            }
            using (Stream fs = new FileStream("./test.txt", FileMode.Append, FileAccess.Write))
            {

                using (StreamWriter sw = new StreamWriter(fs))
                {

                    sw.WriteLine(tipo);
                }
            }
            return default;
        }
    }
}

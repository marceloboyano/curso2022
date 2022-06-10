using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase14
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona()
        {
            Nombre = "Juan";
            Apellido = "Perez";
        }
        public static void saludar()
        {
            Console.WriteLine("Hola");
        }
    }
}

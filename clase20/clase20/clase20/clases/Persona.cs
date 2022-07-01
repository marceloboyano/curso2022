using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase20.clases
{
    public partial class Persona
    {
        public string Nombre { get; set; }

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;    
        }
        public partial int calcularEdad()
        {
            return 52;
        }
      

    }
}

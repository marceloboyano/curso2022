using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia.Colegio
{
    public class Persona
    {
        public string NombreCompleto { get; set; }
        public int Dni { get; set; }


        public Persona()
        {
            NombreCompleto = "Juan Perez";
            Dni = 1231231;
        }
        protected string Clave()
        {
            return "123";
        }
    }
}
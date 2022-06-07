using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase13.Modelo
{
    internal class Persona
    {
      
        //Propiedades
        public string NombreCompeto { get; set; }
        public string NumeroDocumento { get; set; }
        public int Edad { get; set; }
        public bool EstaCasado { get; set; }
        //Constructor
        public Persona()
        {
            Console.WriteLine("Se ha instanciado una nueva persona.");
        }
        public Persona(string nombreCompleto, string numeroDocumento, int edad, bool estaCasado)
        {
            NombreCompeto = nombreCompleto;
            NumeroDocumento = numeroDocumento;
            Edad = edad;
            EstaCasado = estaCasado;
        }
        //metodos
        public string ObtenerSaludo()
        {
            return $"Hola! Soy {NombreCompeto}";
        }

        public string ObtenerSaludo(string nombrePersonaAQuienSaludar)
        {
            return $"Hola {nombrePersonaAQuienSaludar}, soy {NombreCompeto}";
        }
    }
}

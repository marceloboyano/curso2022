using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase16.Modelos
{
    public class Trapecio:Cuadrilatero
    {
        public Trapecio(int[] v1, int[] v2, int[] v3, int[] v4) : base(v1, v2, v3, v4)
        {

        }
        public override double CalcularArea()
        {
            // ACA Aplico el teorema de gauss para que cada metodo de calcular area sea distinto
             return (double)(Math.Abs((Vertice1[0] * Vertice4[1] + Vertice4[0] * Vertice3[1] + Vertice3[0] * Vertice2[1] + Vertice2[0] * Vertice1[1] - Vertice1[0] * Vertice2[1] - Vertice2[0] * Vertice3[1] - Vertice3[0] * Vertice4[1] - Vertice4[0] * Vertice1[1]) *  0.5));
          
        }
    }
}

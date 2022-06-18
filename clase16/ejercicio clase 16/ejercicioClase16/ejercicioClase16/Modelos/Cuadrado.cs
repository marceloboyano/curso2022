using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase16.Modelos
{
    public class Cuadrado:Cuadrilatero
    {
        public Cuadrado(int[] v1, int[] v2, int[] v3, int[] v4) :base(v1,v2,v3,v4)
        {
                
        }
        public override double CalcularArea()
        {
          
             return Math.Pow(Vertice2[0] - Vertice1[0], 2);
        }
    }
}

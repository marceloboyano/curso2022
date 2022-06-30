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
        public override decimal CalcularArea()
        {
            ////una forma de hacer es mediante el teorema de gauss que sirve para calcular el area de cualquier cuadrilatero
            //var area1 = Math.Abs((Vertice1[0] * Vertice4[1] + Vertice4[0] * Vertice3[1] + Vertice3[0] * Vertice2[1] +
            //    Vertice2[0] * Vertice1[1] - Vertice1[0] * Vertice2[1] - Vertice2[0] * Vertice3[1] - Vertice3[0] * Vertice4[1] - Vertice4[0] * Vertice1[1]) * 0.5);
            //otra forma de hacerlo es calculando la distancia de cualquiera de sus lados ya que todos son iguales la formula es lado x lado
            var diagonalAB = (decimal)(Math.Sqrt(Math.Pow((Vertice1[0] - Vertice2[0]), 2) + Math.Pow((Vertice1[1] - Vertice2[1]), 2)));
            var area2 = diagonalAB * diagonalAB;
            
          
            return Math.Round(area2);
        }
    }
}

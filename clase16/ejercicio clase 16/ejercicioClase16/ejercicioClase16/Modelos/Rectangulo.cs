using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase16.Modelos
{
    public class Rectangulo:Cuadrilatero
    {
        public Rectangulo(int[] v1, int[] v2, int[] v3, int[] v4) : base(v1, v2, v3, v4)
        {

        }
        public override double CalcularArea()
        {
            //una forma de hacer es mediante el teorema de gauss que sirve para calcular el area de cualquier cuadrilatero
            var area1 = Math.Abs((Vertice1[0] * Vertice4[1] + Vertice4[0] * Vertice3[1] + Vertice3[0] * Vertice2[1] +
                Vertice2[0] * Vertice1[1] - Vertice1[0] * Vertice2[1] - Vertice2[0] * Vertice3[1] - Vertice3[0] * Vertice4[1] - Vertice4[0] * Vertice1[1]) * 0.5);
            //otra forma de hacerlo es calculando la distancia de sus lados y como tiene 2 lados iguales largos entre si y 2 lados iguales cortos, el area es largo x ancho 
            var diagonalAB = Math.Sqrt(Math.Pow((Vertice1[0] - Vertice2[0]), 2) + Math.Pow((Vertice1[1] - Vertice2[1]), 2));
            var diagonalBC = Math.Sqrt(Math.Pow((Vertice2[0] - Vertice3[0]), 2) + Math.Pow((Vertice2[1] - Vertice3[1]), 2));
            var diagonalCD = Math.Sqrt(Math.Pow((Vertice3[0] - Vertice4[0]), 2) + Math.Pow((Vertice3[1] - Vertice4[1]), 2));
            var diagonalDA = Math.Sqrt(Math.Pow((Vertice4[0] - Vertice1[0]), 2) + Math.Pow((Vertice4[1] - Vertice1[1]), 2));
            double area2 = 0;
            if (diagonalAB == diagonalBC)
            {
                area2 = diagonalAB * diagonalCD;
            }
            else
            {
                area2 = diagonalAB * diagonalBC;
            }
       

        if (area1 != Math.Round(area2)) return 0;
        return area1;

        }
    }
}

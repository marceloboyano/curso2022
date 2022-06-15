using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartesianasPolares.Modelos
{
    public class PuntoCartesiano:Punto
    {
        public PuntoCartesiano(double x, double y): base(x,y)
        {
          
               
            
        }
        public PuntoCartesiano()
        {
                
        }
        public override string ToString() => $"Este es un punto Cartesiano y sus valores son: {this.X}X, {this.Y}Y";
    }
}

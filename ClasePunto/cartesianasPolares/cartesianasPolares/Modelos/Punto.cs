using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartesianasPolares.Modelos
{
    public abstract class Punto:IPunto
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto(double x, double y)
        {

            X = x;
            Y = y;
            
        }
        public Punto()
        {
            
        }

        public void setPunto(double x, double y)
        {
          X = x;
          Y = y;
        }
    }
}

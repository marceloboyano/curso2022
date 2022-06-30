using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase16.Modelos
{
    public abstract class Cuadrilatero
    {
        private int[] _vertice1 = new int[2];
        private int[] _vertice2 = new int[2];
        private int[] _vertice3 = new int[2];
        private int[] _vertice4 = new int[2];        
        public int[] Vertice1 {
            get
            {
                return _vertice1;
            }
            set
            {
                _vertice1 = value;
            }
        }
        public int[] Vertice2
        {
            get
            {
                return _vertice2;
            }
            set
            {
                _vertice2 = value;
            }
        }
        public int[] Vertice3
        {
            get
            {
                return _vertice3;
            }
            set
            {
                _vertice3 = value;
            }
        }
        public int[] Vertice4
        {
            get
            {
                return _vertice4;
            }
            set
            {
                _vertice4 = value;
            }
        }
        public Cuadrilatero(int[] v1, int[] v2, int[] v3, int[] v4)
        {
            Vertice1 = v1 ;
            Vertice2 = v2;
            Vertice3 = v3;
            Vertice4 = v4;
        }
        public abstract decimal CalcularArea();
    }
}

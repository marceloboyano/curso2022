using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase17Billeteras.version2
{
    public class BilleteraCarlos : IBilletera
    {
        private int[,] billetes = new int[7, 2];

        public BilleteraCarlos()
        {
            billetes[0, 1] = 10;
            billetes[1, 1] = 20;
            billetes[2, 1] = 50;
            billetes[3, 1] = 100;
            billetes[4, 1] = 200;
            billetes[5, 1] = 500;
            billetes[6, 1] = 1000;

        }
        public int Billetede10
        {
            get
            {
                return billetes[0, 0];
            }
            set
            {
                billetes[0, 0] = value;
            }
        }
        public int Billetede20
        {
            get
            {
                return billetes[1, 0];
            }
            set
            {
                billetes[1, 0] = value;
            }
        }
        public int Billetede50
        {
            get
            {
                return billetes[2, 0];
            }
            set
            {
                billetes[2, 0] = value;
            }
        }
        public int Billetede100
        {
            get
            {
                return billetes[3, 0];
            }
            set
            {
                billetes[3, 0] = value;
            }
        }
        public int Billetede200
        {
            get
            {
                return billetes[4, 0];
            }
            set
            {
                billetes[4, 0] = value;
            }
        }
        public int Billetede500
        {
            get
            {
                return billetes[5, 0];
            }
            set
            {
                billetes[5, 0] = value;
            }
        }
        public int Billetede1000
        {
            get
            {
                return billetes[6, 0];
            }
            set
            {
                billetes[6, 0] = value;
            }
        }

        public decimal Total()
        {


            decimal total = 0;
            for (int i = 0; i < billetes.GetLength(0); i++)
            {
                total += billetes[i, 1] * billetes[i, 0];
            }
            return total;

        }

        public IBilletera Combinar( IBilletera b)
        {
            var nueva = new BilleteraCarlos();
            //combinamos
            nueva.Billetede10 = Billetede10 + b.Billetede10;
            nueva.Billetede20 = Billetede20 + b.Billetede20;
            nueva.Billetede50 = Billetede50 + b.Billetede50;
            nueva.Billetede100 = Billetede100 + b.Billetede100;
            nueva.Billetede200 = Billetede200 + b.Billetede200;
            nueva.Billetede500 = Billetede500 + b.Billetede500;
            nueva.Billetede1000 = Billetede1000 + b.Billetede1000;
            Vaciar();
            //vaciamos esta billetera
            b.Billetede10 = 0;
            b.Billetede20 = 0;
            b.Billetede50 = 0;
            b.Billetede100 = 0;
            b.Billetede200 = 0;
            b.Billetede500 = 0;

            return nueva;
        }
        private void Vaciar()
        {
            for (int i = 0; i < billetes.GetLength(0); i++)
            {
                billetes[i, 0] = 0;
            }
        }

        
    }
}


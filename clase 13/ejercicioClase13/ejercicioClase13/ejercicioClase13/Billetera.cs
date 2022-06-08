using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase13
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            decimal total = 0;
            total += BilletesDe10 * 10;
            total += BilletesDe20 * 20;
            total += BilletesDe50 * 50;
            total += BilletesDe100 * 100;
            total += BilletesDe200 * 200;
            total += BilletesDe500 * 500;
            total += BilletesDe1000 * 1000;
            return total;
        }
        public Billetera Combinar(Billetera billetera)
        {
            Billetera billetera3 = new Billetera();
            billetera3.BilletesDe10 = billetera.BilletesDe10 + BilletesDe10;
            billetera.BilletesDe10 = 0; BilletesDe10 = 0;
            billetera3.BilletesDe20 = billetera.BilletesDe20 + BilletesDe20;
            billetera.BilletesDe20 = 0; BilletesDe20 = 0;
            billetera3.BilletesDe50 = billetera.BilletesDe50 + BilletesDe50;
            billetera.BilletesDe50 = 0; BilletesDe50 = 0;
            billetera3.BilletesDe100 = billetera.BilletesDe100 + BilletesDe100;
            billetera.BilletesDe100 = 0; BilletesDe100 = 0;            
            billetera3.BilletesDe200 = billetera.BilletesDe200 + BilletesDe200;
            billetera.BilletesDe200 = 0; BilletesDe200 = 0;
            billetera3.BilletesDe500 = billetera.BilletesDe500 + BilletesDe500;
            billetera.BilletesDe500 = 0; BilletesDe500 = 0;
            billetera3.BilletesDe1000 = billetera.BilletesDe1000 + BilletesDe1000;
            billetera.BilletesDe1000 = 0; BilletesDe1000 = 0;
            return billetera3;

        }
    }
}

















































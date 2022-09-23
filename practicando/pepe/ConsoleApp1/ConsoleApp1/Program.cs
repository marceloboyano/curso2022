//Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

//BilletesDe10
//BilletesDe20
//BilletesDe50
//BilletesDe100
//BilletesDe200
//BilletesDe500
//BilletesDe1000

//Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

//Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
//Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)




Billetera billetera1 = new Billetera { BilletesDe10 = 10, BilletesDe20 = 20, BilletesDe50 = 50, BilletesDe100 = 100, BilletesDe500 = 500, BilletesDe1000 = 1000 };
Billetera billetera2 = new Billetera { BilletesDe10 = 5, BilletesDe20 = 10, BilletesDe50 = 15, BilletesDe100 = 20,  BilletesDe500 = 30, BilletesDe1000 = 50 };
Console.WriteLine($"La billetera N°1 tiene:\n {billetera1.BilletesDe10} Billetes de $10\n {billetera1.BilletesDe20} Billetes de $20\n {billetera1.BilletesDe50} Billetes de $50\n " +
    $"{billetera1.BilletesDe100} Billetes de $100\n {billetera1.BilletesDe500} Billetes de $500\n {billetera1.BilletesDe1000} Billetes de $1000");
Console.WriteLine("==============================================================");
Console.WriteLine($"La billetera N°2 tiene:\n {billetera2.BilletesDe10} Billetes de $10\n {billetera2.BilletesDe20} Billetes de $20\n {billetera2.BilletesDe50} Billetes de $50 \n" +
    $" {billetera2.BilletesDe100} Billetes de $100\n {billetera2.BilletesDe500} Billetes de $500\n {billetera2.BilletesDe1000} Billetes de $1000,");
Console.WriteLine("==============================================================");
Console.WriteLine($"El total de la billetera N°1 es: {billetera1.Total()}");
Console.WriteLine($"El total de la billetera N°2 es: {billetera2.Total()}");
Console.WriteLine("==============================================================");
var billetera3 = billetera1.Combinar(billetera2);
Console.WriteLine($"La billetera N°3 combinada tiene:\n {billetera3.BilletesDe10} Billetes de $10\n {billetera3.BilletesDe20} Billetes de $20\n {billetera3.BilletesDe50} Billetes de $50 \n" +
$" {billetera3.BilletesDe100} Billetes de $100\n {billetera3.BilletesDe500} Billetes de $500\n {billetera3.BilletesDe1000} Billetes de $1000\nLas Billeteras 1 y 2 han sido vaciadas");
Console.WriteLine("==============================================================");
Console.WriteLine($"El total de la billetera N°3 es: {billetera3.Total()}");














public class Billetera
{
    public int BilletesDe10 { get; set; }
    public int BilletesDe20 { get; set; }
    public int BilletesDe50 { get; set; }
    public int BilletesDe100 { get; set; }
    public int BilletesDe500 { get; set; }
    public int BilletesDe1000 { get; set; }
    private double _total;
    public double Total()
    {
       
       _total += BilletesDe10 * 10;
       _total += BilletesDe20 * 20;
       _total += BilletesDe50 * 50;
       _total += BilletesDe100 * 100;
       _total += BilletesDe500 * 500;
       _total += BilletesDe1000 * 1000;
        return _total;
    }
    public  Billetera Combinar(Billetera billetera2)
    {
        Billetera billetera3 = new Billetera();
        billetera3.BilletesDe10 = BilletesDe10 + billetera2.BilletesDe10;
        billetera3.BilletesDe20 = BilletesDe20 + billetera2.BilletesDe20;
        billetera3.BilletesDe50 = BilletesDe50 + billetera2.BilletesDe50;
        billetera3.BilletesDe100 = BilletesDe100 + billetera2.BilletesDe100;
        billetera3.BilletesDe500 = BilletesDe500 + billetera2.BilletesDe500;
        billetera3.BilletesDe1000 = BilletesDe1000 + billetera2.BilletesDe1000;
        billetera2.BilletesDe10 =0;
        BilletesDe10 =0;
        billetera2.BilletesDe20 =0;
        BilletesDe20 =0;
        billetera2.BilletesDe50 =0;
        BilletesDe50 =0;
        billetera2.BilletesDe100 =0;
        BilletesDe100 =0;
        billetera2.BilletesDe500 =0;
        BilletesDe500 =0;
        billetera2.BilletesDe1000 =0;
        BilletesDe1000 =0;
        return billetera3;
    }
}

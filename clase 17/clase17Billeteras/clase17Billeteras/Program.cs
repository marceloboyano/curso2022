

//using clase17Billeteras;
//using clase17Billeteras.version2;

//var b1 = new Billetera();
//var b2 = new Billetera();

//b1.Billetede100 = 1;
//b2.Billetede1000 = 1;
//Console.WriteLine(b1.Total().ToString());
//Console.WriteLine(b2.Total().ToString());

//var b3 = b1.Combinar(b2);
//Console.WriteLine(b3.Total().ToString());






//var bc1 = new BilleteraCarlos();
//var bc2 = new BilleteraCarlos();

//bc1.Billetede100 = 1;
//bc2.Billetede1000 = 1;
//Console.WriteLine(bc1.Total().ToString());
//Console.WriteLine(bc2.Total().ToString());

//var bc3 = bc1.Combinar(bc2);
//Console.WriteLine(bc3.Total().ToString());


using clase17Billeteras;
using clase17Billeteras.version2;

var b1 = new Billetera();
var bc2 = new BilleteraCarlos();
b1.Billetede100 = 1;
bc2.Billetede1000 = 1;
Console.WriteLine(b1.Total().ToString());
Console.WriteLine(bc2.Total().ToString());
var bc3 = b1.Combinar(bc2);
Console.WriteLine(bc3.Total().ToString());
// See https://aka.ms/new-console-template for more information
using clase_27___ef_Database_first;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


var ctx = new NorthwindContext();


////creamos customero
//var newCustomer = new Customer()
//{
//    CustomerId = "Ruben",
//    CompanyName = "Ruben Benegas",
//    Orders = new List<Order>(),
//};

//newCustomer.Orders.Add(new Order()
//{
//    CustomerId = "Ruben",
//    OrderDate = DateTime.Now,
//});
//// agregamos el customer
//ctx.Add(newCustomer);
//ctx.SaveChanges();

////EDITAR
//var reg = ctx.Customers.FirstOrDefault(r => r.CustomerId == "Ruben");
//if(reg != null)
//{
//    reg.CompanyName = "Ruben Benegas Editado";
//    ctx.SaveChanges();
//}

////ELIMINAR
//var regOrders = ctx.Orders.Where(r => r.CustomerId == "Ruben");
//ctx.RemoveRange(regOrders);
//var regCustomer = ctx.Customers.FirstOrDefault(r => r.CustomerId == "Ruben");
//ctx.Remove(regCustomer);
//ctx.SaveChanges();

Console.WriteLine("Lista de Customers");
Console.WriteLine();
Console.WriteLine("=================================================");
//var customers = ctx.Customers.Select(selector => 
//                new {IdCustomer = selector.CustomerId, 
//                    NameCustomer= selector.CompanyName});
//var customers = ctx.Customers;
//foreach (var customer in customers)
//{
//    Console.WriteLine($"{customer.CustomerId} - {customer.CompanyName}");
//}


//Console.WriteLine("=====================================0");
//Console.WriteLine();
//Console.WriteLine("Ingrese el Id customer que desea consultar: ");
//string idCustomer = Console.ReadLine();

////Consulta si existe en la base de datos (Any)
//bool anyCustomer = ctx.Customers.Any(x => x.CustomerId == idCustomer.ToUpper());

//if(anyCustomer)
//{
//    Console.WriteLine("Existe.Todo OK!");
//    //TOP 1
//    var customer = ctx.Customers.Include(i=>i.Orders)
//                                .FirstOrDefault(c => c.CustomerId == idCustomer);
//    Console.WriteLine();
//    Console.WriteLine($"IdCustomer: {customer.CustomerId} - CompanyName: {customer.CompanyName}");
//    Console.WriteLine("Orders");
//    foreach (var item in customer.Orders)
//    {
//        Console.WriteLine($"OrderId: {item.OrderId} - OrderDate: {item.OrderDate}");
//        Console.WriteLine("=========================================");
//        Console.WriteLine();
//    }
//}
//else
//{
//    Console.WriteLine("El idcustomer ingresado no existe en la BD");
//}

//Console.ReadKey();


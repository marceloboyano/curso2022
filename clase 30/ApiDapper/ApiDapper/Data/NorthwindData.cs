using ApiDapper.Models;
using Dapper;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ApiDapper.Data
{
    public class NorthwindData
    {
        public string _cnnStr = "Server=DESKTOP-44QUODQ;Database=Northwind;Trusted_Connection=True";



        public int DeleteOrderById(int orderId)
        {
            using var cnn = new SqlConnection(_cnnStr);
            cnn.Open();
            var tran = cnn.BeginTransaction();
            try
            {
                var sql = "DELETE FROM [Order Details] WHERE OrderId =@orderId ";
                var cant = cnn.Execute(sql, new { orderId }, tran);

                sql = "DELETE FROM Orders WHERE OrderId = @orderId";
                cant += cnn.Execute(sql, new { orderId }, tran);

                tran.Commit();
                return cant;

            }
            catch
            {
                tran.Rollback();
                throw;
            }
            finally
            {
                cnn.Close();
            }
        }          

        public List<Product> GetAllProducts()
         { 
            using var cnn = new SqlConnection(_cnnStr);
            
                cnn.Open();

                var query = "SELECT * FROM Products";
                var listProduct = cnn.Query<Product>(query).ToList();               
                return listProduct;

          
        }

        public Product GetProductById(int id)
        {
             using var cnn = new SqlConnection(_cnnStr);
           
                cnn.Open();

                var q = "SELECT * FROM Products WHERE ProductId = @NuestroId";
                var product = cnn.QueryFirstOrDefault<Product>(q, new {NuestroId = id });
                return product;

          
        }
        public Product GetProductById(Product p)
        {
    using var cnn = new SqlConnection(_cnnStr);
           
                cnn.Open();

                var q = "SELECT * FROM Products WHERE ProductId = @ProductId";
                var product = cnn.QueryFirstOrDefault<Product>(q, p);
                return product;
               
        }

        public List<Order> GetAllOrders()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            using var cnn = new SqlConnection("Server=DESKTOP-44QUODQ;Database=Northwind;Trusted_Connection=True");

            cnn.Open();

            var q = "SELECT o.OrderId, o.CustomerId, od.* FROM Orders o " +
                    "INNER JOIN [Order Details] od ON o.OrderId = od.OrderId";

            var dicc= new Dictionary<int, Order>();

            cnn.Query<Order, OrderDetails, Order>(q,(o,d)=>
            {
                if (!dicc.TryGetValue(o.OrderId, out Order order))
                    dicc.Add(o.OrderId, order = o);

                if (order.Details == null)
                    order.Details = new List<OrderDetails>();
                order.Details.Add(d);
                return order;
            }, splitOn: "OrderId").AsQueryable();

            var orders=dicc.Values.ToList();

            stopWatch.Stop();
            var tiempo = stopWatch.ElapsedMilliseconds;



            return orders;


        }

        //consulta mas lenta y poco optima pero es la misma que arriba
        public List<Order> GetAllOrders2()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            using var cnn = new SqlConnection("Server=DESKTOP-44QUODQ;Database=Northwind;Trusted_Connection=True");

            cnn.Open();

            var q = "SELECT OrderId, CustomerId FROM Orders";
            var ordenes = cnn.Query<Order>(q).ToList();

            if(ordenes!=null)
            {
                foreach(var o in ordenes)
                {
                    var query = "SELECT * FROM [Order Details] WHERE OrderId = @OrderId";
                    o.Details = new List<OrderDetails>();
                    o.Details.AddRange(cnn.Query<OrderDetails>(query, o).ToList());
                }
            }
           stopWatch.Stop();
           var tiempo= stopWatch.ElapsedMilliseconds;



            return ordenes;


        }


    }
}

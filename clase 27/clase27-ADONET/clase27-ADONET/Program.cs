// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");


var connectionString = "Data Source=DESKTOP-44QUODQ;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


using(SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    var command = new SqlCommand("SELECT * FROM  Customers", connection);
    var reader = command.ExecuteReader();
    while(reader.Read())
    {
        Console.Write($"{reader["CustomerID"]} | {reader["CompanyName"]}\n");
    }

}
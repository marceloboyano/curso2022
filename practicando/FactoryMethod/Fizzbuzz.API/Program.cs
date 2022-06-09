using Microsoft.AspNetCore.Mvc;
using Polly;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/api/fizzbuzz", ([FromBody] FizzBuzzValue f) =>
{

    Console.WriteLine(f.fizzBuzzValue);

});
app.Run();

app.MapGet("/api/fizzbuzz", () => Console.WriteLine("Hello, World!"));


app.Run();

internal record FizzBuzzValue(string fizzBuzzValue);
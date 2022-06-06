using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/api/fizzbuzz", ([FromBody] FizzBuzzValue f) =>
{
    Console.WriteLine(f.fizzBuzzValue);
});

app.Run();

internal record FizzBuzzValue(string fizzBuzzValue);
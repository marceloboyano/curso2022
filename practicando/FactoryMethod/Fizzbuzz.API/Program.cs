using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Registramos la clase concreta Repository para la interfaz IRepository --> Inyección de dependencia
builder.Services.AddScoped<IRepository, Repository>();


// Agregamos la base de datos
builder.Services.AddDbContext<FizzbuzzDbContext>(opt =>
{
    opt.UseInMemoryDatabase("FizzBuzzDb");   // Creamos una base de datos en la memoria del servidor... Esto despues lo vamos a cambiar por SQL SERVER
});



var app = builder.Build();

// FromServices busca entre los servicios que registramos previamente...
// Al ir a buscar el Repository nos trae la instancia que definimos
app.MapPost("/api/fizzbuzz", ([FromBody] FizzBuzzValue f) =>
{

    Console.WriteLine(f.fizzBuzzValue);

    // Implementar llamado a entity
    // Podes devolver un Ok para saber que todo fue bien mientras debuggeas... eso genera un codigo 200


});

app.MapGet("/api/fizzbuzz", ([FromServices] Repository fizzBuzzRepository) => {

    // Devolver todos los values almacenados en la base de datos

    return Results.Ok(); // agregar los datos devueltos dentro del Ok... eso te genera un json en la respuesta automáticamente
});


app.Run();

public record FizzBuzzValue(string fizzBuzzValue);

public class Repository : IRepository
{
    public IEnumerable<FizzBuzzValue> GetAll()
    {
        var result = new List<FizzBuzzValue>();

        // Conectarse a Entity Framework y obtener todos los valores de Fizzbuzz

        return result; 
    }

    public async Task StoreValue(FizzBuzzValue value)
    {
        // Conectarse a Entity Framework y guardar el valor que recibimos;
        // Le agregué Task a la firma porque el método que vas a usar para salvar los datos es asíncrono
    }
}

public interface IRepository
{
    IEnumerable<FizzBuzzValue> GetAll();
    Task StoreValue(FizzBuzzValue value);
}

public class FizzbuzzDbContext : DbContext
{
    public FizzbuzzDbContext(DbContextOptions options)
        : base(options)
    {
        
    }
    
    DbSet<FizzBuzzValue> FizzBuzzValues { get; set; }
}

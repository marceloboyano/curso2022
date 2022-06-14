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
app.MapPost("/api/fizzbuzz",  ([FromServices] IRepository repo, [FromBody] FizzBuzzValue f) =>
{
    
    Console.WriteLine(f.fizzBuzzValue);

    repo.StoreValue(f);


    //esto no me salio por el nivel de proteccion de fizzbuzz
    //FizzBuzzValue fizzBuzzValue = new FizzBuzzValue(f);
    //IConfiguration configuration = new ConfigurationBuilder()
    //       .SetBasePath(Directory.GetCurrentDirectory())
    //       .AddJsonFile("appsettings.json")
    //       .Build();
    //var connectionString = configuration.GetConnectionString("local");

    //var options = new DbContextOptionsBuilder<FizzbuzzDbContext>()
    //                 .UseInMemoryDatabase("FizzBuzzDb")
    //                 .Options;
   

    //using (FizzbuzzDbContext db = new FizzbuzzDbContext(options))
    //{

       

    //    db.FizzBuzzValues.Add(fizzBuzzValue);
    //   db.SaveChangesAsync();

    //}
    // Implementar llamado a entity
    // Podes devolver un Ok para saber que todo fue bien mientras debuggeas... eso genera un codigo 200


});

app.MapGet("/api/fizzbuzz", ([FromServices] IRepository fizzBuzzRepository) => {

    // Devolver todos los values almacenados en la base de datos
   var datos= fizzBuzzRepository.GetAll();

    return Results.Ok(datos); // agregar los datos devueltos dentro del Ok... eso te genera un json en la respuesta automáticamente
});


app.Run();

public record FizzBuzzValue(int id, string fizzBuzzValue);

public class Repository : IRepository
{
    private readonly FizzbuzzDbContext _db;

    public Repository(FizzbuzzDbContext db)
    {
        _db = db;
    }
    public IEnumerable<FizzBuzzValue> GetAll()
    {
        return _db.FizzBuzzValues; 
    }

    public async Task StoreValue(FizzBuzzValue value)
    {
        // Conectarse a Entity Framework y guardar el valor que recibimos;
        // Le agregué Task a la firma porque el método que vas a usar para salvar los datos es asíncrono

        var rand = new Random();                    

            FizzBuzzValue fizzBuzzValue = new FizzBuzzValue(rand.Next(),value.fizzBuzzValue); // aca me da error nivel de proteccion de fizzbuzz

        _db.FizzBuzzValues.Add(fizzBuzzValue);
        await _db.SaveChangesAsync();

        return ;// no se que retornar
    }
}

public interface IRepository
{
    IEnumerable<FizzBuzzValue> GetAll();
    Task StoreValue(FizzBuzzValue value);
}

public class FizzbuzzDbContext : DbContext
{
    public FizzbuzzDbContext(DbContextOptions<FizzbuzzDbContext> options)
        : base(options)
    {
       
    }
    
    public DbSet<FizzBuzzValue> FizzBuzzValues { get; set; }
}

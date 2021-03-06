using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Registramos la clase concreta Repository para la interfaz IRepository --> Inyección de dependencia
builder.Services.AddScoped<IRepository, Repository>();

// Agregamos la base de datos
builder.Services.AddDbContext<FizzbuzzDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("FizzBuzzConenection"));   // Creamos una base de datos en la memoria del servidor... Esto despues lo vamos a cambiar por SQL SERVER
});

// Agregamos politica de CORS
builder.Services.AddCors( opt =>
{
    opt.AddDefaultPolicy(o => o
       .AllowAnyHeader()
       .AllowAnyOrigin()
       .AllowAnyMethod());
});

var app = builder.Build();
//using (var scope = app.Services.CreateScope())
//{
//    var context = scope.ServiceProvider.GetRequiredService<FizzbuzzDbContext>();
//    context.Database.Migrate();
//}

// FromServices busca entre los servicios que registramos previamente...
// Al ir a buscar el Repository nos trae la instancia que definimos

app.UseCors();

app.MapPost("/api/fizzbuzz", async ([FromServices] IRepository repo, [FromBody] FizzBuzz f) =>
    {

        Console.WriteLine(f.fizzBuzzValue);
        try
        {
           await repo.StoreValue(f);
        }
        catch(Exception ex) 
        {
            Console.WriteLine(ex);
        }
       
    });

app.MapGet("/api/fizzbuzz", ([FromServices] IRepository fizzBuzzRepository) => {

    
    // Devolver todos los values almacenados en la base de datos
    var datos = fizzBuzzRepository.GetAll();
    
    return Results.Ok(datos); // agregar los datos devueltos dentro del Ok... eso te genera un json en la respuesta automáticamente
});


app.Run();

    public record FizzBuzz(Guid id,string fizzBuzzValue);
    public record FizzBuzzDTO(string fizzBuzzDTO);


public class Repository : IRepository
{
    private readonly FizzbuzzDbContext _db;

    public Repository(FizzbuzzDbContext db)
    {
        _db = db;
    }
    public IEnumerable<FizzBuzzDTO> GetAll()
    {

        var datos1 = from b in _db.FizzBuzzValues
                     select new FizzBuzzDTO(b.fizzBuzzValue);
               
        
        return datos1;
    }

    public async Task StoreValue(FizzBuzz value)
    {
        // Conectarse a Entity Framework y guardar el valor que recibimos;
        // Le agregué Task a la firma porque el método que vas a usar para salvar los datos es asíncrono

        try
        {
            var  n = new Guid();
            //var rand = new Random();
            var fizzBuzzValue = new FizzBuzz(n,value.fizzBuzzValue); // aca me da error nivel de proteccion de fizzbuzz

            _db.FizzBuzzValues.Add(fizzBuzzValue);
            await _db.SaveChangesAsync();

        }
        catch (Exception ex)
        {
           
       
            Console.WriteLine(ex);
        }
    }
}

public interface IRepository
{
    IEnumerable<FizzBuzzDTO> GetAll();
    Task StoreValue(FizzBuzz value);
}

public  class FizzbuzzDbContext : DbContext
{
    public FizzbuzzDbContext(DbContextOptions<FizzbuzzDbContext> options)
        : base(options)
    {

    }
  
    public  DbSet<FizzBuzz> FizzBuzzValues { get; set; }
   // public DbSet<FizzBuzzDTO> fizzBuzzDTOs { get; set; }

}

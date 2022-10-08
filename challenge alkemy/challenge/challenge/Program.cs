using challenge.Controllers;
using challenge.Services;
using DataBase;
using DataBase.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
   .AddJwtBearer(opt =>
   {
       opt.TokenValidationParameters = new TokenValidationParameters
       {
           ValidIssuer = builder.Configuration["Jwt:Issuer"],
           ValidAudience = builder.Configuration["Jwt:Audience"],
           ValidAlgorithms = new[] { SecurityAlgorithms.HmacSha256 },
           IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
           ValidateIssuer = true,
           ValidateAudience = true,
           ValidateLifetime = false,
           ValidateIssuerSigningKey = true
       };
   });

builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setupAction =>
{
    setupAction.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    var xmlSummary = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlFile = Path.Combine(AppContext.BaseDirectory, xmlSummary);

    setupAction.IncludeXmlComments(xmlFile);
});
//builder.Services.AddDbContext<DisneyContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DisneyConnection")));

// Para testear podemos usar un provider de Entity Framework en memoria. Esto sirve para no tener problemas 
// que tengan que ver con base de datos exclusivamente, y testear sólamente el código y la lógica.
// Despues de testear se puede vincular a la base de datos y hacer las pruebas de integración
// https://learn.microsoft.com/en-us/ef/core/providers/in-memory/?tabs=dotnet-core-cli
builder.Services.AddDbContext<DisneyContext>(options => options.UseInMemoryDatabase("TestDB"));

// Agrego los repositorios
builder.Services.AddScoped<IPeliculasRepository, PeliculasRepository>();
builder.Services.AddScoped<IPersonajesRepository, PersonajesRepository>();
builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();

// Agrego los servicios
builder.Services.AddScoped<IPeliculaService, PeliculaService>();
builder.Services.AddScoped<IPersonajeService, PersonajeService>();
builder.Services.AddScoped<IAuthService, AuthService>();

//MAPPER
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

// Añadimos datos de prueba a la base de datos en memoria. Esto se puede hacer sobre la base de datos también
// Este procesos se conoce como "Seed" y lo podés googlear así para buscar ejemplos
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DisneyContext>();
    context.AddRange(
            new Genero()
            {
                Nombre = "Fantasia",              
           
            },
            new Genero()
            {
                Nombre = "Accion",               
                Peliculas = new[]
                {
                    new Pelicula()
            {
                Titulo="Terminator",
                Imagen = "test",
                Personajes = new[]
                {
                    new Personaje()
                    {
                        Edad=40,
                        Historia="robot malo que se vuelve bueno",
                        Imagen = "test",
                        Nombre="T-800",
                        Peso=80.0M
                    },
                    new Personaje()
                    {
                        Edad=43,
                        Historia="robot malo que se vuelve bueno",
                        Nombre="T-1000",
                        Imagen = "test",
                        Peso=70.0M
                    }
                }
            }
                }
            },
            new Genero()
            {
                Nombre = "comedia",                
                Peliculas = new[]
                {
                    new Pelicula()
            {
                Titulo="ROMPEBODAS",
                Imagen = "test",
                Personajes = new[]
                {
                    new Personaje()
                    {
                        Edad=40,
                        Historia="SE COLAN EN LAS BODAS",
                        Imagen = "test",
                        Nombre="OWEN WILSON",
                        Peso=80.0M
                    },
                    new Personaje()
                    {
                        Edad=43,
                        Historia="LOCO MALO",
                        Nombre="WILL FERREL",
                        Imagen = "test",
                        Peso=70.0M
                    }
                }
            }
                }
            }
        );

    context.SaveChanges();
}

app.Run();

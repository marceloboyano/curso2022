using DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static challenge.Controllers.PersonajeController;

namespace challenge.Controllers
{
    [Route("GET/character")]
    [ApiController]
    public class PersonajeController : Controller
    {
        private readonly DisneyContext _context;
        public record PersonajeDTO(string Imagen, string Nombre);
        public PersonajeController(DisneyContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonajeDTO>>> GetPersonajes()
        {
            var personajes = await _context.Personajes.ToListAsync();

            var personajesDTO = personajes
                .Select(p => new PersonajeDTO(p.Imagen, p.Nombre)).ToList();
            return personajesDTO;

        }
     

        [HttpGet("{nombre}")]        

        public async Task<ActionResult<IEnumerable<Personaje>>> GetForName(string nombre)
        {

            if (_context.Personajes.Any(x => x.Nombre == nombre))
            {
                var personaje = await _context.Personajes.Select(p => new Personaje
                {
                    PersonajeID = p.PersonajeID,
                    Nombre = p.Nombre,
                    Edad = p.Edad,
                    Peso = p.Peso,
                    Historia = p.Historia,
                    Imagen = p.Imagen,
                    Peliculas = p.Peliculas,

                }).FirstAsync(x => x.Nombre == nombre);

                return Ok(personaje);
            }
               return NotFound("Personaje no encontrado");      
        }



        [HttpGet("{edad}")]

        public async Task<ActionResult<IEnumerable<Personaje>>> GetForAge(int edad)
        {

            if (_context.Personajes.Any(x => x.Edad == edad))
            {
                var personaje = await _context.Personajes.Select(p => new Personaje
                {
                    PersonajeID = p.PersonajeID,
                    Nombre = p.Nombre,
                    Edad = p.Edad,
                    Peso = p.Peso,
                    Historia = p.Historia,
                    Imagen = p.Imagen,
                    Peliculas = p.Peliculas,

                }).FirstAsync(x => x.Edad == edad);

                return Ok(personaje);
            }
            return NotFound("Personaje no encontrado");
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> PutPersonaje(int id, Personaje personaje)
        {
            if (id != personaje.PersonajeID) return BadRequest();

            _context.Entry(personaje).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return CreatedAtRoute("/character", new { personaje.PersonajeID }, personaje);
        }

        [HttpPost]
        public async Task<ActionResult> PostPersonaje(Personaje personaje)
        {
            _context.Personajes.Add(personaje);
            await _context.SaveChangesAsync();
            return CreatedAtRoute("/character", new { personaje.PersonajeID}, personaje);
        }

       [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersonaje(int id)
        {
            var personaje = await _context.Personajes.FindAsync(id);
            if(personaje == null) return NotFound("Producto no encontrado");
          
            _context.Personajes.Remove(personaje);
            _context.SaveChangesAsync();
            return Ok("Producto Borrado");
        }

    }
}


using challenge.QueryFilters;
using DataBase;
using DataBase.Repositories;
using static challenge.DTOs.Personajes.PersonajeDto;

namespace challenge.Services
{
    public class PersonajeService : IPersonajeService
    {

            private readonly IPersonajesRepository _repo;


            public PersonajeService(IPersonajesRepository repo)
            {
                _repo = repo;

            }

            public async Task<IEnumerable<Personaje>> GetPersonajes()
            {
                // Traigo la entidad
                var personajesEntity = await _repo.GetAll();

                // Es responsabilidad del servicio procesar la entidad y mapearla
                // Para el mapeo podés investigar una libreria llamada AutoMapper, aunque hacerla manualmente para pocos atributos no está mal            

                return personajesEntity;
            }
            public async Task<IEnumerable<Personaje>> GetPersonajes(PersonajeQueryFilter filters)
            {



                var personaje = await _repo.GetAll();



                if (filters.Nombre != null)
                {
                    personaje = personaje.Where(x => x.Nombre == filters.Nombre);
                }

                if (filters.PeliculaID != null)
                {

                    personaje = personaje.Where(x => x.Peliculas.Any(g => g.PeliculaID == filters.PeliculaID));
                }

                if (filters.Edad != null)
                {
                personaje = personaje.Where(x => x.Edad == filters.Edad);
                   
                }
              
            return personaje;
            }

        public async Task InsertPersonajes(Personaje personaje)
        {
            
             await _repo.Create(personaje);    
            
          
        }

        public async Task<bool> UpdatePersonajes(Personaje personaje)
        {

            return await _repo.Update(personaje);

        }


        public async Task<bool> DeletePersonajes(int id)
        {
         
           return  await _repo.Delete(id);

        }
       
    }
}


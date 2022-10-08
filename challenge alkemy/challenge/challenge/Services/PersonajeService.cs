
using AutoMapper;
using challenge.QueryFilters;
using DataBase;
using DataBase.Repositories;
using static challenge.DTOs.Personajes.PersonajeDto;

namespace challenge.Services
{
    public class PersonajeService : IPersonajeService
    {

            private readonly IPersonajesRepository _repo;
            private readonly IMapper _mapper;


        public PersonajeService(IPersonajesRepository repo, IMapper mapper)
            {
                _repo = repo;
                _mapper = mapper;

            }

      
        public async Task<IEnumerable<Personaje>> GetPersonajes(PersonajeQueryFilter filters)
            {



                var personaje = _repo.GetPersonajeConDetalles();



            if (filters.Nombre != null)
                {
                    personaje = personaje.Where(x => x.Nombre.ToLower().Contains(filters.Nombre.ToLower()));
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

        public async Task InsertPersonajes(PersonajeForCreationDTO personajeDTO)
        {
            var personaje = _mapper.Map<Personaje>(personajeDTO);
            await _repo.Create(personaje);    
            
          
        }          
      
        public async Task<bool> UpdatePersonajes(int id, PersonajeForUpdateDTO personajeDTO)
        {
            var personajeEntity = await _repo.GetById(id);

            if (personajeEntity is null) return false;

            if(personajeDTO.Nombre is not null)
            {
                personajeEntity.Nombre = personajeDTO.Nombre;
            }

            if (personajeDTO.Peso is not null)
            {
                personajeEntity.Peso = personajeDTO.Peso.Value;
            }

            if (personajeDTO.Historia is not null)
            {
                personajeEntity.Historia = personajeDTO.Historia;
            }

            if (personajeDTO.Imagen is not null)
            {
                personajeEntity.Imagen = personajeDTO.Imagen;
            }


            return await _repo.Update(personajeEntity);

        }


        public async Task<bool> DeletePersonajes(int id)
        {
         
           return  await _repo.Delete(id);

        }
      

    }
}


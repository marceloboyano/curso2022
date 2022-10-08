using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static challenge.DTOs.Peliculas.PeliculaDTO;
using static challenge.DTOs.Personajes.PersonajeDto;

namespace DataBase.Mappings
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Personaje, PersonajeForUpdateDTO>();
            CreateMap<PersonajeForUpdateDTO, Personaje>();
            CreateMap<PersonajeForShowDTO, Personaje>();
            CreateMap<Personaje, PersonajeForShowDTO>();
            CreateMap<Pelicula, PeliculaForUpdateDTO>();
            CreateMap<Pelicula, PeliculaForCreationDTO>().ReverseMap();
            CreateMap<PeliculaForUpdateDTO, Pelicula>();
            CreateMap<PeliculaForShowDTO, Pelicula>();
            CreateMap<Pelicula, PeliculaForShowDTO>();
        }
    }
}

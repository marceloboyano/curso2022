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
            CreateMap<Personaje, PersonajeForUpdateDTO>().ReverseMap();
            CreateMap<Personaje, PersonajeForShowDTO>().ReverseMap();
            CreateMap<Personaje, PersonajeForCreationDTO>().ReverseMap();
            CreateMap<Pelicula, PeliculaForUpdateDTO>().ReverseMap();
            CreateMap<Pelicula, PeliculaForCreationDTO>().ReverseMap();
            CreateMap<Pelicula, PeliculaForShowDTO>().ReverseMap();
        }
    }
}

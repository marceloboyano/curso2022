using AutoMapper;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static challenge.DTOs.Peliculas.MoviesDto;
using static challenge.DTOs.Personajes.CharacterDto;

namespace DataBase.Mappings
{
    public class AutomapperProfile: Profile
    {

        public AutomapperProfile()
        {

            CreateMap<Character, CharacterForUpdateDTO>().ReverseMap();
            CreateMap<Character, CharacterForShowDTO>().ReverseMap();
            CreateMap<Character, CharacterForCreationDTO>().ReverseMap();
            CreateMap<Character, CharacterForShowWithDetailsDTO>().ReverseMap();
            CreateMap<Movie, MoviesForUpdateDTO>().ReverseMap();
            CreateMap<Movie, MoviesForCreationDTO>().ReverseMap();
            CreateMap<Movie, MoviesForShowDTO>().ReverseMap();
            CreateMap<Movie, MoviesForShowWithDetailsDTO>().ReverseMap();          
          
        }
    }
}

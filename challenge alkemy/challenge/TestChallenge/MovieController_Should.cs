using AutoMapper;
using challenge.Controllers;
using challenge.Services;
using DataBase;
using DataBase.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using static challenge.DTOs.Peliculas.MoviesDto;

namespace TestChallenge
{
    public class MovieController_Should
    {

        [Theory]
        [InlineData(1)]
        [InlineData(9999)]
        public async Task Return_Correct_Status_Code(int id)
        {
            var mockMapper = new Mock<IMapper>();
            var mockMovieService = new Mock<IMovieService>();

            var movieController = new MovieController(
                    mockMovieService.Object,
                    mockMapper.Object
                );

            mockMovieService.Setup(ms => ms.GetMovieById(1))
                .ReturnsAsync(new MoviesForShowWithDetailsDTO() 
                { 
                    Title="test",
                    CreationDate = DateTime.Now, 
                    Rating= 1, 
                    Image = "test", 
                    Characters = new List<Character>(),
                    Genders = new List<Gender>() 
                });
            
            var response = await movieController.GetMovieById(id); 

            switch (id)
            {
                case 1: Assert.True(response.GetType() == typeof(OkObjectResult));
                    break;
                case 9999: Assert.True(response.GetType() == typeof(NotFoundObjectResult));
                    break;
                default:
                    break;
            }

        }
    }
}
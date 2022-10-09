using challenge.QueryFilters;
using challenge.Services;
using DataBase;
using DataBase.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace TestChallenge
{
    public class PeliculaTesting
    {

        private readonly IPeliculaService _controller;
        private readonly IPeliculasRepository _repo;

        public PeliculaTesting(IPeliculaService controller, IPeliculasRepository repo)
        {
            _controller = controller;
            _repo = repo;
        }

        //[Fact]
        //public async Task<IEnumerable<Pelicula>> Test()
        //{
        //   var testService = new 
        //}


    }
}
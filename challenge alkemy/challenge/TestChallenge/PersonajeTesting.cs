using challenge.Services;
using DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChallenge
{
    public class PersonajeTesting
    {

        private readonly IPersonajeService _personajeService;
        private readonly IPersonajesRepository _repo;

        public PersonajeTesting(IPersonajeService personajeService, IPersonajesRepository repo)
        {
            _personajeService = personajeService;
            _repo = repo;
        }

        [Fact]
        public void Test1()
        {

        }
    }
}

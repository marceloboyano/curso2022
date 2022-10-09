using challenge.Services;
using DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChallenge
{
    public class CharacterTesting
    {

        private readonly ICharacterService _personajeService;
        private readonly ICharactersRepository _repo;

        public CharacterTesting(ICharacterService personajeService, ICharactersRepository repo)
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

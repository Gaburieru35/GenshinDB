using GenshinDB.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinDB.Controllers
{
    public class CharactersController : Controller
    {

        private readonly ICharactersRepository _characterRepository;

        public CharactersController(ICharactersRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public IActionResult ListCharacters()
        {
            var characters = _characterRepository.Characters;
            return View(characters);
        }
    }
}

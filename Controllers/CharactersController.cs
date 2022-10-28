using GenshinDB.Models;
using GenshinDB.Repositories.Interfaces;
using GenshinDB.ViewModels;
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
            var characterDetailsViewModel = new CharacterDetailsViewModel();
            characterDetailsViewModel.Characters = _characterRepository.Characters;
            //var characters = _characterRepository.Characters;
            return View(characterDetailsViewModel);
        }

        public IActionResult CharacterDetails(int id)
        {
            var characterDetailsViewModel = new CharacterDetailsViewModel();
            characterDetailsViewModel.Character = _characterRepository.GetCharactersById(id);
            return View(characterDetailsViewModel);
        }
    }
}

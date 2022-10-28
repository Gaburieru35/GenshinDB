using GenshinDB.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinDB.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagsRepository _charactertagRepository;

        public TagController(ITagsRepository charactertagrepository)
        {
            _charactertagRepository = charactertagrepository;
        }

        public IActionResult ListTags()
        {
            var tags = _charactertagRepository.CharactersTags;
            return View(tags);
        }

        public List<GenshinDB.Models.CharactersTags> ReturnCharacterTags(int id)
        {
            var tags = _charactertagRepository.GetTagsByCharactersId(id);
            return tags;
        }
    }
}
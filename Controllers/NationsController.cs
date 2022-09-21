using GenshinDB.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinDB.Controllers
{
    public class NationsController : Controller
    {
        private readonly INationRepository _nationRepository;

        public NationsController(INationRepository nationRepository)
        {
            _nationRepository = nationRepository;
        }

        public IActionResult ListNations()
        {
            var nation = _nationRepository.Nations;
            return View(nation);
        }
    }
}

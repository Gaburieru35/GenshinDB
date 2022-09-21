using GenshinDB.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinDB.Controllers
{
    public class VisionsController: Controller
    {
        private readonly IVisionRepository _visionRepository;

        public VisionsController(IVisionRepository visionRepository)
        {
            _visionRepository = visionRepository;
        }

        public IActionResult ListVisions()
        {
            var vision = _visionRepository.Visions;
            return View(vision);
        }
    }
}

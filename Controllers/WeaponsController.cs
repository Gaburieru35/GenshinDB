using GenshinDB.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinDB.Controllers
{
    public class WeaponsController: Controller
    {
        private readonly IWeaponsRepository _weaponRepository;

        public WeaponsController(IWeaponsRepository weaponsRepository)
        {
            _weaponRepository = weaponsRepository;
        }

        public IActionResult ListWeapons()
        {
            var weapons = _weaponRepository.Weapons;
            return View(weapons);
        }
    }
}

using GenshinDB.Context;
using GenshinDB.Models;
using GenshinDB.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GenshinDB.Repositories
{
    public class WeaponsRepository: IWeaponsRepository
    {
        private readonly AppDbContext _context;

        public WeaponsRepository (AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Weapons> Weapons => _context.Weapons.Include(ws => ws.WeaponSubStatusType);

        public Weapons GetWeaponsByID(int weaponid)
        {
            return _context.Weapons.FirstOrDefault(w => w.WeaponID == weaponid);
        }

        public Weapons GetWeaponsByType(int weapontype)
        {
            return _context.Weapons.FirstOrDefault(w => w.WeaponType == weapontype);
        }
    }
}

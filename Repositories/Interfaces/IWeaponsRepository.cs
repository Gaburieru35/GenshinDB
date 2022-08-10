using GenshinDB.Models;

namespace GenshinDB.Repositories.Interfaces
{
    public interface IWeaponsRepository
    {
        IEnumerable<Weapons> Weapons { get; }
        Weapons GetWeaponsByID(int weaponid);
        Weapons GetWeaponsByType(int weapontype);
    }
}

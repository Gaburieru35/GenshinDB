using GenshinDB.Models;

namespace GenshinDB.Repositories.Interfaces
{
    public interface IVisionRepository
    {
        IEnumerable<Visions> Visions { get; }
    }
}

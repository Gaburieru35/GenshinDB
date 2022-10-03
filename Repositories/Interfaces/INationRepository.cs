using GenshinDB.Models;

namespace GenshinDB.Repositories.Interfaces
{
    public interface INationRepository
    {
        IEnumerable<Nations> Nations { get; }
        Nations GetNationsById(int id);
    }
}

using GenshinDB.Models;

namespace GenshinDB.Repositories.Interfaces
{
    public interface ICharactersRepository
    {
        IEnumerable<Characters> Characters { get; }
        Characters GetCharactersById(int characterid);
    }
}

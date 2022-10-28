using GenshinDB.Models;

namespace GenshinDB.Repositories.Interfaces
{
    public interface ITagsRepository
    {
        IEnumerable<CharactersTags> CharactersTags { get; }
        List<CharactersTags> GetTagsByCharactersId(int characterid);
    }
}

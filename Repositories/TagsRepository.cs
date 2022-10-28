using GenshinDB.Context;
using GenshinDB.Models;
using GenshinDB.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GenshinDB.Repositories
{
    public class TagsRepository : ITagsRepository
    {

        private readonly AppDbContext _context;

        public TagsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CharactersTags> CharactersTags => _context.CharactersTags;

        public List<CharactersTags> GetTagsByCharactersId(int characterid)
        {
            var query = from t in _context.CharactersTags
                        join c in _context.Characters
                        on t.CharactersIdTags equals c.CharactersId
                        select new { t.TagsName };

            List<CharactersTags> tags = new List<CharactersTags>();
            foreach (var c in query)
            {
                CharactersTags tag = new CharactersTags();
                tag.TagsName = c.TagsName;
                tags.Add(tag);
            }
            return tags;
        }
    }
}
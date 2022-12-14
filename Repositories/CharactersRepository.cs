using GenshinDB.Context;
using GenshinDB.Models;
using GenshinDB.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GenshinDB.Repositories
{
    public class CharactersRepository : ICharactersRepository
    {

        private readonly AppDbContext _context;

        public CharactersRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Characters> Characters => _context.Characters;

        public Characters GetCharactersById(int characterid)
        {
            var characters = _context.Characters.FirstOrDefault(c => c.CharactersId == characterid);
            return characters;
        } 
    }
}

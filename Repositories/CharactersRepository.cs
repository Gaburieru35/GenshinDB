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

        public IEnumerable<Characters> Characters => _context.Characters.Include(n => n.Nation);

        public Characters GetCharactersById(int characterid)
        {
            return _context.Characters.FirstOrDefault(c => c.CharactersId == characterid);
        }
    }
}

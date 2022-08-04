using GenshinDB.Context;
using GenshinDB.Models;
using GenshinDB.Repositories.Interfaces;

namespace GenshinDB.Repositories
{
    public class NationRepository : INationRepository
    {
        private readonly AppDbContext _context;

        public NationRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Nations> Nations => _context.Nations;
    }
}

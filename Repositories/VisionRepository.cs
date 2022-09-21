using GenshinDB.Context;
using GenshinDB.Models;
using GenshinDB.Repositories.Interfaces;

namespace GenshinDB.Repositories
{
    public class VisionRepository : IVisionRepository
    {
        private readonly AppDbContext _context;

        public VisionRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Visions> Visions => _context.Visions;
    }
}

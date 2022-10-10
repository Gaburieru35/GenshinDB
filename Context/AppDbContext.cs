using GenshinDB.Models;
using Microsoft.EntityFrameworkCore;

namespace GenshinDB.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Nations> Nations { get; set; }
        public DbSet<Characters> Characters { get; set; }
        public DbSet<WeaponSubStatusType> WeaponSubStatusType { get; set; }
        public DbSet<Weapons> Weapons { get; set; }
        public DbSet<Visions> Visions { get; set; }
        public DbSet<CharactersTags> CharactersTags { get; set; }

    }
}

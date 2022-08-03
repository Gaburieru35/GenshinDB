﻿using GenshinDB.Models;
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
    }
}

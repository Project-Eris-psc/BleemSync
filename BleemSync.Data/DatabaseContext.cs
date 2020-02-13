﻿using BleemSync.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BleemSync.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Platform> Consoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=BleemSync Library.db");
    }
}

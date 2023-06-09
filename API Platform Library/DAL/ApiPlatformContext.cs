﻿using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace API_Platform_Library.DAL
{
    public class ApiPlatformContext : DbContext
    {
        public ApiPlatformContext(DbContextOptions<ApiPlatformContext> options) : base(options) { }

        public DbSet<Models.Tarot.Tarot> Tarot { get; set; }
        public DbSet<Models.Tarot.EkelenSchema> Ekelen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MEOWMERGEMKIV; Database=ApiPlatformDB; TrustServerCertificate=True; Encrypt=False; Trusted_Connection=True;");
        }
    }
}

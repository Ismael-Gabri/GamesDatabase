using GamesDatabase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDatabase.Domain.Infra.Contexts
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions <GamesContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().ToTable("Game");
            modelBuilder.Entity<Game>().Property(x => x.Id);
            modelBuilder.Entity<Game>().Property(x => x.Name).HasMaxLength(60).HasColumnType("NVARCHAR");
            modelBuilder.Entity<Game>().Property(x => x.Type).HasMaxLength(60).HasColumnType("NVARCHAR");
            modelBuilder.Entity<Game>().Property(x => x.Genre).HasMaxLength(30).HasColumnType("NVARCHAR");
            modelBuilder.Entity<Game>().Property(x => x.InitialPrice).HasColumnType("DOUBLE");
            modelBuilder.Entity<Game>().Property(x => x.Discount_Percentage).HasColumnType("DOUBLE");
            modelBuilder.Entity<Game>().Property(x => x.FinalPrice).HasColumnType("DOUBLE");
            modelBuilder.Entity<Game>().Property(x => x.ScreenshotPath).HasMaxLength(300).HasColumnType("NVARCHAR");
        }
    }
}

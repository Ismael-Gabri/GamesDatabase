using GamesDatabase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace GamesDatabase.Domain.Infra.Contexts
{
    public class GamesContext : DbContext
    {
        public GamesContext() { }
        public GamesContext(DbContextOptions <GamesContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Server=localhost,1433\\SQLEXPRESS;Database=GamesDb;User ID=sa;Encrypt=False;Password=1q2w3e4r@#$");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().ToTable("Game");
            modelBuilder.Entity<Game>().Property(x => x.Id);
            modelBuilder.Entity<Game>().Property(x => x.Name).HasMaxLength(60).HasColumnType("NVARCHAR");
            modelBuilder.Entity<Game>().Property(x => x.Type).HasMaxLength(60).HasColumnType("NVARCHAR");
            modelBuilder.Entity<Game>().Property(x => x.Genre).HasMaxLength(30).HasColumnType("NVARCHAR");
            modelBuilder.Entity<Game>().Property(x => x.InitialPrice).HasColumnType("DECIMAL");
            modelBuilder.Entity<Game>().Property(x => x.Discount_Percentage).HasColumnType("DECIMAL");
            modelBuilder.Entity<Game>().Property(x => x.FinalPrice).HasColumnType("DECIMAL");
            modelBuilder.Entity<Game>().Property(x => x.ScreenshotPath).HasMaxLength(300).HasColumnType("NVARCHAR");
        }
    }
}

//Server=localhost;1433;Database=GamesDb;User ID=sa; Encrypt=False; Password=1q2w3e4r@#$
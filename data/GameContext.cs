using Microsoft.EntityFrameworkCore;

namespace GameStore.GamesDots;

public class GameContext(DbContextOptions<GameContext> options) : DbContext(options)
{
public DbSet<Game> Games => Set<Game>();

public DbSet<Genre> Genres => Set<Genre>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Genre>().HasData(
        new {Id = 1, Name = "Fighting"},
        new {Id = 2, Name = "RolePlaying"},
        new {Id = 3, Name = "Racing"},
        new {Id = 4, Name = "Sports"}
      );
    }
}

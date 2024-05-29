using Microsoft.EntityFrameworkCore;

namespace RSOD.Models;
public class GameDBContext : DbContext
{
    public GameDBContext(DbContextOptions<GameDBContext> options) : base(options)
    {

    }
    public DbSet<Game> Games { get; set; }
    public DbSet<Collection> Collections { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserCollection> UserCollections { get; set; }
}
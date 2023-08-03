#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Models;
public class DBContext : DbContext
{
    public DBContext(DbContextOptions options) : base(options) {}
    public DbSet<DBContext> PokemonParties { get; set; }
}
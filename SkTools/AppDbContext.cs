using Microsoft.EntityFrameworkCore;

namespace SkTools;

public class AppDbContext : DbContext
{
    public DbSet<RecordEntry> Records => Set<RecordEntry>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=meine_datenbank.db");
}
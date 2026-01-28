using Microsoft.EntityFrameworkCore;
using SkTools.menue; // Namespace für die neuen Klassen

namespace SkTools;

public class AppDbContext : DbContext
{
    public DbSet<RecordEntry> Records => Set<RecordEntry>();
    
    // Neue Tabellen für Menüs
    public DbSet<MenueGruppe> MenueGruppen => Set<MenueGruppe>();
    public DbSet<MenueEintrag> MenueEintraege => Set<MenueEintrag>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=meine_datenbank.db");
}
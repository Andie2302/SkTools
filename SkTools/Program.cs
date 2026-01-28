// See https://aka.ms/new-console-template for more information


using SkTools;
using SkTools.menue;

Console.WriteLine("Hello, World!");


using var db = new AppDbContext();
await db.Database.EnsureCreatedAsync();

// 1. Erstellen einer Gruppe mit Einträgen
var neueGruppe = new MenueGruppe(1, "Getränke", "#FF5733", true, new List<MenueEintrag>());

var eintrag1 = new MenueEintrag(1, "Mineralwasser 0.5l", "Wasser", "#0000FF", false, 2.50m, 19m, 1);
var eintrag2 = new MenueEintrag(2, "Apfelsaftschorle 0.5l", "Schorle", "#FFFF00", false, 3.20m, 19m, 1);

neueGruppe.MenueEinträge.Add(eintrag1);
neueGruppe.MenueEinträge.Add(eintrag2);

// 2. Speichern (Die Gruppe und alle enthaltenen Einträge werden gespeichert)
db.MenueGruppen.Add(neueGruppe);
await db.SaveChangesAsync();
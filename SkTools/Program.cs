// See https://aka.ms/new-console-template for more information


using SkTools;
using SkTools.menue;

Console.WriteLine("Hello, World!");


await using var db = new AppDbContext();
await db.Database.EnsureCreatedAsync();

// 1. Erstellen einer Gruppe mit Einträgen

var neueGruppe = new MenueGruppe 
{ 
    Id = 1, 
    Name = "Getränke", 
    Color = "#FF5733", 
    Einblenden = true 
};

neueGruppe.MenueEinträge.Add(new MenueEintrag 
{ 
    Id = 1, 
    NameLang = "Wasser", 
    Price = 2.50m, 
    MenueGruppeId = 1 
});

neueGruppe.MenueEinträge.Add(new MenueEintrag 
{ 
    Id = 2, 
    NameLang = "Schorle", 
    Price = 3.20m, 
    MenueGruppeId = 1 
});

// 2. Speichern (Die Gruppe und alle enthaltenen Einträge werden gespeichert)
db.MenueGruppen.Add(neueGruppe);
await db.SaveChangesAsync();
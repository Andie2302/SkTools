// See https://aka.ms/new-console-template for more information

using SkTools;

Console.WriteLine("Hello, World!");


using var db = new AppDbContext();

// ERSTELLEN: Legt die Datei 'meine_datenbank.db' an, falls sie fehlt
await db.Database.EnsureCreatedAsync();

// DATENSATZ ERSTELLEN
var neuerEintrag = new RecordEntry 
{ 
    Name = "Import aus CSV", 
    Date = DateTime.Now 
};

// HINZUFÜGEN
db.Records.Add(neuerEintrag);

// SPEICHERN: Erst hier wird die Datenbank wirklich beschrieben
await db.SaveChangesAsync();

Console.WriteLine("Datenbank erstellt und Record gespeichert!");
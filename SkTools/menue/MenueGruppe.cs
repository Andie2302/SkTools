namespace SkTools.menue;

public record MenueGruppe(
    int Id, // Primärschlüssel
    string Name,
    string Color,
    bool Einblenden,
    List<MenueEintrag> MenueEinträge // EF Core erkennt dies als 1-zu-n Beziehung
);
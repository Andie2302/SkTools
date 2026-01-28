namespace SkTools.menue;

public record MenueGruppe(
    string Name,  //Name der Gruppe
    int Id, //Id der Gruppe (Ganzzahl)
    string Color, // Farbe der Gruppe (HEX-Code)
    bool Einblenden, // Wird die Gruppe angezeigt? (true/false)
    List<MenueEintrag> MenueEinträge // Liste der Menüeinträge in dieser Gruppe
);
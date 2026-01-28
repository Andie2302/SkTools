namespace SkTools.menue;

public record MenueGruppe(
    string Name,
    string Id,
    string Color,
    string Active,
    string PrinterId,
    List<MenueEintrag> MenueEinträge
);
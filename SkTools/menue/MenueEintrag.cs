namespace SkTools.menue;

public record MenueEintrag(
    string NameLang, // Name des Eintrags
    string NameKurz, // Kurzer Name des Eintrags
    int Id, // Id des Eintrags (Ganzzahl)
    string Color, // Farbe des Eintrags (HEX-Code)
    bool IstTrenner, // Ist dieser Eintrag ein Trenner? (true/false)
    decimal Price, // Preis des Eintrags (Dezimalzahl)
    decimal Mehrwertsteuer // Steuerbetrag in Prozent
);
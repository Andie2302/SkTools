namespace SkTools.menue;

public record MenueEintrag(
    int Id, // Primärschlüssel
    string NameLang,
    string NameKurz,
    string Color,
    bool IstTrenner,
    decimal Price,
    decimal Mehrwertsteuer,
    int MenueGruppeId // Fremdschlüssel zur Gruppe
);
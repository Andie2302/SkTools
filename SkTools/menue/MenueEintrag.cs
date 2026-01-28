namespace SkTools.menue;

public record MenueEintrag(
    string NameLong, // Name des Eintrags
    string NameShort, // Kurzer Name des Eintrags
    int Id, // Id des Eintrags (Ganzzahl)
    string Color, // Farbe des Eintrags (HEX-Code)
    bool EmptyItem, // Ist das Eintrag Trennlinie? (true/false) false leerer string... true = 1
    decimal Price, // Preis des Eintrags (Dezimalzahl)
    int Vat, // Steuerbetrag in Prozent (Ganzzahl)
    bool ImmediateEdit, // Unbekannte Eigenschaft
    string ImmediateField, // Unbekannte Eigenschaft
    string AccountNumber, // Konto-Nr.
    string ArticleNumber, // Artikelnummer Intern
    string EanCode, // EAN-Code (falls vorhanden)
    int PrinterId, // Id des Druckers (Ganzzahl)
    string ExtraIds, // Unbekannte Eigenschaft
    string Favorite, // Unbekannte Eigenschaft
    string FavoriteIndex, // Unbekannte Eigenschaft
    string FavoriteColor // Unbekannte Eigenschaft
);
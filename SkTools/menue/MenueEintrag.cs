
namespace SkTools.menue;

public class MenueEintrag
{
    public int Id { get; set; }
    public string NameLang { get; set; } = string.Empty;
    public string NameKurz { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public bool IstTrenner { get; set; }
    public decimal Price { get; set; }
    public decimal Mehrwertsteuer { get; set; }
    
    // Fremdschlüssel
    public int MenueGruppeId { get; set; }
}
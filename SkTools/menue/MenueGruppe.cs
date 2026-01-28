
namespace SkTools.menue;

public class MenueGruppe
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public bool Einblenden { get; set; }
    
    // Initialisiere die Liste direkt, um NullReferenceExceptions zu vermeiden
    public List<MenueEintrag> MenueEinträge { get; set; } = new();
}
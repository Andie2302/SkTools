namespace SkTools;

public class RecordEntry
{
    public int Id { get; set; } // Wird automatisch von SQLite hochgezählt
    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}
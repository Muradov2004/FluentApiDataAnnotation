using Microsoft.VisualBasic;

public class Faculty
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString() => $"{Id}. {Name}";
}
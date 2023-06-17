public class Chair
{
    public int Id { get; set; }
    public decimal Financing { get; set; }
    public string? Name { get; set; }

    public override string ToString() => $"{Id}. {Name} - {Financing}";
}

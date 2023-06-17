public class Group
{
    public int Id { get; set; }
    public string GroupName { get; set; }
    public int Rating { get; set; }
    public int Year { get; set; }

    public override string ToString() => $"{Id}. {GroupName} - {Rating} - {Year}";
}

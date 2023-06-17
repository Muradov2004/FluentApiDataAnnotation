public class Teacher
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public decimal Premium { get; set; }
    public decimal Salary { get; set; }
    public DateTime EmploymentDate { get; set; }

    public override string ToString() => $"{Id}. {Name} {Surname}";
}

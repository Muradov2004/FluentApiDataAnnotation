public class Teacher
{
    /*
Homework 2
■ Wage rate (Salary). Teacher's wage rate.
▷ Data type is money.
▷ Cannot contain null values.
▷ Cannot be less than or equal to 0.
■ Surname. Teacher's surname.
▷ Data type is nvarchar(max).
▷ Cannot contain null values.
▷ Cannot be empty.
      */

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public decimal Premium { get; set; }
    public decimal Salary { get; set; }
    public DateTime EmploymentDate { get; set; }

    public override string ToString() => $"{Id}. {Name} {Surname}";
}

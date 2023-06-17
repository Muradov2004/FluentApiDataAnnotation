using (AcademyContext database = new())
{
    Group group = new()
    {
        GroupName = "group1",
        Year = 1,
        Rating = 1
    };

    Chair chair = new()
    {
        Name = "chair1",
        Financing = 10
    };

    Faculty faculty = new()
    {
        Name = "faculty"
    };

    Teacher teacher = new()
    {
        Name = "Salam",
        Surname = "Salammm",
        Premium = 100,
        Salary = 100,
        EmploymentDate = DateTime.Now,
    };

    database.Groups.Add(group);
    database.Chairs.Add(chair);
    database.Teachers.Add(teacher);
    database.SaveChanges();
}

using Microsoft.EntityFrameworkCore;




class AcademyContext : DbContext
{
    public AcademyContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }
}
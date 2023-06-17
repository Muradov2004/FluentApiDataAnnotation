using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class AcademyContext : DbContext
{
    public DbSet<Group> Groups { get; set; }
    public DbSet<Chair> Chairs { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    public AcademyContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString;
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("AppConfig.json");
        var config = builder.Build();
        connectionString = config.GetConnectionString("DefaultConnection")!;
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Group>(entity =>
        {
            entity.Property(e => e.Id)
                                    .ValueGeneratedOnAdd();
            entity.Property(e => e.GroupName)
                                            .HasMaxLength(10)
                                            .IsRequired();
            entity.HasIndex(e => e.GroupName)
                                            .IsUnique();
            entity.Property(e => e.Rating)
                                        .IsRequired()
                                        .HasAnnotation("MinValue", 0)
                                        .HasAnnotation("MaxValue", 5);
            entity.Property(e => e.Year)
                                        .IsRequired()
                                        .HasAnnotation("MinValue", 1)
                                        .HasAnnotation("MaxValue", 5);
        });

        modelBuilder.Entity<Chair>(entity =>
        {
            entity.Property(e => e.Id)
                                    .ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                                        .HasMaxLength(100)
                                        .IsRequired();
            entity.HasIndex(e => e.Name)
                                        .IsUnique();
            entity.Property(e => e.Financing)
                                        .IsRequired()
                                        .HasColumnType("money")
                                        .HasAnnotation("MinValue", 0)
                                        .HasDefaultValue(0);
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.Property(e => e.Id)
                                    .ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                                        .HasMaxLength(100)
                                        .IsRequired();
            entity.HasIndex(e => e.Name)
                                        .IsUnique();
        });


    }
}
using System.Data.Entity;

namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.EntityFrameworkCodeFirstModelPropertiesConfiguration;

public class StudentDbContext : DbContext
{
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
    public DbSet<Student> Students { get; set; }
}
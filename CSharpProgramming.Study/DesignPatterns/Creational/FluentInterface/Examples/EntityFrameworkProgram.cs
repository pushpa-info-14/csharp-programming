using System.Data.Entity;

namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples;

public class EntityFrameworkProgram
{
	public class Student
	{
		public int StudentId { get; set; }

		public string Name { get; set; }

		public DateTime DateOfBirth { get; set; }
	}

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

	public static void Test()
	{
		/**
        using var context = new StudentDbContext();
        var students = context.Students
            .Where(s => DateTime.Now.Year - s.DateOfBirth.Year >= 20)
            .OrderBy(s => s.Name)
            .ToList();
        foreach (var student in students)
        {
            Console.WriteLine(student.Name);
        }
        */
	}
}

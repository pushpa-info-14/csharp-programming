namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.EntityFrameworkCodeFirstModelPropertiesConfiguration
{
    public class EntityFrameworkProgram
    {
        public void Test()
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
}

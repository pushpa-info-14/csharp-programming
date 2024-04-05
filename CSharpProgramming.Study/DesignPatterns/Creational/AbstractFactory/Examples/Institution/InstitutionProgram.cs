namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Institution
{
    public class InstitutionProgram
    {
        public void Test()
        {
            Console.WriteLine("Front End Course and Source Details");
            ISourceCourseFactory offlineSourceCourseFactory = new OfflineSourceCourseFactory();

            var course = offlineSourceCourseFactory.GetCourse();
            Console.WriteLine(course.GetCourseName());
            Console.WriteLine(course.GetCourseFee());
            Console.WriteLine(course.GetCourseDuration());

            var source = offlineSourceCourseFactory.GetSource();
            Console.WriteLine(source.GetSourceName());

            Console.WriteLine("\n----------------------\n");

            Console.WriteLine("Back End Course and Source Details");
            ISourceCourseFactory onlineSourceCourseFactory = new OnlineSourceCourseFactory();

            course = onlineSourceCourseFactory.GetCourse();
            Console.WriteLine(course.GetCourseName());
            Console.WriteLine(course.GetCourseFee());
            Console.WriteLine(course.GetCourseDuration());

            source = onlineSourceCourseFactory.GetSource();
            Console.WriteLine(source.GetSourceName());
        }
    }
}

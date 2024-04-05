namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Institution
{
    public class OfflineSourceCourseFactory : ISourceCourseFactory
    {
        public ISource GetSource()
        {
            return new Offline();
        }
        public ICourse GetCourse()
        {
            return new FrontEndCourse();
        }
    }
}

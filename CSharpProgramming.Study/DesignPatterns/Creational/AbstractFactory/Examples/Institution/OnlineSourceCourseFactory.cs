namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Institution
{
    public class OnlineSourceCourseFactory : ISourceCourseFactory
    {
        public ISource GetSource()
        {
            return new Online();
        }
        public ICourse GetCourse()
        {
            return new BackEndCourse();
        }
    }
}

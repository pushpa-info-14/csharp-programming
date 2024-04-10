namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Institution
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

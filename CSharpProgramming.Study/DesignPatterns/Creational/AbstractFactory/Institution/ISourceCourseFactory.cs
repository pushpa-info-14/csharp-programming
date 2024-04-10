namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Institution
{
    // The AbstractFactory interface
    // The Abstract Factory interface declares a set of methods that return different abstract products. 
    // These products are called a family. 
    // A family of products may have several variants
    public interface ISourceCourseFactory
    {
        //Abstract Product A
        ISource GetSource();
        //Abstract Product B
        ICourse GetCourse();
    }
}

namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.Institution
{
    // The ProductB1 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following BackEndCourse Product Belongs to the Course product family
    public class BackEndCourse : ICourse
    {
        public string GetCourseDuration()
        {
            return "6 Months";
        }
        public int GetCourseFee()
        {
            return 1000;
        }
        public string GetCourseName()
        {
            return "C#, Java, and Python";
        }
    }
}

namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Institution
{
    // The ProductA1 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following FrontEndCourse Product Belongs to the Course product family
    public class FrontEndCourse : ICourse
    {
        public string GetCourseName()
        {
            return "HTML, CSS, and Bootstrap";
        }
        public string GetCourseDuration()
        {
            return "6 Months";
        }
        public int GetCourseFee()
        {
            return 2000;
        }
    }
}

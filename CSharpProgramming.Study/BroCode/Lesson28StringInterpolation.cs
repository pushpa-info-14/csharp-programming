namespace CSharpProgramming.Study.BroCode
{
    public class Lesson28StringInterpolation
    {
        public void Method1()
        {
            // string interpolation - Allows us to insert variables into a string literal
            //                        Precede a string literal with $
            //                        {} are placeholders

            var firstName = "Pushpa";
            var lastName = "Kumara";

            Console.WriteLine($"Hello {firstName} {lastName}");
        }
    }
}

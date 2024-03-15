namespace CSharpProgramming.Study.BroCode
{
    public class Lesson27ConditionalOperator
    {
        public void Method1()
        {
            // conditional operator - Used in conditional assignment if a condition is true/false
            // (condition) ? x : y

            var temperature = 20;
            var message = (temperature >= 15) ? "It is warm outside!" : "It is cold outside!";

            Console.WriteLine(message);
        }
    }
}

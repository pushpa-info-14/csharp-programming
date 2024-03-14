namespace CSharpProgramming.Study.BroCode
{
    public class Lesson05UserInput
    {
        public void Method1()
        {
            Console.WriteLine("What is your name ?");
            string name = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("What is your age ?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");
        }
    }
}

namespace CSharpProgramming.Study.BroCode
{
    public class Lesson11IfStatements
    {
        public void Method1()
        {
            // if statement - A basic form of decision making

            Console.WriteLine("Please enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }
        }
    }
}

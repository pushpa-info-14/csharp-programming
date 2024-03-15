namespace CSharpProgramming.Study.BroCode
{
    public class Lesson19CalculatorProgram
    {
        public void Method1()
        {
            var playAgain = true;

            do
            {
                double result = 0;

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("------- Calculator Program ----------");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("Enter number 1: ");
                var num1 = Convert.ToDouble(Console.ReadLine() ?? string.Empty);

                Console.WriteLine("Enter number 2: ");
                var num2 = Convert.ToDouble(Console.ReadLine() ?? string.Empty);

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }

                Console.WriteLine("Would you like to continue (Y/N): ");
                var response = Console.ReadLine() ?? string.Empty;
                response = response.ToUpper();

                playAgain = response == "Y";
            } while (playAgain);
        }
    }
}

namespace CSharpProgramming.Study.BroCode
{
	public class Lesson17NumberGuessingGame
	{
		public void Method1()
		{
			var random = new Random();
			var playAgain = true;
			const int min = 1;
			const int max = 100;

			while (playAgain)
			{
				var guess = 0;
				var numberOfGuesses = 0;
				var number = random.Next(min, max + 1);

				while (guess != number)
				{
					Console.WriteLine("Guess a number between " + min + " - " + max + ": ");
					guess = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Guess : " + guess);

					if (guess > number)
					{
						Console.WriteLine(guess + " is to high!");
					}
					else if (guess < number)
					{
						Console.WriteLine(guess + " is to low!");
					}

					numberOfGuesses++;
				}

				Console.WriteLine("Number: " + number);
				Console.WriteLine("YOU WIN!");
				Console.WriteLine("Number Of Guesses: " + numberOfGuesses);

				Console.WriteLine("Would you like to play again (Y/N): ");
				var response = Console.ReadLine() ?? string.Empty;
				response = response.ToUpper();

				playAgain = response == "Y";
			}

			Console.WriteLine("Thanks for playing!... I guess");
		}
	}
}

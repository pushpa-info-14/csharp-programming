namespace CSharpProgramming.Study.BroCode
{
	public class Lesson18RockPaperScissorsGame
	{
		public void Method1()
		{
			var random = new Random();
			var playAgain = true;
			var choices = new string[] { "ROCK", "PAPER", "SCISSORS" };

			while (playAgain)
			{
				var playerChoice = "";
				var computerChoice = choices[random.Next(0, 3)];

				while (!choices.Contains(playerChoice))
				{
					Console.WriteLine("Enter Rock, Paper or Scissors: ");
					playerChoice = (Console.ReadLine() ?? string.Empty).ToUpper();
				}

				Console.WriteLine("Player: " + playerChoice);
				Console.WriteLine("Computer: " + computerChoice);

				if (playerChoice == computerChoice)
				{
					Console.WriteLine("It is a tie!");
				}
				else
				{
					var result = "";
					switch (playerChoice)
					{
						case "ROCK":
							result = computerChoice == "SCISSORS" ? "You win!" : "You lose!";
							break;
						case "PAPER":
							result = computerChoice == "ROCK" ? "You win!" : "You lose!";
							break;
						case "SCISSORS":
							result = computerChoice == "PAPER" ? "You win!" : "You lose!";
							break;
					}

					Console.WriteLine(result);
				}

				Console.WriteLine("Would you like to play again (Y/N): ");
				var response = Console.ReadLine() ?? string.Empty;
				response = response.ToUpper();

				playAgain = response == "Y";
			}
		}
	}
}

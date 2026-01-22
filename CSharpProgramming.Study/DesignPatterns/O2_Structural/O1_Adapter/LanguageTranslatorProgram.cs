namespace CSharpProgramming.Study.DesignPatterns.O2_Structural.O1_Adapter;

public class LanguageTranslatorProgram
{
	public interface IEnglishSpeaker
	{
		string AskQuestion(string words);
		string AnswerForTheQuestion(string words);
	}

	// John is from USA, So he can speak and understand only English
	public class John : IEnglishSpeaker
	{
		public string AskQuestion(string words)
		{
			Console.WriteLine("Question Asked by John [English Speaker and Can understand only English] : " + words);
			ITarget target = new Pam();
			return target.TranslateAndTellToOtherPerson(words, "French");
		}

		public string AnswerForTheQuestion(string words)
		{
			string reply = null;
			if (words.Equals("where are you?", StringComparison.InvariantCultureIgnoreCase))
			{
				reply = "I am in USA";
			}
			return reply;
		}
	}

	public interface IFrenchSpeaker
	{
		string AskQuestion(string words);
		string AnswerForTheQuestion(string words);
	}

	// David is from France and can speak and understand only French
	public class David : IFrenchSpeaker
	{
		public string AskQuestion(string words)
		{
			Console.WriteLine("Question Asked by David [French Speaker and Can understand only French] : " + words);
			ITarget target = new Pam();
			return target.TranslateAndTellToOtherPerson(words, "English");
		}

		public string AnswerForTheQuestion(string words)
		{
			string reply = null;
			if (words.Equals("comment allez-vous?", StringComparison.InvariantCultureIgnoreCase))
			{
				reply = "Je suis très bien";
			}
			return reply;
		}
	}

	public interface ITarget
	{
		string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
	}

	// Adapter or Translator
	// Pam can speak and understand both English and French
	// She acts as an Adapter or Translator
	public class Pam : ITarget
	{
		private static readonly Dictionary<string, string> EnglishFrenchDictionary = new();
		private static readonly Dictionary<string, string> FrenchEnglishDictionary = new();
		private readonly David _david = new();
		private readonly John _john = new();

		static Pam()
		{
			EnglishFrenchDictionary.Add("how are you?", "comment allez-vous?");
			EnglishFrenchDictionary.Add("I am in USA", "Je suis aux Etats-Unis");
			FrenchEnglishDictionary.Add("Je suis très bien", "I am fine");
			FrenchEnglishDictionary.Add("oC9 C*tes-vous?", "where are you?");
		}

		public string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage)
		{
			if (convertToWhichLanguage.Equals("English", StringComparison.InvariantCultureIgnoreCase))
			{
				var englishWords = ConvertToEnglish(words);
				Console.WriteLine("\nPam Converted \"" + words + " \" to \"" + englishWords + " and send the question to John");

				var englishWordsReply = _john.AnswerForTheQuestion(englishWords);
				Console.WriteLine("Pam Got reply from John in English : \"" + englishWordsReply + "\"");

				var frenchConverted = ConvertToFrench(englishWordsReply);
				Console.WriteLine("Pam Converted \"" + englishWordsReply + "\" to \"" + frenchConverted + "\" and send back to David\n");
				return frenchConverted;
			}
			else if (convertToWhichLanguage.Equals("French", StringComparison.InvariantCultureIgnoreCase))
			{
				var frenchWords = ConvertToFrench(words);
				Console.WriteLine("\nPam Converted \"" + words + " \" to \"" + frenchWords + " and send the question to David");

				var frenchWordsReply = _david.AnswerForTheQuestion(frenchWords);
				Console.WriteLine("Pam Got reply from David in French : \"" + frenchWordsReply + "\"");

				var englishConverted = ConvertToEnglish(frenchWordsReply);
				Console.WriteLine("Pam Converted \"" + frenchWordsReply + "\" to \"" + englishConverted + "\" and send back to John\n");
				return englishConverted;
			}
			else
			{
				return "Sorry Cannot Covert";
			}
		}

		public string ConvertToFrench(string words)
		{
			return EnglishFrenchDictionary[words];
		}

		public string ConvertToEnglish(string words)
		{
			return FrenchEnglishDictionary[words];
		}
	}

	public void Test()
	{
		var replyFromDavid = new John().AskQuestion("how are you?");
		Console.WriteLine("Reply From David [French Speaker can Speak and Understand only French] :  " + replyFromDavid);
		Console.WriteLine();
		var replyFromJohn = new David().AskQuestion("oC9 C*tes-vous?");
		Console.WriteLine("Reply From John [English Speaker can Speak and Understand only English] :  " + replyFromJohn);
	}
}

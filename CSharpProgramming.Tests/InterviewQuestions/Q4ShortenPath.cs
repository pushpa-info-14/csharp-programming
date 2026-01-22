using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.InterviewQuestions;

public class Q4ShortenPath(ITestOutputHelper output) : BaseTest(output)
{
	public class Solution
	{
		public string ShortenPath(string fullPath, int maxLength)
		{
			if (fullPath.Length < maxLength)
			{
				return fullPath;
			}

			var splits = fullPath.Split('\\');
			var root = splits[0];
			var fileName = splits.Last();
			var availableSpace = maxLength - (root.Length + fileName.Length + 3);
			if (availableSpace < 0)
			{
				return root + "\\...\\" + fileName;
			}

			var curLength = root.Length + fileName.Length + 3;
			var middle = "";
			var i = 1;
			while (curLength <= maxLength)
			{
				curLength += splits[i].Length;
				if (curLength <= maxLength)
				{
					middle += splits[i] + "\\";
					curLength += splits[i].Length;
					i++;
				}
			}

			return root + "\\" + middle + "...\\" + fileName;
		}
	}

	[Fact]
	public void Test()
	{
		var solution = new Solution();
		Print(solution.ShortenPath(@"C:\Users\JohnDoe\Documents\Projects\MyProject\File.txt", 30));
		Print(solution.ShortenPath(@"C:\Users\JohnDoe\Documents\Projects\MyProject\Fileeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee.txt", 30));
	}
}

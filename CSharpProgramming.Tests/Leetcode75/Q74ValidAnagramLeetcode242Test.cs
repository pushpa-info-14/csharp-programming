using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q74ValidAnagramLeetcode242Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q74ValidAnagramLeetcode242();

            var answer1 = solution.IsAnagram("anagram", "nagaram");
            var answer2 = solution.IsAnagram("rat", "car");
            var answer3 = solution.IsAnagram("aa", "a");
            var answer4 = solution.IsAnagram("aacc", "ccac");

            ConsoleLogger.Print(answer1);
            ConsoleLogger.Print(answer2);
            ConsoleLogger.Print(answer3);
            ConsoleLogger.Print(answer4);

            Assert.Multiple(() =>
            {
                Assert.That(answer1, Is.True);
                Assert.That(answer2, Is.False);
                Assert.That(answer3, Is.False);
                Assert.That(answer4, Is.False);
            });
        }
    }
}

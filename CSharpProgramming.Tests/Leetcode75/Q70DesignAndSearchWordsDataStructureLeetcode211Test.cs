using CSharpProgramming.Study.Leetcode75;
using CSharpProgramming.Tests.Utils;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q70DesignAndSearchWordsDataStructureLeetcode211Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q70DesignAndSearchWordsDataStructureLeetcode211();

            solution.AddWord("bad");
            solution.AddWord("dad");
            solution.AddWord("mad");

            var answer1 = solution.Search("pad");
            var answer2 = solution.Search("bad");
            var answer3 = solution.Search(".ad");
            var answer4 = solution.Search("b..");

            ConsoleLogger.Print(answer1);
            ConsoleLogger.Print(answer2);
            ConsoleLogger.Print(answer3);
            ConsoleLogger.Print(answer4);

            Assert.Multiple(() =>
            {
                Assert.That(answer1, Is.False);
                Assert.That(answer2, Is.True);
                Assert.That(answer3, Is.True);
                Assert.That(answer4, Is.True);
            });
        }
    }
}

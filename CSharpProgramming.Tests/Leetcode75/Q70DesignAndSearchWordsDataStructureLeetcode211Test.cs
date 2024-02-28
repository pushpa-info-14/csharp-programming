using CSharpProgramming.Study.Leetcode75;
using Newtonsoft.Json;

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
            Print(solution.Search("pad"));
            Print(solution.Search("bad"));
            Print(solution.Search(".ad"));
            Print(solution.Search("b.."));
        }

        private void Print(object data)
        {
            Console.WriteLine(JsonConvert.SerializeObject(data));
        }
    }
}

using CSharpProgramming.Study.Leetcode75;
using Newtonsoft.Json;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q32GraphValidTreeLeetcode261Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q32GraphValidTreeLeetcode261();
            Print(solution.GraphValidTree(5, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 1, 4 } }));
        }

        private void Print(object data)
        {
            Console.WriteLine(JsonConvert.SerializeObject(data));
        }
    }
}

using CSharpProgramming.Study.Leetcode75;
using Newtonsoft.Json;

namespace CSharpProgramming.Tests.Leetcode75
{
    public class Q1TwoSumHashMapLeetcode1Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var solution = new Q1TwoSumHashMapLeetcode1();
            Print(solution.TwoSum(new[] { 2, 7, 11, 15 }, 9));
            Print(solution.TwoSum(new[] { 2, 1, 5, 3 }, 4));
        }

        private void Print(object data)
        {
            Console.WriteLine(JsonConvert.SerializeObject(data));
        }
    }
}

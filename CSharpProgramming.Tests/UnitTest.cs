namespace CSharpProgramming.Tests
{
    public class UnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var hashSet = new HashSet<string>();
            hashSet.Add("12");

            var answer = hashSet.Contains("12");

            Assert.That(answer, Is.True);

            var tupleHashSet = new HashSet<Tuple<int, int>>();
            tupleHashSet.Add(new Tuple<int, int>(1, 1));

            answer = tupleHashSet.Contains(new Tuple<int, int>(1, 1));

            Assert.That(answer, Is.True);
        }
    }
}

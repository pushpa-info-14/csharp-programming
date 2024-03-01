using CSharpProgramming.Study.Leetcode75.Utils;

namespace CSharpProgramming.Tests
{
    public class TrieTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var node = new TrieNode();

            node.Insert("abc");
            node.Insert("abcd");
            node.Insert("abab");

            Assert.That(node.Search("abc"), Is.True);
            Assert.That(node.Search("abcd"), Is.True);
            Assert.That(node.Search("abab"), Is.True);

            node.Remove("abab");
            Assert.That(node.Search("abc"), Is.True);
            Assert.That(node.Search("abcd"), Is.True);
            Assert.That(node.Search("abab"), Is.False);

            node.Remove("abcd");
            Assert.That(node.Search("abc"), Is.True);
            Assert.That(node.Search("abcd"), Is.False);
            Assert.That(node.Search("abab"), Is.False);

            node.Remove("abc");
            Assert.That(node.Search("abc"), Is.False);
            Assert.That(node.Search("abcd"), Is.False);
            Assert.That(node.Search("abab"), Is.False);
        }
    }
}

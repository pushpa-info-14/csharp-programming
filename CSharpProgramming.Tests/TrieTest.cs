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

            node.AddWord("abc");
            node.AddWord("abcd");
            node.AddWord("abab");

            Assert.That(node.Search("abc"), Is.True);
            Assert.That(node.Search("abcd"), Is.True);
            Assert.That(node.Search("abab"), Is.True);

            node.RemoveWord("abab");
            Assert.That(node.Search("abc"), Is.True);
            Assert.That(node.Search("abcd"), Is.True);
            Assert.That(node.Search("abab"), Is.False);

            node.RemoveWord("abcd");
            Assert.That(node.Search("abc"), Is.True);
            Assert.That(node.Search("abcd"), Is.False);
            Assert.That(node.Search("abab"), Is.False);
        }
    }
}

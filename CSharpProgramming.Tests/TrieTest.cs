using CSharpProgramming.Study.Leetcode75.Utils;
using Xunit;

namespace CSharpProgramming.Tests
{
	public class TrieTest
	{
		[Fact]
		public void Test1()
		{
			var node = new TrieNode();

			node.Insert("abc");
			node.Insert("abcd");
			node.Insert("abab");

			Assert.True(node.Search("abc"));
			Assert.True(node.Search("abcd"));
			Assert.True(node.Search("abab"));

			node.Remove("abab");
			Assert.True(node.Search("abc"));
			Assert.True(node.Search("abcd"));
			Assert.False(node.Search("abab"));

			node.Remove("abcd");
			Assert.True(node.Search("abc"));
			Assert.False(node.Search("abcd"));
			Assert.False(node.Search("abab"));

			node.Remove("abc");
			Assert.False(node.Search("abc"));
			Assert.False(node.Search("abcd"));
			Assert.False(node.Search("abab"));
		}
	}
}

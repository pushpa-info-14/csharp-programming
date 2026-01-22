using CSharpProgramming.Study.Leetcode75.Utils;

namespace CSharpProgramming.Study.Leetcode75
{
	public class Q69ImplementTriePrefixTreeLeetcode208
	{
		private readonly TrieNode _root;
		public Q69ImplementTriePrefixTreeLeetcode208()
		{
			_root = new TrieNode();
		}

		public void Insert(string word)
		{
			_root.Insert(word);
		}

		public bool Search(string word)
		{
			return _root.Search(word);
		}

		public bool StartsWith(string prefix)
		{
			return _root.StartsWith(prefix);
		}
	}
}

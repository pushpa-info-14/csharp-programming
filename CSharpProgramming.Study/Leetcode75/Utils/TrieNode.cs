namespace CSharpProgramming.Study.Leetcode75.Utils
{
	public class TrieNode
	{
		public Dictionary<char, TrieNode> Children { get; set; }
		public bool IsWord { get; set; }

		public TrieNode()
		{
			Children = new Dictionary<char, TrieNode>();
			IsWord = false;
		}

		public void Insert(string word)
		{
			var cur = this;
			foreach (var c in word)
			{
				if (!cur.Children.TryGetValue(c, out var trieNode))
				{
					cur.Children.Add(c, new TrieNode());
				}

				cur = cur.Children[c];
			}

			cur.IsWord = true;
		}

		public void Remove(string word)
		{
			var closestBranch = this;
			var character = ' ';
			var cur = this;
			foreach (var c in word)
			{
				if (!cur.Children.ContainsKey(c))
				{
					return;
				}

				if (cur.Children.Count > 1)
				{
					closestBranch = cur;
					character = c;
				}
				cur = cur.Children[c];
			}

			if (cur.IsWord)
			{
				if (character != ' ' && cur.Children.Count == 0)
				{
					closestBranch.Children.Remove(character);
				}
				else
				{
					cur.IsWord = false;
				}
			}
		}

		public bool Search(string word)
		{
			var cur = this;
			foreach (var c in word)
			{
				if (!cur.Children.ContainsKey(c))
				{
					return false;
				}

				cur = cur.Children[c];
			}

			return cur.IsWord;
		}

		public bool StartsWith(string prefix)
		{
			var cur = this;
			foreach (var c in prefix)
			{
				if (!cur.Children.ContainsKey(c))
				{
					return false;
				}

				cur = cur.Children[c];
			}

			return true;
		}

		public bool SearchWithWildcard(string word, char wildcard)
		{
			bool Dfs(int index, TrieNode node)
			{
				var cur = node;

				for (var i = index; i < word.Length; i++)
				{
					var c = word[i];
					if (c == wildcard)
					{
						return cur.Children.Values.Any(child => Dfs(i + 1, child));
					}
					else
					{
						if (!cur.Children.ContainsKey(c))
						{
							return false;
						}

						cur = cur.Children[c];
					}
				}

				return cur.IsWord;
			}

			return Dfs(0, this);
		}
	}
}

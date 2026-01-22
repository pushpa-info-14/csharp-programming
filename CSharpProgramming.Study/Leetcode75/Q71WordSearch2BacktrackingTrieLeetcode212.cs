using CSharpProgramming.Study.Leetcode75.Utils;

namespace CSharpProgramming.Study.Leetcode75
{
	public class Q71WordSearch2BacktrackingTrieLeetcode212
	{
		public IList<string> FindWords(char[][] board, string[] words)
		{
			var root = new TrieNode();
			foreach (var word in words)
			{
				root.Insert(word);
			}

			var rows = board.Length;
			var cols = board[0].Length;
			var results = new HashSet<string>();
			var visited = new HashSet<Tuple<int, int>>();

			void Dfs(int r, int c, TrieNode node, string word)
			{
				if (r < 0 || c < 0 || r == rows || c == cols || !node.Children.ContainsKey(board[r][c]) || visited.Contains(new Tuple<int, int>(r, c)))
				{
					return;
				}

				visited.Add(new Tuple<int, int>(r, c));
				node = node.Children[board[r][c]];
				word += board[r][c];

				if (node.IsWord)
				{
					results.Add(word);
					root.Remove(word);
				}

				Dfs(r + 1, c, node, word);
				Dfs(r - 1, c, node, word);
				Dfs(r, c + 1, node, word);
				Dfs(r, c - 1, node, word);
				visited.Remove(new Tuple<int, int>(r, c));
			}

			for (var r = 0; r < rows; r++)
			{
				for (var c = 0; c < cols; c++)
				{
					Dfs(r, c, root, "");
				}
			}

			return results.ToList();
		}
	}
}

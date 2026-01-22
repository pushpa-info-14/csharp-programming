namespace CSharpProgramming.Study.Leetcode75
{
	public class Q74ValidAnagramLeetcode242
	{
		public bool IsAnagram(string s, string t)
		{
			if (s.Length != t.Length)
			{
				return false;
			}

			var dict = new Dictionary<char, int>();

			foreach (var i in s)
			{
				if (dict.ContainsKey(i))
				{
					dict[i]++;
				}
				else
				{
					dict.Add(i, 1);
				}
			}

			foreach (var i in t)
			{
				if (dict.ContainsKey(i))
				{
					if (dict[i] == 0)
					{
						return false;
					}
					dict[i]--;
				}
				else
				{
					return false;
				}
			}

			return true;
		}
	}
}

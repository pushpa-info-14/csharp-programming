namespace CSharpProgramming.Study.Leetcode75.Utils
{
    public class TrieNode
    {
        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            IsWord = false;
        }

        public Dictionary<char, TrieNode> Children { get; set; }
        public bool IsWord { get; set; }

        public void AddWord(string word)
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

        public void RemoveWord(string word)
        {
            var junction = this;
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
                    junction = cur;
                    character = c;
                }
                cur = cur.Children[c];
            }

            if (cur.IsWord && character != ' ' && cur.Children.Count == 0)
            {
                junction.Children.Remove(character);
            }
        }

        public bool Search(string word)
        {
            bool DFS(int index, TrieNode node)
            {
                var cur = node;

                for (var i = index; i < word.Length; i++)
                {
                    var c = word[i];
                    if (c == '.')
                    {
                        return cur.Children.Values.Any(child => DFS(i + 1, child));
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

            return DFS(0, this);
        }
    }
}

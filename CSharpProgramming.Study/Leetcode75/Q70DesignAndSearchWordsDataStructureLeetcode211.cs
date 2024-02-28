namespace CSharpProgramming.Study.Leetcode75
{
    internal class TrieNode
    {
        public TrieNode()
        {
            Children = new Dictionary<char, TrieNode>();
            IsWord = false;
        }
        public Dictionary<char, TrieNode> Children { get; set; }
        public bool IsWord { get; set; }
    }
    public class Q70DesignAndSearchWordsDataStructureLeetcode211
    {
        private readonly TrieNode _root;

        public Q70DesignAndSearchWordsDataStructureLeetcode211()
        {
            _root = new TrieNode();
        }

        public void AddWord(string word)
        {
            var cur = _root;
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

        public bool Search(string word)
        {
            bool DFS(int index, TrieNode root)
            {
                var cur = root;

                for (var i = index; i < word.Length; i++)
                {
                    var c = word[i];
                    if (c == '.')
                    {
                        return cur.Children.Values.Any(child => DFS(i + 1, child));
                    }
                    else
                    {
                        if (!cur.Children.TryGetValue(c, out var trieNode))
                        {
                            return false;
                        }

                        cur = cur.Children[c];
                    }
                }

                return cur.IsWord;
            }

            return DFS(0, _root);
        }
    }
}

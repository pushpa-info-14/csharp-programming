using CSharpProgramming.Study.Leetcode75.Utils;

namespace CSharpProgramming.Study.Leetcode75
{
    public class Q70DesignAndSearchWordsDataStructureLeetcode211
    {
        private readonly TrieNode _root;

        public Q70DesignAndSearchWordsDataStructureLeetcode211()
        {
            _root = new TrieNode();
        }

        public void AddWord(string word)
        {
            _root.AddWord(word);
        }

        public bool Search(string word)
        {
            return _root.Search(word);
        }
    }
}

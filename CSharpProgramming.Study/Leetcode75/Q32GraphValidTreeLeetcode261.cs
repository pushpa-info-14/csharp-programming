namespace CSharpProgramming.Study.Leetcode75
{
    public class Q32GraphValidTreeLeetcode261
    {
        public bool GraphValidTree(int n, int[][] edges)
        {
            if (n == 0)
            {
                return true;
            }

            var adj = new Dictionary<int, List<int>>();
            for (var i = 0; i < n; i++)
            {
                adj.Add(i, new List<int>());
            }

            foreach (var edge in edges)
            {
                adj[edge[0]].Add(edge[1]);
                adj[edge[1]].Add(edge[0]);
            }

            var visited = new HashSet<int>();

            bool DFS(int i, int previous)
            {
                if (visited.Contains(i))
                {
                    return false;
                }

                visited.Add(i);
                foreach (var j in adj[i])
                {
                    if (j == previous) continue;

                    if (!DFS(j, i))
                    {
                        return false;
                    }
                }
                return true;
            }

            return DFS(0, -1) && visited.Count == n;
        }
    }
}

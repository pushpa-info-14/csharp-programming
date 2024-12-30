namespace CSharpProgramming.Study.DynamicProgramming;

public class GridProblem
{
    public long GridPaths(int n, int m)
    {
        var memo = new Dictionary<(int, int), long>();

        for (int i = 0; i < n; i++)
        {
            memo.Add((i, 0), 1);
        }
        for (int j = 1; j < m; j++)
        {
            memo.Add((0, j), 1);
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < m; j++)
            {
                var result = memo[(i - 1, j)] + memo[(i, j - 1)];

                if (memo.ContainsKey((i, j)))
                {
                    memo[(i, j)] = result;
                }
                else
                {
                    memo.Add((i, j), result);
                }
            }
        }

        return memo[(n - 1, m - 1)];
    }
}

namespace CSharpProgramming.Study.DynamicProgramming;

public class CoinProblem
{
    /*
     * Given a set of coin values and a target sum of money m, 
     * what's the minimum number of coins that form the sum m?
     * 
     * Coins: {1, 4, 5}
     * Target sum: 13
     * 
     * Greedy: 5 coins (5+5+1+1+1)
     * Optimal: 3 coins (4+4+5)
     */

    private readonly Dictionary<long, long> _memo = new Dictionary<long, long>();
    private long _answer = 0;

    public long MinimumCoinsMemo(long m, int[] coins)
    {
        if (_memo.TryGetValue(m, out var result))
        {
            return result;
        }

        if (m == 0)
        {
            _answer = 0;
        }
        else
        {
            _answer = -1;
            foreach (var coin in coins)
            {
                var subproblem = m - coin;

                // Skip solutions where we try to reach [m]
                // from a negative subproblem
                if (subproblem < 0) continue;

                _answer = MinIgnoreNegative(_answer, MinimumCoinsMemo(subproblem, coins) + 1);
            }
        }

        _memo[m] = _answer;
        return _answer;
    }

    public long MinimumCoinsBottomUp(long m, int[] coins)
    {
        var memo = new Dictionary<long, long>
        {
            [0] = 0
        };

        for (int i = 1; i < m + 1; i++)
        {
            foreach (var coin in coins)
            {
                var subproblem = i - coin;
                if (subproblem < 0) continue;

                var result = MinIgnoreNegative(GetMemo(memo, i), memo[subproblem] + 1);

                if (memo.ContainsKey(i))
                {
                    memo[i] = result;
                }
                else
                {
                    memo.Add(i, result);
                }
            }
        }

        return memo[m];
    }

    public long HowManyWays(long m, int[] coins)
    {
        var memo = new Dictionary<long, long>
        {
            [0] = 1
        };

        for (int i = 1; i < m + 1; i++)
        {
            memo[i] = 0;

            foreach (var coin in coins)
            {
                var subproblem = i - coin;
                if (subproblem < 0) continue;

                memo[i] = memo[i] + memo[subproblem];
            }
        }

        return memo[m];
    }

    private long GetMemo(Dictionary<long, long> dictionary, long key)
    {
        if (dictionary.TryGetValue(key, out var answer))
        {
            return answer;
        }
        else
        {
            return -1;
        }
    }

    private long MinIgnoreNegative(long a, long b)
    {
        if (a < 0) return b;
        if (b < 0) return a;
        return a < b ? a : b;
    }
}

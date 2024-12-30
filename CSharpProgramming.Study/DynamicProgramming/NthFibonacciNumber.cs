﻿namespace CSharpProgramming.Study.DynamicProgramming;

public class NthFibonacciNumber
{
    // Naive Approach
    public static long Fib(int n)
    {
        if (n <= 2) return 1;
        else return Fib(n - 1) + Fib(n - 2);
    }

    // Memoization
    private readonly Dictionary<int, long> _memo = new Dictionary<int, long>();

    public long FibMemo(int n)
    {
        if (_memo.TryGetValue(n, out var result))
        {
            return result;
        }

        if (n <= 2)
        {
            return 1;
        }
        else
        {
            result = FibMemo(n - 1) + FibMemo(n - 2);
            _memo.Add(n, result);
            return result;
        }
    }

    // Bottom-up Approach
    // Topological sort order is important

    public static long FibBottomUp(int n)
    {
        var memo = new Dictionary<int, long>
        {
            [0] = 0,
            [1] = 1,
            [2] = 1
        };

        for (var i = 3; i < n + 1; i++)
        {
            memo.Add(i, memo[i - 1] + memo[i - 2]);
        }

        return memo[n];
    }
}

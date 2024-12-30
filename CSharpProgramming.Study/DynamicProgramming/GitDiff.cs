﻿namespace CSharpProgramming.Study.DynamicProgramming;

public class GitDiff
{
    public long GetLength(string[] a, string[] b)
    {
        var dp = Calculate(a, b);

        return dp[a.Length, b.Length];
    }

    public string[] GetElements(string[] a, string[] b)
    {
        var dp = Calculate(a, b);
        var elements = ReconstructElements(dp, a, b);

        return elements;
    }

    public int[,] Calculate(string[] a, string[] b)
    {
        var dp = new int[a.Length + 1, b.Length + 1];


        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                dp[i, j] = 0;
            }
        }

        for (int i = 1; i <= a.Length; i++)
        {
            for (int j = 1; j <= b.Length; j++)
            {
                if (a[i - 1] == b[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        return dp;
    }

    public string[] ReconstructElements(int[,] dp, string[] a, string[] b)
    {
        var elements = new List<string>();

        var i = a.Length;
        var j = b.Length;

        while (i > 0 && j > 0)
        {
            if (a[i - 1] == b[j - 1])
            {
                elements.Add(a[i - 1]);
                i--;
                j--;
            }
            else if (dp[i - 1, j] > dp[i, j - 1])
            {
                i--;
            }
            else
            {
                j--;
            }
        }

        elements.Reverse();
        return elements.ToArray();
    }
}

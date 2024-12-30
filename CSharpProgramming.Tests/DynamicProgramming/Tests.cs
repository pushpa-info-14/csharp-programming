using CSharpProgramming.Study.DynamicProgramming;
using System.Text.Json;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.DynamicProgramming;

public class Tests
{
    private readonly ITestOutputHelper _outputHelper;

    public Tests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void FibTest()
    {
        var fib = new NthFibonacciNumber();

        _outputHelper.WriteLine(NthFibonacciNumber.Fib(7) + "");

        _outputHelper.WriteLine(fib.FibMemo(7) + "");
        _outputHelper.WriteLine(fib.FibMemo(50) + "");

        _outputHelper.WriteLine(NthFibonacciNumber.FibBottomUp(7) + "");
        _outputHelper.WriteLine(NthFibonacciNumber.FibBottomUp(50) + "");
    }

    [Fact]
    public void CoinTest()
    {
        var coinProblem = new CoinProblem();

        _outputHelper.WriteLine(coinProblem.MinimumCoinsMemo(13, [1, 4, 5]) + "");
        _outputHelper.WriteLine(coinProblem.MinimumCoinsMemo(150, [1, 4, 5]) + "");

        _outputHelper.WriteLine(coinProblem.MinimumCoinsBottomUp(13, [1, 4, 5]) + "");
        _outputHelper.WriteLine(coinProblem.MinimumCoinsBottomUp(150, [1, 4, 5]) + "");

        _outputHelper.WriteLine(coinProblem.HowManyWays(5, [1, 4, 5]) + "");
        _outputHelper.WriteLine(coinProblem.HowManyWays(13, [1, 4, 5]) + "");
        _outputHelper.WriteLine(coinProblem.HowManyWays(150, [1, 4, 5]) + "");
    }

    [Fact]
    public void GridPathTest()
    {
        var gridProblem = new GridProblem();

        _outputHelper.WriteLine(gridProblem.GridPaths(18, 6) + "");
        _outputHelper.WriteLine(gridProblem.GridPaths(75, 19) + "");
    }

    [Fact]
    public void LongestCommonSubsequence()
    {
        var longestCommonSubsequence = new LongestCommonSubsequence();

        _outputHelper.WriteLine(longestCommonSubsequence.GetLength([1, 2, 3, 4, 5], [1, 3, 5]) + "");

        var result = longestCommonSubsequence.GetElements([1, 2, 3, 4, 5], [1, 3, 5]);
        _outputHelper.WriteLine(JsonSerializer.Serialize(result));
    }

    [Fact]
    public void LongestCommonPrefix()
    {
        var longestCommonPrefix = new LongestCommonPrefix();

        _outputHelper.WriteLine(longestCommonPrefix.Solution(["flower", "flow", "flight"]) + "");
        _outputHelper.WriteLine(longestCommonPrefix.Solution(["a"]) + "");
    }

    [Fact]
    public void GitDiff()
    {
        PrintDifference(["a", "b", "c", "d", "e"], ["a", "c", "e"]);
    }

    private void PrintDifference(string[] fileA, string[] fileB)
    {
        var gitDiff = new GitDiff();

        var dp = gitDiff.Calculate(fileA, fileB);
        var lcs = gitDiff.ReconstructElements(dp, fileA, fileB);

        var lineA = 0;
        var lineB = 0;

        foreach (var line in lcs)
        {
            while (fileA[lineA] != line)
            {
                _outputHelper.WriteLine($"- {fileA[lineA]}");
                lineA++;
            }
            while (fileB[lineB] != line)
            {
                _outputHelper.WriteLine($"+ {fileB[lineB]}");
                lineB++;
            }

            _outputHelper.WriteLine($"  {fileA[lineA]}");
            lineA++;
            lineB++;
        }

        while (lineA < fileA.Length)
        {
            _outputHelper.WriteLine($"- {fileA[lineA]}");
            lineA++;
        }
        while (lineB < fileB.Length)
        {
            _outputHelper.WriteLine($"+ {fileB[lineB]}");
            lineB++;
        }
    }
}

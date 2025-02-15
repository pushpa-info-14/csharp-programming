using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.InterviewQuestions;

public class Q1FindParentDirectory : BaseTest
{
    public Q1FindParentDirectory(ITestOutputHelper output) : base(output)
    {
    }

    public class Solution
    {
        public string FindParent(string pathInput)
        {
            var stack = new List<string>();

            var paths = pathInput.Split('\\');

            foreach (var path in paths)
            {
                if (path == "..")
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                else if (path.Length > 0)
                {
                    stack.Add(path);
                }
            }

            return stack[stack.Count - 2];
        }
    }

    [Fact]
    public void Test()
    {

        /*
        Example 1:
        Input: C:\temp\Share\abc
        Output: Share

        Example 2:
        Input: C:\temp\Demo\Product\..\abc
        Output: Demo

        Example 3:
        Input: C:\xyz\source\reviewed\..\..\abc\
        Output: xyz

        Example 4:
        Input: C:\cloud\simple\..\addon\..\abc\
        Output: cloud

        Example 5:
        Input: C:\temp\..\bmp\feature\..\xyz\
        Input: C:\bmp\xyz\
        Output: bmp
        */
        var s = new Solution();
        WriteLine(s.FindParent("C:\\temp\\Share\\abc"));
        WriteLine(s.FindParent("C:\\temp\\Demo\\Product\\..\\abc"));
        WriteLine(s.FindParent("C:\\xyz\\source\\reviewed\\..\\..\\abc\\"));
        WriteLine(s.FindParent("C:\\cloud\\simple\\..\\addon\\..\\abc\\"));
        WriteLine(s.FindParent("C:\\temp\\..\\bmp\\feature\\..\\xyz\\"));
    }
}

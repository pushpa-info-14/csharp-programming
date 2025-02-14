using CSharpProgramming.Tests.LeetCode.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.LeetCode.Q1000_1500;

public class Q1352ProductOfTheLastKNumber(ITestOutputHelper output) : BaseTest(output)
{
    public class ProductOfNumbers
    {
        private int _previous = 1;
        private List<int> _prefixProducts;

        public ProductOfNumbers()
        {
            _prefixProducts = new List<int>();
        }

        public void Add(int num)
        {
            _previous = _previous * num;
            if (_previous == 0)
            {
                _prefixProducts = [num];
                _previous = num;
            }
            else
            {
                _prefixProducts.Add(_previous);
            }
        }

        public int GetProduct(int k)
        {
            var size = _prefixProducts.Count;
            if (k > size)
            {
                return 0;
            }
            else if (k == size)
            {
                return _prefixProducts[size - 1];
            }
            else
            {
                return _prefixProducts[size - 1] / _prefixProducts[size - 1 - k];
            }
        }
    }

    [Fact]
    public void Test()
    {
        var s = new ProductOfNumbers();
        s.Add(3);
        s.Add(0);
        s.Add(2);
        s.Add(5);
        s.Add(4);
        Print(s.GetProduct(2));
        Print(s.GetProduct(3));
        Print(s.GetProduct(4));
        s.Add(8);
        Print(s.GetProduct(2));
    }
}

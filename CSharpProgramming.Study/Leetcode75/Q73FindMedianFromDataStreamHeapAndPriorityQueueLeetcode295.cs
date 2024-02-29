namespace CSharpProgramming.Study.Leetcode75
{
    public class Q73FindMedianFromDataStreamHeapAndPriorityQueueLeetcode295
    {
        private readonly PriorityQueue<int, int> _small;
        private readonly PriorityQueue<int, int> _large;
        public Q73FindMedianFromDataStreamHeapAndPriorityQueueLeetcode295()
        {
            _small = new PriorityQueue<int, int>();
            _large = new PriorityQueue<int, int>();
        }

        public void AddNum(int num)
        {
            _small.Enqueue(num, -num);

            // Make sure every num in small is <= every num in large
            if (_small.TryPeek(out var maxElement, out _) && _large.TryPeek(out var minElement, out _) && maxElement > minElement)
            {
                _small.TryDequeue(out var element, out _);
                _large.Enqueue(element, element);
            }

            // Uneven size ?
            if (_small.Count > _large.Count + 1)
            {
                _small.TryDequeue(out var element, out _);
                _large.Enqueue(element, element);
            }
            else if (_large.Count > _small.Count + 1)
            {
                _large.TryDequeue(out var element, out _);
                _small.Enqueue(element, -element);
            }
        }

        public double FindMedian()
        {
            if (_small.Count > _large.Count)
            {
                _small.TryPeek(out var element, out _);
                return element;
            }
            else if (_large.Count > _small.Count)
            {
                _large.TryPeek(out var element, out _);
                return element;
            }
            else
            {
                _small.TryPeek(out var element1, out _);
                _large.TryPeek(out var element2, out _);
                return (double)(element1 + element2) / 2;
            }
        }
    }
}

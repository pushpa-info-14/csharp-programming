using CSharpProgramming.Study.General;

namespace CSharpProgramming.Tests.General
{
    public class SampleQueueTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sampleQueue = new SampleQueue();
            sampleQueue.Test();
        }
    }
}
